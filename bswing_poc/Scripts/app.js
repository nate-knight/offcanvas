
$(document).ready(function () {
    var query = parseQuery(document.location.search.substring(1));
    
    $.getJSON('api/menu',query, function (data) {

        var html = '<ul>';
        html += '<li class="top-spacer"></li>';
        html += '<li class="title">Uber Planner</li>';
        for (var key in data) {
            html += buildNode(key, data[key]);
        }
        html += '</ul>';

        $("#offCanvasMenu").html(html);

        new mlPushMenu(document.getElementById('mp-menu'), document.getElementById('trigger'), { type: 'cover'});
    });

    function buildNode(key, val) {

        var html = "";

        if (val.menuTitle) {
            //html += '<li class="' + (val.submenus ? 'icon icon-arrow-right-4' : '') + '">';
            html += '<li class="' + (val.submenus ? 'icon icon-arrow-right-4' : '') + '">';
            //html += '<a href="#">' + val.menuTitle + '</a>';
            html += '<a href="' + (val.url || '#') + '">' + val.menuTitle + '</a>';
            
            if (val.submenus) {
                html += '<div class="mp-level">';
                html += '<ul>';
                //spacer
                html += "<li class='top-spacer'></li>";
                //back button
                html += '<li class="icon icon-arrow-left mp-back"><a href="#">Back</a></li>';
                //category title
                html += '<li class="mp-cat-title"><a href="' + (val.url || '#') +  '">' + val.menuTitle + '</a></li>';

                for (var subkey in val.submenus) {
                    html += buildNode(subkey, val.submenus[subkey]);
                }
                
                html += '</ul></div>';
                
            }

            //html += "<div><div>";
            html += '</li>';
        }
        return html;
    }
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
