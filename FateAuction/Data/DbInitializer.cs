using FateAuction.Models;
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
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Three of Diamonds",
                         PointValue = 3,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Four of Diamonds",
                         PointValue = 4,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Five of Diamonds",
                         PointValue = 5,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Six of Diamonds",
                         PointValue = 6,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Seven of Diamonds",
                         PointValue = 7,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Eight of Diamonds",
                         PointValue = 8,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Nine of Diamonds",
                         PointValue = 9,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Ten of Diamonds",
                         PointValue = 10,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Jack of Diamonds",
                         PointValue = 11,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Queen of Diamonds",
                         PointValue = 12,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "King of Diamonds",
                         PointValue = 13,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Ace of Diamonds",
                         PointValue = 1,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Two of Clubs",
                         PointValue = 2,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Three of Clubs",
                         PointValue = 3,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Four of Clubs",
                         PointValue = 4,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Five of Clubs",
                         PointValue = 5,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Six of Clubs",
                         PointValue = 6,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Seven of Clubs",
                         PointValue = 7,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Eight of Clubs",
                         PointValue = 8,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Nine of Clubs",
                         PointValue = 9,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Ten of Clubs",
                         PointValue = 10,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Jack of Clubs",
                         PointValue = 11,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Queen of Clubs",
                         PointValue = 12,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "King of Clubs",
                         PointValue = 13,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Ace of Clubs",
                         PointValue = 1,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Two of Hearts",
                         PointValue = 2,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Three of Hearts",
                         PointValue = 3,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Four of Hearts",
                         PointValue = 4,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Five of Hearts",
                         PointValue = 5,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Six of Hearts",
                         PointValue = 6,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Seven of Hearts",
                         PointValue = 7,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Eight of Hearts",
                         PointValue = 8,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Nine of Hearts",
                         PointValue = 9,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Ten of Hearts",
                         PointValue = 10,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Jack of Hearts",
                         PointValue = 11,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Queen of Hearts",
                         PointValue = 12,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "King of Hearts",
                         PointValue = 13,
                         PictureURL = ,
                    },

                    new Cards {
                         Card = "Ace of Hearts",
                         PointValue = 1,
                         PictureURL = ,
                    },

                    new Cards {
                        Card = "Two of Spades",
                         PointValue = 2,
                         PictureURL = ,
                    },

                    new Cards {
                        Card = "Three of Spades",
                         PointValue = 3,
                         PictureURL = ,
                    },

                    new Cards {
                        Card = "Four of Spades",
                         PointValue = 4,
                         PictureURL = ,
                    },

                    new Cards {
                        Card = "Five of Spades",
                         PointValue = 5,
                         PictureURL = ,
                    },

                    new Cards {
                        Card = "Six of Spades",
                         PointValue = 6,
                         PictureURL = ,
                    },

                    new Cards {
                        Card = "Seven of Spades",
                         PointValue = 7,
                         PictureURL = ,
                    },

                    new Cards {
                        Card = "Eight of Spades",
                         PointValue = 8,
                         PictureURL = ,
                    },

                    new Cards {
                        Card = "Nine of Spades",
                         PointValue = 9,
                         PictureURL = ,
                    },

                    new Cards {
                        Card = "Ten of Spades",
                         PointValue = 10,
                         PictureURL = ,
                    },

                    new Cards {
                        Card = "Jack of Spades",
                         PointValue = 11,
                         PictureURL = ,
                    },

                    new Cards {
                        Card = "Queen of Spades",
                         PointValue = 12,
                         PictureURL = ,
                    },

                    new Cards {
                        Card = "King of Spades",
                         PointValue = 13,
                         PictureURL = ,
                    },

                    new Cards {
                        Card = "Ace of Spades",
                         PointValue = 1,
                         PictureURL = ,
                    },

                };

                var TarotSeed = new Tarot[] {

                    new Tarot {
                        TarotName = "The Magician",
                        PointValue = 1,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "The High Priestess",
                        PointValue = 2,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "The Empress",
                        PointValue = 3,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "The Emperor",
                        PointValue = 4,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "The Hierophant",
                        PointValue = 5,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "The Lovers",
                        PointValue = 6,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "The Chariot",
                        PointValue = 7,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "Strength",
                        PointValue = 8,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "The Hermit",
                        PointValue = 9,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "Wheel of Fortune",
                        PointValue = 10,
                        PictureURL = ,
                    },
                     new Tarot {
                        TarotName = "Justice",
                        PointValue = 11,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "The Hanged Man",
                        PointValue = 12,
                        PictureURL = ,
                    },


                    new Tarot {
                        TarotName = "Death",
                        PointValue = 13,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "Temperance",
                        PointValue = 14,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "The Devil",
                        PointValue = 15,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "The Tower",
                        PointValue = 16,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "The Star",
                        PointValue = 17,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "The Moon",
                        PointValue = 18,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "The Sun",
                        PointValue = 19,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "Judgement",
                        PointValue = 20,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "The World",
                        PointValue = 21,
                        PictureURL = ,
                    },

                    new Tarot {
                        TarotName = "The Fool",
                        PointValue = 22,
                        PictureURL = ,
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
