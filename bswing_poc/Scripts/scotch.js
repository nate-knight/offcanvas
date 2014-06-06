/*
* Uses jQuery!!!!111one
*/


/*====================================
=            ON DOM READY            =
====================================*/
$(function () {

    // Toggle Nav on Click
    $('.toggle-nav').click(function () {
        // Calling a function in case you want to expand upon this.
        toggleNav();
       
    });


});


/*========================================
=            CUSTOM FUNCTIONS            =
========================================*/
function toggleNav() {

    $('#site-wrapper').toggleClass('show-nav');
}