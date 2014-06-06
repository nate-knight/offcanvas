var app = angular.module('app', []);


app.controller('poc', function ($scope, $http) {
   
    $scope.menuItemsa = [{ "menuTitle": "People", "submenus": [{ "menuTitle": "This Week", "submenus": [{ "menuTitle": "Monday", "submenus": null }, { "menuTitle": "Tuesday", "submenus": null }] }, { "menuTitle": "This Month", "submenus": [{ "menuTitle": "First Week", "submenus": null }, { "menuTitle": "Second Week", "submenus": null }] }, { "menuTitle": "Over/Under Report", "submenus": null }, { "menuTitle": "By Person", "submenus": null }] }, { "menuTitle": "Projects", "submenus": null }, { "menuTitle": "Teams", "submenus": null }, { "menuTitle": "Reports", "submenus": null }, { "menuTitle": "TimeClock", "submenus": null }];

    $http({
        method: 'GET',
        url: 'api/menu',
        params: { user: 'nate' }
    }).success(function (data) {
        $scope.menuItems = data;
    });


});
