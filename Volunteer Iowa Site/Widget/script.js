(function () {

    // Localize jQuery variable
    var jQuery;


    function getUrlVars() {
        var vars = {};
        var parts = window.location.href.replace(/[?&]+([^=&]+)=([^&]*)/gi, function (m, key, value) {
            vars[key] =  value; 
        });
        
        return vars;
    }

    /******** Load jQuery if not present *********/
    if (window.jQuery === undefined || window.jQuery.fn.jquery !== '1.9.1') {
        var script_tag = document.createElement('script');
        script_tag.setAttribute("type", "text/javascript");
        script_tag.setAttribute("src",
            "http://code.jquery.com/jquery-1.7.1.min.js");
        if (script_tag.readyState) {
            script_tag.onreadystatechange = function () { // For old versions of IE
                if (this.readyState == 'complete' || this.readyState == 'loaded') {
                    scriptLoadHandler();
                }
            };
        } else {
            script_tag.onload = scriptLoadHandler;
        }
        // Try to find the head, otherwise default to the documentElement
        (document.getElementsByTagName("head")[0] || document.documentElement).appendChild(script_tag);
    } else {
        // The jQuery version on the window is the one we want to use
        jQuery = window.jQuery;
        main();
    }

    /******** Called once jQuery has loaded ******/
    function scriptLoadHandler() {
        // Restore $ and window.jQuery to their previous values and store the
        // new jQuery in our local jQuery variable
        jQuery = window.jQuery.noConflict(true);
        // Call our main function
        main();
    }

    /******** Our main function ********/


    var prefix = getUrlVars()["hostLoc"];
    if (prefix === undefined)
        prefix = '';

    function main() {
        jQuery(document).ready(function ($) {
            /******* Load CSS *******/
            var css_link = $("<link>", {
                rel: "stylesheet",
                type: "text/css",
                href: prefix + "/widget/style.css"
            });
            css_link.appendTo('head');

            /******* Load HTML *******/
            myhtml = '<div class="my50-widget-container">'+
            '<div class="my50-top"></div>' +
            '<div class="my50-content"></div>' +
            '<div class="my50-links"></div>'+
            '<div>';

            $('#whats-your-50-container').html( myhtml );

        });
    }

})(); // We call our anonymous function immediately