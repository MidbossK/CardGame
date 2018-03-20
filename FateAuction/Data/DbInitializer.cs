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
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for Appstatuses
                if (context.Cards.Any())
                {
                    return;   // DB has been seeded
                }

                var CardsSeed = new Cards[]
                {
                    new Cards {
                         Card = "Two of Diamonds"},

                    new Cards {
                         Card = "Three of Diamonds"},

                    new Cards {
                         Card = "Four of Diamonds"},

                    new Cards {
                         Card = "Five of Diamonds"},

                    new Cards {
                         Card = "Six of Diamonds"},

                    new Cards {
                         Card = "Seven of Diamonds"},

                    new Cards {
                         Card = "Eight of Diamonds"},

                    new Cards {
                         Card = "Nine of Diamonds"},

                    new Cards {
                         Card = "Ten of Diamonds"},

                    new Cards {
                         Card = "Jack of Diamonds"},

                    new Cards {
                         Card = "Queen of Diamonds"},

                    new Cards {
                         Card = "King of Diamonds"},

                    new Cards {
                         Card = "Ace of Diamonds"},

                    new Cards {
                         Card = "Two of Clubs"},

                    new Cards {
                         Card = "Three of Clubs"},

                    new Cards {
                         Card = "Four of Clubs"},

                    new Cards {
                         Card = "Five of Clubs"},

                    new Cards {
                         Card = "Six of Clubs"},

                    new Cards {
                         Card = "Seven of Clubs"},

                    new Cards {
                         Card = "Eight of Clubs"},

                    new Cards {
                         Card = "Nine of Clubs"},

                    new Cards {
                         Card = "Ten of Clubs"},

                    new Cards {
                         Card = "Jack of Clubs"},

                    new Cards {
                         Card = "Queen of Clubs"},

                    new Cards {
                         Card = "King of Clubs"},

                    new Cards {
                         Card = "Ace of Clubs"},

                    new Cards {
                         Card = "Two of Hearts"},

                    new Cards {
                         Card = "Three of Hearts"},

                    new Cards {
                         Card = "Four of Hearts"},

                    new Cards {
                         Card = "Five of Hearts"},

                    new Cards {
                         Card = "Six of Hearts"},

                    new Cards {
                         Card = "Seven of Hearts"},

                    new Cards {
                         Card = "Eight of Hearts"},

                    new Cards {
                         Card = "Nine of Hearts"},

                    new Cards {
                         Card = "Ten of Hearts"},

                    new Cards {
                         Card = "Jack of Hearts"},

                    new Cards {
                         Card = "Queen of Hearts"},

                    new Cards {
                         Card = "King of Hearts"},

                    new Cards {
                         Card = "Ace of Hearts"},

                    new Cards {
                        Card = "Two of Spades"},

                    new Cards {
                        Card = "Three of Spades"},

                    new Cards {
                        Card = "Four of Spades"},

                    new Cards {
                        Card = "Five of Spades"},

                    new Cards {
                        Card = "Six of Spades"},

                    new Cards {
                        Card = "Seven of Spades"},

                    new Cards {
                        Card = "Eight of Spades"},

                    new Cards {
                        Card = "Nine of Spades"},

                    new Cards {
                        Card = "Ten of Spades"},

                    new Cards {
                        Card = "Jack of Spades"},

                    new Cards {
                        Card = "Queen of Spades"},

                    new Cards {
                        Card = "King of Spades"},

                    new Cards {
                        Card = "Ace of Spades"},



                };
            }
        }
    }   
}
