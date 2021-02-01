using System;
using System.Collections.Generic;
using System.Text;

namespace Guitar_Fretboard
{
    class GuitarString
    {
        private int[] fret = new int[25];
        private string[] note = new string[25];

        public int[] Fret
        {
            get
            {
                return fret;
            }
            set
            {
                fret = value;
            }
        }

        public string[] Note
        {
            get
            {
                return note;
            }
            set
            {
                note = value;
            }
        }
        public GuitarString()
        {

        }

        public GuitarString(string open, string fretOne, string fretTwo, string fretThree, string fretFour, string fretFive, string fretSix, string fretSeven, string fretEight, string fretNine,
            string fretTen, string fretEleven)
        {
            for (int fretNumber = 0; fretNumber < 25; fretNumber++)
            {
                fret[fretNumber] = fretNumber;
            }
            this.note[0] = open;
            this.note[1] = fretOne;
            this.note[2] = fretTwo;
            this.note[3] = fretThree;
            this.note[4] = fretFour;
            this.note[5] = fretFive;
            this.note[6] = fretSix;
            this.note[7] = fretSeven;
            this.note[8] = fretEight;
            this.note[9] = fretNine;
            this.note[10] = fretTen;
            this.note[11] = fretEleven;
            this.note[12] = open;
            this.note[13] = fretOne;
            this.note[14] = fretTwo;
            this.note[15] = fretThree;
            this.note[16] = fretFour;
            this.note[17] = fretFive;
            this.note[18] = fretSix;
            this.note[19] = fretSeven;
            this.note[20] = fretEight;
            this.note[21] = fretNine;
            this.note[22] = fretTen;
            this.note[23] = fretEleven;
            this.note[24] = open;
        }

        public void DrawStringLeft()
        {
            for (int count = 22; count >= 0; count--)
            {
                Console.Write(note[count] + " ");
            }
        }

        public void DrawStringRight()
        {
            for (int count = 0; count < 23; count++)
            {
                Console.Write(note[count] + " ");
            }
        }

        public void CountLeft()
        {
            for (int count = 22; count >= 0; count--)
            {
                if (count < 10)
                { 
                    Console.Write(fret[count] + "  "); 
                }
                else
                {
                    Console.Write(fret[count] + " ");
                }
            }
        }

        public void CountRight()
        {
            for (int count = 0; count < 23; count++)
            {
                if (count < 10)
                {
                    Console.Write(fret[count] + "  ");
                }
                else
                {
                    Console.Write(fret[count] + " ");
                }
            }
        }

        public void DrawStringLeft24()
        {
            for (int count = 24; count >= 0; count--)
            {
                Console.Write(note[count] + " ");
            }
        }

        public void DrawStringRight24()
        {
            for (int count = 0; count < 25; count++)
            {
                Console.Write(note[count] + " ");
            }
        }

        public void CountLeft24()
        {
            for (int count = 24; count >= 0; count--)
            {
                if (count < 10)
                {
                    Console.Write(fret[count] + "  ");
                }
                else
                {
                    Console.Write(fret[count] + " ");
                }
            }
        }

        public void CountRight24()
        {
            for (int count = 0; count < 25; count++)
            {
                if (count < 10)
                {
                    Console.Write(fret[count] + "  ");
                }
                else
                {
                    Console.Write(fret[count] + " ");
                }
            }
        }
    }
}
