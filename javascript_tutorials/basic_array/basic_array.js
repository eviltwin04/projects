var playList = [
    ['I Did It My Way', 'Frank Sinatra'],
    ['Respect', 'Aretha Franklin'],
    ['Imagine', 'John Lennon'],
    ['Born to Run', 'Bruce Springsteen'],
    ['Louie Louie', 'The Kingsmen'], 
    ['Maybellene', 'Chuck Berry']
  ];
  
  function print(message) {
    document.write(message);
  }
  
  function printSongs( songs ) {
    var listHTML = '<ol>';
    for ( var i = 0; i < songs.length; i += 1) {
      listHTML += '<li>' + songs[i][0] + ' by ' + songs[i][1] + '</li>';
    }
    listHTML += '</ol>';
    document.write(listHTML);
  }
  
  printSongs(playList);

/*push adds to the end of an array
unshift adds to the beginning
pop removes from the end
shift removes from the beginning*/ 