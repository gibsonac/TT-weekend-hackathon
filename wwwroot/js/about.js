$(document).ready(function(){
    var onMobile = false;
    //checking if we're on a mobile device or not
    function areWeOnMobile(){ 
        if($(window).width() < 600){
            onMobile = true;
        }
        else{
            onMobile = false;
        }
        return onMobile;
    }
//click listening event for changing the bio to match the selected employee photo
    $('.employee-pic').click(function(){
        //if we're on mobile device
        if(areWeOnMobile()){ 
            var theID = $(this).attr('id');
            theID = theID.charAt(theID.length -1);
            $('.Bios').css('display', 'none');
            $('.employee-pic').addClass('Pic-half-opacity');
            $(this).removeClass('Pic-half-opacity');
            $('#Mobile-Person-'+theID).css('display', 'block');
            // adjusting screen location to showcase bio on mobile
            var screen_location = $("#Person-pic-"+theID);
            var offset = screen_location.offset();
            window.scrollTo(offset.left, offset.top);
        }
        //else we aren't on mobile and below happens
        else{
            var theID = $(this).attr('id');
            theID = theID.charAt(theID.length -1);
            $('.Bios').css('display', 'none');
            $('.employee-pic').addClass('Pic-half-opacity');
            $(this).removeClass('Pic-half-opacity');
            $('#Person-'+theID).css('display', 'block');  
        }
    })
    //everytime the screen resizes, it rechecks screen size
    $(window).resize(function(){
        var currentOnMobileStatus = onMobile;
        onMobile = areWeOnMobile();
        if(!currentOnMobileStatus == onMobile){
            //firing click even on currently open bio
            $('.employee-pic').not($('.Pic-half-opacity'))[0].click();
        }
    });
    
});



// this was the working desktop solution. nested in a 'when windows loaded' function. will continue working on mobile friendly version above
// $('.employee-pic').click(function(){
//     var theID = $(this).attr('id');
//     theID = theID.charAt(theID.length -1);
//     $('.Bios').css('display', 'none');
//     $('.employee-pic').addClass('Pic-half-opacity');
//     $(this).removeClass('Pic-half-opacity');
//     $('#Person-'+theID).css('display', 'block');
// })