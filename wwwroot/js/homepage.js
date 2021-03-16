// This function changes the top nav's look when you scroll vs when you are at the top of the page.
$(window).scroll(function () {
    // ------------ controlling the fading scroll feature of navbar ---------
    if ($(window).scrollTop() >= 20) {
        $('.navbar').addClass('nav-scrolled');
        $('.nav-text-color').css("color", "black");
        $('.btn').addClass("btn-secondary");
        $('#logo-white').addClass("hidden");
        $('#logo-black').removeClass("hidden");
    } 
    else {
        $('.navbar').removeClass('nav-scrolled');
        $('.nav-text-color').css("color", "white");
        $('.btn').removeClass("btn-secondary");
        $('#logo-white').removeClass("hidden");
        $('#logo-black').addClass("hidden");
    }
    // ------------ creating the fade in feature when someone scrolls down for the first time on the page ------------
    var windowBottom = $(this).scrollTop() + $(this).innerHeight();
    $(".fade-in-section").each(function() {
      /* Check the location of each desired element */
      var objectBottom = $(this).offset().top + $(this).outerHeight();
      /* If the element is completely within bounds of the window, fade it in */
      if (objectBottom < windowBottom) 
      {
        if ($(this).css("opacity")==0) 
        { //changing opacity from 0 to 1
            $(this).fadeTo(500,1);
        }
      }
    });
});
// ------------ end of scroll feature for navbar ---------

// --------- controlling the background video so it only plays on tablet or desktop  ---------
function deferVideo() {
    //defer html5 video loading
  $("#background-video").each(function() {
    var sourceFile = $(this).attr("data-src");  
    $(this).attr("src", sourceFile);
  });  
}  
$(document).ready(function(){
    // if(window.matchMedia("(max-width: 767px)").matches){
    if(!$('#background-video').is(':visible')){
        // We're likely on mobile view, so do nothing. This will render the image instead of background video
    } else{
        // We're likely on tablet or desktop, lets load the background video!
        deferVideo();
    }    
    var num = 1;
    function rotateImage(num){
        setTimeout(function(){ 
            $('.image-controller').removeClass('image-controller-focused');
            $('#image-controller-'+num).addClass('image-controller-focused');
            $('.Scrolling-Images').css('display', 'none');
            $('#Image'+num).css('display', 'block');
            if(num == 3){
                num = 1;
            }    
            else{
                num++
            }    
            rotateImage(num);
        },4000);     
    }    
    rotateImage(num);
});    
// ----------- end of background video section ---------

