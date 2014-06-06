var app = angular.module('app', []);

app.run(function () {

 

  
});

app.controller('poc', function ($scope) {

    $scope.menuItems = [
        {
            "menuTitle": "People",
            "submenus" :[
                {
                    "menuTitle": "This Week",
                    "submenus": [
                        { "menuTitle": "Monday" },
                        { "menuTitle": "Tuesday" }
                        ]
                },
                { "menuTitle": "This Month" },
                { "menuTitle": "Over/Under Report" },
                { "menuTitle": "By Person" }
                ]
        },
        { "menuTitle": "Projects" },
        { "menuTitle": "Teams" },
        { "menuTitle": "Reports" },
        { "menuTitle": "TimeClock" },
        { "menuTitle": "Devices" }

    ];

   

    $scope.phones = [{ "text": "Super Smart Phone" }, {"text" : "Black Magic Mobile"}]


});