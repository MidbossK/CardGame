﻿using FateAuction.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FateAuction.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            {
                if (context.Cards.Any())
                {
                    return;   // DB has been seeded
                }

                if (context.Tarot.Any())
                {
                    return;   // DB has been seeded
                }

                var CardsSeed = new Cards[]
                {
                    new Cards {
                         Card = "Two of Diamonds",
                         PointValue = 2,
                         PictureURL = "~/images/card_diamond2.png",
                    },

                    new Cards {
                         Card = "Three of Diamonds",
                         PointValue = 3,
                         PictureURL = "~/images/card_diamond3.png",
                    },

                    new Cards {
                         Card = "Four of Diamonds",
                         PointValue = 4,
                         PictureURL = "~/images/card_diamond4.png",
                    },

                    new Cards {
                         Card = "Five of Diamonds",
                         PointValue = 5,
                         PictureURL = "~/images/card_diamond5.png",
                    },

                    new Cards {
                         Card = "Six of Diamonds",
                         PointValue = 6,
                         PictureURL = "~/images/card_diamond6.png",
                    },

                    new Cards {
                         Card = "Seven of Diamonds",
                         PointValue = 7,
                         PictureURL = "~/images/card_diamond7.png",
                    },

                    new Cards {
                         Card = "Eight of Diamonds",
                         PointValue = 8,
                         PictureURL = "~/images/card_diamond8.png",
                    },

                    new Cards {
                         Card = "Nine of Diamonds",
                         PointValue = 9,
                         PictureURL = "~/images/card_diamond9.png",
                    },

                    new Cards {
                         Card = "Ten of Diamonds",
                         PointValue = 10,
                         PictureURL = "~/images/card_diamond10.png",
                    },

                    new Cards {
                         Card = "Jack of Diamonds",
                         PointValue = 11,
                         PictureURL = "~/images/card_diamondJ.png",
                    },

                    new Cards {
                         Card = "Queen of Diamonds",
                         PointValue = 12,
                         PictureURL = "~/images/card_diamondQ.png",
                    },

                    new Cards {
                         Card = "King of Diamonds",
                         PointValue = 13,
                         PictureURL = "~/images/card_diamondK.png",
                    },

                    new Cards {
                         Card = "Ace of Diamonds",
                         PointValue = 1,
                         PictureURL = "~/images/card_diamondA.png",
                    },

                    new Cards {
                         Card = "Two of Clubs",
                         PointValue = 2,
                         PictureURL = "~/images/card_club2.png",
                    },

                    new Cards {
                         Card = "Three of Clubs",
                         PointValue = 3,
                         PictureURL = "~/images/card_club3.png",
                    },

                    new Cards {
                         Card = "Four of Clubs",
                         PointValue = 4,
                         PictureURL = "~/images/card_club4.png",
                    },

                    new Cards {
                         Card = "Five of Clubs",
                         PointValue = 5,
                         PictureURL = "~/images/card_club5.png",
                    },

                    new Cards {
                         Card = "Six of Clubs",
                         PointValue = 6,
                         PictureURL = "~/images/card_club6.png",
                    },

                    new Cards {
                         Card = "Seven of Clubs",
                         PointValue = 7,
                         PictureURL = "~/images/card_club7.png",
                    },

                    new Cards {
                         Card = "Eight of Clubs",
                         PointValue = 8,
                         PictureURL = "~/images/card_club8.png",
                    },

                    new Cards {
                         Card = "Nine of Clubs",
                         PointValue = 9,
                         PictureURL = "~/images/card_club9.png",
                    },

                    new Cards {
                         Card = "Ten of Clubs",
                         PointValue = 10,
                         PictureURL = "~/images/card_club10.png",
                    },

                    new Cards {
                         Card = "Jack of Clubs",
                         PointValue = 11,
                         PictureURL = "~/images/card_clubJ.png",
                    },

                    new Cards {
                         Card = "Queen of Clubs",
                         PointValue = 12,
                         PictureURL = "~/images/card_clubQ.png",
                    },

                    new Cards {
                         Card = "King of Clubs",
                         PointValue = 13,
                         PictureURL = "~/images/card_clubK.png",
                    },

                    new Cards {
                         Card = "Ace of Clubs",
                         PointValue = 1,
                         PictureURL = "~/images/card_clubA.png",
                    },

                    new Cards {
                         Card = "Two of Hearts",
                         PointValue = 2,
                         PictureURL = "~/images/card_heart2.png",
                    },

                    new Cards {
                         Card = "Three of Hearts",
                         PointValue = 3,
                         PictureURL = "~/images/card_heart3.png",
                    },

                    new Cards {
                         Card = "Four of Hearts",
                         PointValue = 4,
                         PictureURL = "~/images/card_heart4.png",
                    },

                    new Cards {
                         Card = "Five of Hearts",
                         PointValue = 5,
                         PictureURL = "~/images/card_heart5.png",
                    },

                    new Cards {
                         Card = "Six of Hearts",
                         PointValue = 6,
                         PictureURL = "~/images/card_heart6.png",
                    },

                    new Cards {
                         Card = "Seven of Hearts",
                         PointValue = 7,
                         PictureURL = "~/images/card_heart7.png",
                    },

                    new Cards {
                         Card = "Eight of Hearts",
                         PointValue = 8,
                         PictureURL = "~/images/card_heart8.png",
                    },

                    new Cards {
                         Card = "Nine of Hearts",
                         PointValue = 9,
                         PictureURL = "~/images/card_heart9.png",
                    },

                    new Cards {
                         Card = "Ten of Hearts",
                         PointValue = 10,
                         PictureURL = "~/images/card_heart10.png",
                    },

                    new Cards {
                         Card = "Jack of Hearts",
                         PointValue = 11,
                         PictureURL = "~/images/card_heartJ.png",
                    },

                    new Cards {
                         Card = "Queen of Hearts",
                         PointValue = 12,
                         PictureURL = "~/images/card_heartQ.png",
                    },

                    new Cards {
                         Card = "King of Hearts",
                         PointValue = 13,
                         PictureURL = "~/images/card_heartK.png",
                    },

                    new Cards {
                         Card = "Ace of Hearts",
                         PointValue = 1,
                         PictureURL = "~/images/card_heartA.png",
                    },

                    new Cards {
                        Card = "Two of Spades",
                         PointValue = 2,
                         PictureURL = "~/images/card_spade2.png",
                    },

                    new Cards {
                        Card = "Three of Spades",
                         PointValue = 3,
                         PictureURL = "~/images/card_spade3.png",
                    },

                    new Cards {
                        Card = "Four of Spades",
                         PointValue = 4,
                         PictureURL = "~/images/card_spade4.png",
                    },

                    new Cards {
                        Card = "Five of Spades",
                         PointValue = 5,
                         PictureURL = "~/images/card_spade5.png",
                    },

                    new Cards {
                        Card = "Six of Spades",
                         PointValue = 6,
                         PictureURL = "~/images/card_spade6.png",
                    },

                    new Cards {
                        Card = "Seven of Spades",
                         PointValue = 7,
                         PictureURL = "~/images/card_spade7.png",
                    },

                    new Cards {
                        Card = "Eight of Spades",
                         PointValue = 8,
                         PictureURL = "~/images/card_spade8.png",
                    },

                    new Cards {
                        Card = "Nine of Spades",
                         PointValue = 9,
                         PictureURL = "~/images/card_spade9.png",
                    },

                    new Cards {
                        Card = "Ten of Spades",
                         PointValue = 10,
                         PictureURL = "~/images/card_spade10.png",
                    },

                    new Cards {
                        Card = "Jack of Spades",
                         PointValue = 11,
                         PictureURL = "~/images/card_spadeJ.png",
                    },

                    new Cards {
                        Card = "Queen of Spades",
                         PointValue = 12,
                         PictureURL = "~/images/card_spadeQ.png",
                    },

                    new Cards {
                        Card = "King of Spades",
                         PointValue = 13,
                         PictureURL = "~/images/card_spadeK.png",
                    },

                    new Cards {
                        Card = "Ace of Spades",
                         PointValue = 1,
                         PictureURL = "~/images/card_spadeA.png",
                    },

                };

                var TarotSeed = new Tarot[] {

                    new Tarot {
                        TarotName = "The Magician",
                        PointValue = 1,
                        PictureURL = "~/images/tc1.png",
                    },

                    new Tarot {
                        TarotName = "The High Priestess",
                        PointValue = 2,
                        PictureURL = "~/images/tc2.png",
                    },

                    new Tarot {
                        TarotName = "The Empress",
                        PointValue = 3,
                        PictureURL = "~/images/tc3.png",
                    },

                    new Tarot {
                        TarotName = "The Emperor",
                        PointValue = 4,
                        PictureURL = "~/images/tc4.png",
                    },

                    new Tarot {
                        TarotName = "The Hierophant",
                        PointValue = 5,
                        PictureURL = "~/images/tc5.png",
                    },

                    new Tarot {
                        TarotName = "The Lovers",
                        PointValue = 6,
                        PictureURL = "~/images/tc6.png",
                    },

                    new Tarot {
                        TarotName = "The Chariot",
                        PointValue = 7,
                        PictureURL = "~/images/tc7.png",
                    },

                    new Tarot {
                        TarotName = "Strength",
                        PointValue = 8,
                        PictureURL = "~/images/tc8.png",
                    },

                    new Tarot {
                        TarotName = "The Hermit",
                        PointValue = 9,
                        PictureURL = "~/images/tc9.png",
                    },

                    new Tarot {
                        TarotName = "Wheel of Fortune",
                        PointValue = 10,
                        PictureURL = "~/images/tc10.png",
                    },
                     new Tarot {
                        TarotName = "Justice",
                        PointValue = 11,
                        PictureURL = "~/images/tc11.png",
                    },

                    new Tarot {
                        TarotName = "The Hanged Man",
                        PointValue = 12,
                        PictureURL = "~/images/tc12.png",
                    },


                    new Tarot {
                        TarotName = "Death",
                        PointValue = 13,
                        PictureURL = "~/images/tc13.png",
                    },

                    new Tarot {
                        TarotName = "Temperance",
                        PointValue = 14,
                        PictureURL = "~/images/tc14.png",
                    },

                    new Tarot {
                        TarotName = "The Devil",
                        PointValue = 15,
                        PictureURL = "~/images/tc15.png",
                    },

                    new Tarot {
                        TarotName = "The Tower",
                        PointValue = 16,
                        PictureURL = "~/images/tc16.png",
                    },

                    new Tarot {
                        TarotName = "The Star",
                        PointValue = 17,
                        PictureURL = "~/images/tc17.png",
                    },

                    new Tarot {
                        TarotName = "The Moon",
                        PointValue = 18,
                        PictureURL = "~/images/tc18.png",
                    },

                    new Tarot {
                        TarotName = "The Sun",
                        PointValue = 19,
                        PictureURL = "~/images/tc19.png",
                    },

                    new Tarot {
                        TarotName = "Judgement",
                        PointValue = 20,
                        PictureURL = "~/images/tc20.png",
                    },

                    new Tarot {
                        TarotName = "The World",
                        PointValue = 21,
                        PictureURL = "~/images/tc21.png",
                    },

                    new Tarot {
                        TarotName = "The Fool",
                        PointValue = 22,
                        PictureURL = "~/images/tc0.png",
                    },

                };


                foreach (Cards i in CardsSeed)
                {
                    context.Cards.Add(i);
                }

                foreach (Tarot t in TarotSeed)
                {
                    context.Tarot.Add(t);
                }


                context.SaveChanges();
            }
        }
    }   
}
