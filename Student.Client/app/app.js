(function () {
    "use strict";

    var app = angular.module("studentManagement",
                            ["common.services", "ui.router"]);

    app.config(["$stateProvider", function ($stateProvider, $urlRouterProvider) {

        $urlRouterProvider.otherwise("/students");

        $stateProvider.state("studentList", {
            url: "/students",
            templateUrl: "app/student/studentListView.html",
            controller: "studentListCtrl as vm"
        })

    }]
        );


}());