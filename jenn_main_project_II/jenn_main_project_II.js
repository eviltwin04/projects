// This javascript is for my main headers to change from upper to lowercase 

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

 
// This javascript is for my form submission announcement 

function button1() {
    $('#formSubmitted').show().slideDown(700).delay(2000).slideUp(700);
}


// This javascript is for my Resume PDF checkbox

const $odd = $('a:odd');
const $secureLinks = $('a[href^="https://"]');
//^ means 'starts with. $ in the below context means the string at the end of an attribute value

const $pdfs = $('a[href$="pdf"]');


$secureLinks.attr('target', '_blank');
$pdfs.attr('download', true);

$secureLinks.addClass('secure');

$pdfs.addClass('pdf');

$pdfs.on('click', function(){
   
//check to see if chheckbox has been checked
//if zero checkboxes have been checked
if ($(':checked').length === 0) {
//prevent download of document
event.preventDefault();
//alert the user
alert('Please check the box to allow PDF downloads');
}

});

// $('#links').apend($pdfCheckbox);

$('a').each(function(index, link) {
    // console.log(index, $(element).attr('href'));
});





