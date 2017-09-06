$(function () {
   // alert("this works!");

    //$("#title").text("Yay, I can now get at the H1 immediately!");

    //$("#first").html("<h2>Great quotes</h2>");

    $("#first").prepend("<h2>Great quotes</h2>");
    $("#first").append("<h3>... for you to ponder ... </h3>");

    $("#myAnchor").attr("href", "http://channel9.msdn.com");

    $("#title").addClass("standout");
});
/*
$('.importantText')
$('#myFirstParagraph')
$('p').fadeOut();

jQuery('<div id="badge"><img src="badge.gif" alt="Badge earned for achievement"></div>')

$.myCustomMethod = function () { alert('hi'); };

$.listBox = {
    show: function () { },
    hide: function () { },
    position: function () { },
    initiate: function () { }
};


jQuery('#myFirstParagraph').fadeOut(10000).fadeIn(10000);
*/

