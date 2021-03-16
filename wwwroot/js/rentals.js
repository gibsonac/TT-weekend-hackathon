
$(document).ready(function(){
    // FOUND A BETTER WORKING SOLUTION I'M TESTING ON RENTALS.CSHTML PAGE. I SHOULD BE ABLE TO AVOID JQUERY INQUIRY ALL TOGETHER AND JUST CONTROL VIA CSS. COMMENTING OUT THE BELOW FUNCTION FOR NOW AS I TEST


    // this builds the modal if you create just one modal and want to populate it with data. when you click onto an individual rental building, the modal (pasted at end of cshtml page) popup appears with carousel of images and all content that was relevant to that selection
    // $('#exampleModal').on('show.bs.modal', function (event) {
    //     var button = $(event.relatedTarget) // Button that triggered the modal
    //     var title = button.data('title') 
    //     var description = button.data('description')
    //     var address = button.data('address')
    //     var pictures = button.data('picture')
    //     pictures = pictures.split(',')

    //     var modal = $(this)
    //     for(var x = 0; x < pictures.length-1; x++){
    //         if(x ==0){
    //         $('#IndividualRentalCarousel .carousel-inner').append("<div class='carousel-item active'><img src='/images/"+pictures[x]+"' class='d-block w-100'></div>")
    //         }
    //         else{
    //         $('#IndividualRentalCarousel .carousel-inner').append("<div class='carousel-item'><img src='/images/"+pictures[x]+"' class='d-block w-100'></div>")
    //         }
    //     }
    //     modal.find('.modal-title').text('Viewing: ' + title)
    //     modal.find('.modal-body .title').text(title)
    //     modal.find('.modal-body .description').append(description)
    //     modal.find('.modal-body .address').append(address)
    // })
})