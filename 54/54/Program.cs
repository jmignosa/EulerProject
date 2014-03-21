using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace _54
{
    public enum cardSuit
    {
        Clubs,
        Hearts,
        Spades,
        Diamonds
    }

    public enum cardNumber
    {
        Ace = 14,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }

    class card : IComparable
    {
        public cardSuit suit {get;set;}
        public cardNumber face{get;set;}

        public override string ToString()
        {
            return face + " of " + suit;
        }

        public int CompareTo(object obj)
        {
            card thecard = (card)obj;
            if (this.face > thecard.face)
                return 1;
            if (this.face < thecard.face)
                return -1;
            return 0;
        }
        
    }


    class Program
    {
        public static List<string> bothhands = new List<string>();

        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();
            StreamReader sr = new StreamReader(@"poker.txt");
            card[] hand1 = new card[5];
            card[] hand2 = new card[5];
            int hand1value = 0;
            int hand2value = 0;
            int player1wins = 0;
            int player2wins = 0;

            st.Start();
            for (int i = 0; i < 5; i++)
            {
                hand1[i] = new card();
                hand2[i] = new card();
            }
            
            while (sr.Peek() >= 0)
            {
                bothhands.Add(sr.ReadLine());
            }
            
            foreach (var line in bothhands)
            {
                cardread(line, 0, hand1[0]);
                cardread(line, 1, hand1[1]);
                cardread(line, 2, hand1[2]);
                cardread(line, 3, hand1[3]);
                cardread(line, 4, hand1[4]);
                cardread(line, 5, hand2[0]);
                cardread(line, 6, hand2[1]);
                cardread(line, 7, hand2[2]);
                cardread(line, 8, hand2[3]);
                cardread(line, 9, hand2[4]);
                Array.Sort(hand1);
                Array.Sort(hand2);
                
                hand1value = GetValue(hand1);
                hand2value = GetValue(hand2);
                if (hand1value > hand2value)
                {
                    player1wins++;
                    //Console.WriteLine("{0} {1} {2} {3} {4} || {5} {6} {7} {8} {9} ",
                    //    hand1[0], hand1[1], hand1[2], hand1[3], hand1[4],
                    //    hand2[0], hand2[1], hand2[2], hand2[3], hand2[4]);
                    //Console.WriteLine("Player 1 wins {0} to {1}", hand1value, hand2value);
                    continue;
                }
                if (hand1value < hand2value)
                {
                    player2wins++;
                    //Console.WriteLine("{0} {1} {2} {3} {4} || {5} {6} {7} {8} {9} ",
                    //    hand1[0], hand1[1], hand1[2], hand1[3], hand1[4],
                    //    hand2[0], hand2[1], hand2[2], hand2[3], hand2[4]);
                    //Console.WriteLine("Player 2 wins {0} to {1}", hand1value, hand2value);
                    continue;
                }
                if (hand1value == hand2value)
                {
                    //Console.WriteLine("{0} {1} {2} {3} {4} || {5} {6} {7} {8} {9} ",
                    //    hand1[0], hand1[1], hand1[2], hand1[3], hand1[4],
                    //    hand2[0], hand2[1], hand2[2], hand2[3], hand2[4]);
                    //Console.WriteLine("Tie game {0} to {1}", hand1value, hand2value);
                    if (hand1value == 100)
                    {
                        int temp=pairtiebreak(hand1, hand2);
                        if (temp==1)
                            player1wins++;
                        else
                            player2wins++;
                        continue;
                    }
                    if (hand1value <15)
                    {
                        int temp = hctiebreak(hand1, hand2);
                        if (temp==1)
                            player1wins++;
                        else
                            player2wins++;
                        continue;
                    }
                    throw new Exception();
                }
                //compare each hand and declare winner
                //update 
            }
            st.Stop();
            Console.WriteLine("Player1 {0} vs Player2 {1}. Elapsed time {2} ms", player1wins, player2wins,st.ElapsedMilliseconds);
            
        }

        public static void cardread(string line, int cardnum, card hand)
        {
            string crd = line.Substring(cardnum * 3, 2).ToLower();
            switch (crd[0])
            {
                case '2':
                    hand.face = cardNumber.Two;
                    break;
                case '3':
                    hand.face = cardNumber.Three;
                    break;
                case '4':
                    hand.face = cardNumber.Four;
                    break;
                case '5':
                    hand.face = cardNumber.Five;
                    break;
                case '6':
                    hand.face = cardNumber.Six;
                    break;
                case '7':
                    hand.face = cardNumber.Seven;
                    break;
                case '8':
                    hand.face = cardNumber.Eight;
                    break;
                case '9':
                    hand.face = cardNumber.Nine;
                    break;
                case 't':
                    hand.face = cardNumber.Ten;
                    break;
                case 'j':
                    hand.face = cardNumber.Jack;
                    break;
                case 'q':
                    hand.face = cardNumber.Queen;
                    break;
                case 'k':
                    hand.face = cardNumber.King;
                    break;
                case 'a':
                    hand.face = cardNumber.Ace;
                    break;
            }
            switch (crd[1])
            { 
                case 'c':
                    hand.suit = cardSuit.Clubs;
                    break;
                case 's':
                    hand.suit = cardSuit.Spades;
                    break;
                case 'h':
                    hand.suit = cardSuit.Hearts;
                    break;
                case 'd':
                    hand.suit = cardSuit.Diamonds;
                    break;
            }
            
        }


        public static int GetValue(card[] hand)
        {
            int returnval = 0;
            
            if (isStraightFlush(hand))
                return (1100 + (int)hand[4].face);
            if (isFourofAKind(hand))
                return (1000 + (int)hand[3].face);
            if (isFullHouse(hand))
            {
                returnval = 900;
                returnval += (int)hand[2].face;
                return returnval;
            }
            if (isFlush(hand))
                return (800 + (int)hand[4].face);
            if (isStraight(hand))
                return (700 + (int)hand[4].face);
            if (isThree(hand))
            {
                returnval = 600;
                returnval += 6*(int)hand[2].face;
                return returnval;
                
            }
            if (isTwoPair(hand))
            {
                if (hand[0].face == hand[1].face && hand[2].face == hand[3].face)
                    returnval=35*(int)hand[2].face+8*(int)hand[0].face+(int)hand[4].face;
                if (hand[1].face == hand[2].face && hand[3].face == hand[4].face)
                    returnval = 35 * (int)hand[3].face + 8 * (int)hand[1].face + (int)hand[0].face;
                if (hand[0].face == hand[1].face && hand[3].face == hand[4].face)
                    returnval = 35 * (int)hand[3].face + 8 * (int)hand[1].face + (int)hand[2].face;
                return returnval;
            }
            if (isAPair(hand))
            {
                return 100;
            }
            return highCard(hand);
        }

        public static int pairtiebreak(card[] hnd1, card[] hnd2)
        {
            int hand1value = 0;
            int hand2value = 0;
            if (hnd1[0].face==hnd1[1].face)
                hand1value= 1000*(int)hnd1[0].face + 100*(int)hnd1[4].face + 10*(int)hnd1[3].face+(int)hnd1[2].face;

            if (hnd2[0].face == hnd2[1].face)
                hand2value = 1000 * (int)hnd2[0].face + 100 * (int)hnd2[4].face + 10 * (int)hnd2[3].face + (int)hnd2[2].face;

            if (hnd1[1].face == hnd1[2].face)
                hand1value = 1000 * (int)hnd1[1].face + 100 * (int)hnd1[4].face + 10 * (int)hnd1[3].face + (int)hnd1[0].face;

            if (hnd2[1].face == hnd2[2].face)
                hand2value = 1000 * (int)hnd2[1].face + 100 * (int)hnd2[4].face + 10 * (int)hnd2[3].face + (int)hnd2[0].face;

            if (hnd1[2].face == hnd1[3].face)
                hand1value = 1000 * (int)hnd1[2].face + 100 * (int)hnd1[4].face + 10 * (int)hnd1[1].face + (int)hnd1[0].face;

            if (hnd2[2].face == hnd2[3].face)
                hand2value = 1000 * (int)hnd2[2].face + 100 * (int)hnd2[4].face + 10 * (int)hnd2[1].face + (int)hnd2[0].face;

            if (hnd1[3].face == hnd1[4].face)
                hand1value = 1000 * (int)hnd1[3].face + 100 * (int)hnd1[2].face + 10 * (int)hnd1[1].face + (int)hnd1[0].face;

            if (hnd2[3].face == hnd2[4].face)
                hand2value = 1000 * (int)hnd2[3].face + 100 * (int)hnd2[2].face + 10 * (int)hnd2[1].face + (int)hnd2[0].face;
            //Console.WriteLine("Pair tiebreak hand1 {0} hand2 {1} ", hand1value, hand2value);
            if (hand1value > hand2value)
                return 1;
            else
                return 2;
        }

        public static int hctiebreak(card[] hnd1, card[] hnd2)
        {
            return 0;
        }

        public static bool isStraightFlush(card[] theHand)
        {
            if (isStraight(theHand) && isFlush(theHand))
                return true;
            return false;
        }

        public static bool isFourofAKind(card[] theHand)
        {
            if (theHand[0].face == theHand[1].face && theHand[1].face == theHand[2].face && theHand[2].face == theHand[3].face)
                return true;
            if (theHand[1].face == theHand[2].face && theHand[2].face == theHand[3].face && theHand[3].face == theHand[4].face)
                return true;
            return false;
        }

        public static bool isFullHouse(card[] theHand)
        {
            if ((theHand[0].face == theHand[1].face && theHand[2].face == theHand[3].face && 
                theHand[3].face == theHand[4].face) || (theHand[3].face == theHand[4].face && 
                theHand[0].face == theHand[1].face && theHand[1].face == theHand[2].face))
                return true;
            return false;
        }

        public static bool isFlush(card[] theHand)
        {
            bool isflush=true;
            for(int i=0;i<4;i++)
            {
                if (theHand[i].suit != theHand[i + 1].suit)
                    isflush = false;
            }
            return isflush;
        }
        
        public static bool isStraight(card[] theHand)
        {
            bool isstraight = true;
            for (int i = 0; i < 4; i++)
            {
                int diff = theHand[i].face - theHand[i+1].face;
                if (diff != -1)
                    isstraight = false;
            }
            return isstraight;
        }

        public static bool isThree(card[] theHand)
        {
            if (theHand[0].face == theHand[1].face && theHand[1].face==theHand[2].face)
                return true;
            if (theHand[1].face == theHand[2].face && theHand[2].face == theHand[3].face)
                return true;
            if (theHand[2].face == theHand[3].face && theHand[2].face == theHand[4].face)
                return true;
            return false;
        }

        public static bool isTwoPair(card[] theHand)
        {
            if (theHand[0].face == theHand[1].face && theHand[2].face == theHand[3].face)
                return true;
            if (theHand[1].face == theHand[2].face && theHand[3].face == theHand[4].face)
                return true;
            if (theHand[0].face == theHand[1].face && theHand[3].face == theHand[4].face)
                return true;
            return false;
        }

        public static bool isAPair(card[] theHand)
        {
            if ((theHand[0].face == theHand[1].face) || (theHand[1].face == theHand[2].face) || (theHand[2].face == theHand[3].face) ||
                (theHand[3].face == theHand[4].face))
                return true;
            return false;
        }

        public static int highCard(card[] theHand)
        {
            //Console.WriteLine("**********************************************************");
            return (int)theHand[4].face;
        }

    }
}
