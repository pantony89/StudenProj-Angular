(function () {
    "use strict";
    angular
        .module("studentManagement")
        .controller("studentListCtrl", ["studentResource", studentListCtrl]);

    function studentListCtrl(studentResource) {
        var vm = this;
        vm.get = function () {
           vm.user = this.student;
            $('#viewModal').modal('show');
        };

        vm.searchCriteria = "Anto";

        studentResource.query({ search: vm.searchCriteria }, function (data) {
            vm.students = data;
        });
    }
}());
