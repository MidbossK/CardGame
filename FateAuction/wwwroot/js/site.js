
xhttp.open(
    "GET",
    " cards.stuff ",
    true
    );
xhttp.send();




//Players deck array: Database ---> Deck
let p1Deck = [] 

//Players hand array: Deck ---> Hand
let p1Hand = []


//Select random card from the player's deck
//Push card from from player's deck array to player's hand
function p1Draw() {
    let p1TopCard = DrawnCard[Math.floor(Math.random() * p1Deck.length)];
    p1Hand.push(p1TopCard);
    }



function p2Draw(){
    let p2TopCard = Math.floor(Math.random() * cards.length);
    }