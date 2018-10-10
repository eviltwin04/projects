//$('#flashMessage').hide();
//$('#flashMessage').slideDown(2000);
//$('#flashMessage').delay(3000);
//$('#flashMessage').slideUp(2000);

// $('#flashMessage').hide().slideDown(2000).delay(3000).slideUp(2000);

// const title = "My First Blog Post";
// const content = "This is my <strong>first</strong> blog post";

// $('#blogTitlePreview').text(title);
// $('#blogContentPreview').html(content); 
// This gets the # because it's an id

$('#flashMessage').hide();

$('#previewButton').click(function(){
const title = $('#blogTitleInput').val();
const content = $('#blogContentInput').val();

$('#blogTitlePreview').text(title);
$('#blogContentPreview').html(content); 

$('#flashMessage').slideDown(2000).delay(3000).slideUp(2000);
});

