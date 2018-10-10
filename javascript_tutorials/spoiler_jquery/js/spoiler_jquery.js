
// // Hide the spoiler text
// $('.spoiler span').hide();
// // When the button is pressed
// $('.spoiler button').on('click', function(){
//     //show the spoiler text
//     $('.spoiler span').show();
//     //hide the review spoiler button
//     $('.spoiler button').hide();
// });

$('.spoiler').on('click', 'button', function(event){
    console.log(event.target);
 //show the spoiler text
    $(event.target).prev().show();
    //hide the review spoiler button
    // $('.spoiler button').hide(); replaced this old code with below code to specifically tartet the button clicked
    $(event.target).hide();
});

//create the reveal spoiler button
const $button = $('<button>Reveal Spoiler</button>');
//append to web page
$('.spoiler').append($button);
// // Hide the spoiler text
$('.spoiler span').hide();

