var app = angular.module('app', []);


app.controller('poc', function ($scope, $http) {
   
    //$scope.menuItemsa = [{ "menuTitle": "People", "submenus": [{ "menuTitle": "This Week", "submenus": [{ "menuTitle": "Monday", "submenus": null }, { "menuTitle": "Tuesday", "submenus": null }] }, { "menuTitle": "This Month", "submenus": [{ "menuTitle": "First Week", "submenus": null }, { "menuTitle": "Second Week", "submenus": null }] }, { "menuTitle": "Over/Under Report", "submenus": null }, { "menuTitle": "By Person", "submenus": null }] }, { "menuTitle": "Projects", "submenus": null }, { "menuTitle": "Teams", "submenus": null }, { "menuTitle": "Reports", "submenus": null }, { "menuTitle": "TimeClock", "submenus": null }];

    


});


$(document).ready(function () {
    var query = parseQuery(document.location.search.substring(1));
    
    $.getJSON('api/menu',query, function (data) {

        var html = '<ul>';
        for (var key in data) {
            html += buildNode(key, data[key]);
        }
        html += '</ul>';

        $("#offCanvasMenu").html(html);

        new mlPushMenu(document.getElementById('mp-menu'), document.getElementById('trigger'), {
            type: 'cover'
        });
    });

    function buildNode(key, val) {

        var html = "";

        if (val.hasOwnProperty('menuTitle')) {
            html += '<li class="icon icon-arrow-left">';
            html += '<a href="#">' + val.menuTitle + '</a>';
            html += '<div class="mp-level">';
            html += '<h2>' + val.menuTitle + '</h2>';
            html += '<a class="mp-back" href="#">back</a>';
           
            console.log(val.menuTitle);
            if (val.hasOwnProperty('submenus')) {
                html += "<ul>";
                for (var subkey in val.submenus) {
                    html += buildNode(subkey, val.submenus[subkey]);
                }
                html += "</ul>";
            }
            html += '</div></li>';
        }

        return html;
    }

    //var buildMenu = function () {
        
    //};

    

    

});

app.directive('offCanvasMenu', function ($timeout, $http) {
    return {
        restrict: 'E',
        templateUrl: 'offCanvasMenu.html',
        controller: function ($scope) {
            //get querystring
            var query = parseQuery(document.location.search.substring(1));
            $http({
                method: 'GET',
                url: 'api/menu',
                params: { user: query.user || ''}
            }).success(function (data) {
                $scope.menuItems = data;
            });
        },
        link: function postLink(elem, attrs, transclude) {
            $timeout(function () {
                $timeout(function () {
                    // This code will run after
                    // templateUrl has been loaded, cloned
                    // and transformed by directives.
                    // and properly rendered by the browser
                    //load push menu after angular replaces dom
                    new mlPushMenu(document.getElementById('mp-menu'), document.getElementById('trigger'), {
                        type: 'cover'
                    });
                }, 0);
            }, 0);
        }
    };
});

function parseQuery(qstr) {
    var query = {};
    var a = qstr.split('&');
    for (var i in a) {
        var b = a[i].split('=');
        query[decodeURIComponent(b[0])] = decodeURIComponent(b[1]);
    }

    return query;
}
