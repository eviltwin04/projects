var playList = [
    'I Did It My Way',
    'Respect',
    'Imagine',
    'Born to Run',
    'Louie Louie',
    'Maybellene'
  ];
  
  function print(message) {
    document.write(message);
  }

  function printList( list ) {
      var listHTML = '<ol>';
      for ( var i = 0; i < list.length; i += 1){
          listHTML += '<li>' + list[i] + '</li>';
      }
      listHTML += '</ol>';
      print(listHTML);
    }
    printList(playList);
/*push adds to the end of an array
unshift adds to the beginning
pop removes from the end
shift removes from the beginning*/ 