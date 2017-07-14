(function () {
    var app = angular.module("studentManagement", []);
    var baseAddress = 'http://localhost:58885/api/Student/';
    var url = "";

    app.factory('studentFactory', function ($http) {
        return {
            getStudentsList: function () {
                url = baseAddress + "GetStudentsList";
                return $http.get(url);
            }
        };
    });

    app.controller('studentListCtrl', function PostController($scope, studentFactory) {

        $scope.students = [];
        $scope.user = null;
        $scope.editMode = false;

        $scope.getAll = function () {
            studentFactory.getStudentsList().success(function (data) {
                $scope.students = data;
            }).error(function (data) {
                $scope.error = "Error Accered while Loading!" + data.ExceptioExceptionMessage;
            });
        };
    });
}());

