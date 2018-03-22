//Players deck array: Database ---> Deck
let p1Deck = []
let p2Deck = []

//Players hand array: Deck ---> Hand
let p1Hand = []
let p2Hand = []

//Players played cards for bidding: Hand ---> Playing Field
let p1Field = []
let p2Field = []

//Discard array: Any used player cards ---
let playerDiscard = []

//Tarot Deck: Database ---> Tarot Deck
let tarotDeck = []

//Tarot Auction Card: Auction Deck ---> Auction Market
let auctionMarket = []

//Tarots that were bought to move to players score array: Auction Market ---> Score Pile
let scorePile =[]


//Select random card from the player's deck
//Push card from from player's deck array to player's hand
//Essentially "draws" one card.
function p1Draw() {
    let p1TopCard = DrawnCard[Math.floor(Math.random() * p1Deck.length)];
    p1Hand.push(p1TopCard);
    }

function p1Draw() {
    let p2TopCard = DrawnCard[Math.floor(Math.random() * p2Deck.length)];
    p2Hand.push(p2TopCard);
}
//===============================================================================
//========================== Preloading the game ================================
//Once a new game is created, request assets for database, and fill arrays
function gamePreload() {
    xhttp.open(
        "GET",
        " cards.stuff ",
        true
    );
    xhttp.send();


 //When game begins, fills players opening hands with 7 cards
    let openingHand = 1;
    function openingDraw() {
        p1Draw(openingHand);
        p2Draw();
        if (openingHand < 7) {
            openingHand++
            window.setTimeout(foo, 500);
        }
    }
    openingDraw();
}
//===============================================================================
//===============================================================================

//End of game scoring: Loops over scorePile array
//Pulls "pointValue" key from each card
//Adds for final score
function pointsSum(, ) {
    return  
}