﻿(function () {
    "use strict";
    angular
        .module("studentManagement")
        .controller("studentListCtrl", ["studentResource", studentListCtrl]);

    

    function studentListCtrl(studentResource) {
        var vm = this;

        studentResource.query( function (data) {
            vm.students = data;
        });

        vm.studentDel = function()
        {
            alert("hi");
        };

    }
}());
