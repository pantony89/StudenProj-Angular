(function () {
    "use strict";
    angular
        .module("studentManagement")
        .controller("studentListCtrl", ["studentResource", studentListCtrl]);

    function studentListCtrl(studentResource) {
        var vm = this;
        debugger;
        studentResource.query(function (data) {
            vm.students = data;
        });      
    }
}());
