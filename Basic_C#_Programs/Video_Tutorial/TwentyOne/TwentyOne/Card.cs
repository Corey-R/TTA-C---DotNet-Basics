using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne // NOTE: both classes have the same namespace
{    
   public struct Card // Note: You want ONE class per file
    {                
        // thinking about the what is a card, what properties make up a card
        // cards have numbers, a suit (heart, diamonds, etc.), a front and back, etc.
        // the first property we will create is the suit of a card denoted by string datat type...
        public Suit Suit { get; set; } // C# shorthand way to create property 
        // NOTE: get and set are the only two things that can be done to a property in C#
        // public allows the property to be accessible to other programs
        // string is the data type of the property
        // Suit is the name of the property
        // You can "get" the property and/or you can "set" the property
        public Face Face { get; set; }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace            
    }
}
