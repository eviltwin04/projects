const $odd = $('a:odd');
const $secureLinks = $('a[href^="https://"]');
//^ means 'starts with. $ in the below context means the string at the end of an attribute value

const $pdfs = $('a[href$="pdf"]');


$secureLinks.attr('target', '_blank');
$pdfs.attr('download', true);

$odd.css('backgroundColor', 'lightgrey');

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

$('#links').apend($pdfCheckbox);

$('a').each(function(index, link) {
    // console.log(index, $(element).attr('href'));
});