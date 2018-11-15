var header2 = document.getElementsByTagName('h2')
// var btn= document.getElementsByClassName('btn')

for (let i = 0; i < header2.length; i += 1) {
    header2[i].addEventListener('mouseover' , () => {
        header2[i].textContent = header2[i].textContent.toUpperCase();
});

header2[i].addEventListener('mouseout' , () => {
    header2[i].textContent = header2[i].textContent.toLowerCase();
});
}

var hasBeenClicked = false;
jQuery('#button1').click(function () {
    hasBeenClicked = true;
});
      
if (hasBeenClicked) {
    $('#formSubmitted').hide().slideDown(700).delay(2000).slideUp(700);
} else {
    $('#formSubmitted').hide();
}     


//  $('#button1').click(function() {
//  if  $('#formSubmitted').hide().slideDown(700).delay(2000).slideUp(700); 
//     });


