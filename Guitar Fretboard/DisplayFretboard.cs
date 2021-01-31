 using System;
using System.Collections.Generic;
using System.Text;

namespace Guitar_Fretboard
{
    class DisplayFretboard
    {
        public void LeftHanded(GuitarString eString, GuitarString highEString, GuitarString bString, GuitarString gString, GuitarString dString, GuitarString aString)
        {
            Console.WriteLine("Below is a fretboard diagram for a left-handed guitar.");
            eString.CountLeft();
            Console.WriteLine();
            highEString.DrawStringLeft();
            Console.WriteLine();
            bString.DrawStringLeft();
            Console.WriteLine();
            gString.DrawStringLeft();
            Console.WriteLine();
            dString.DrawStringLeft();
            Console.WriteLine();
            aString.DrawStringLeft();
            Console.WriteLine();
            eString.DrawStringLeft();
            Console.WriteLine();
        }
        public void RightHanded(GuitarString eString, GuitarString highEString, GuitarString bString, GuitarString gString, GuitarString dString, GuitarString aString)
        {
            Console.WriteLine("Below is a fretboard diagram for a right-handed guitar.");
            eString.CountRight();
            Console.WriteLine();
            highEString.DrawStringRight();
            Console.WriteLine();
            bString.DrawStringRight();
            Console.WriteLine();
            gString.DrawStringRight();
            Console.WriteLine();
            dString.DrawStringRight();
            Console.WriteLine();
            aString.DrawStringRight();
            Console.WriteLine();
            eString.DrawStringRight();
            Console.WriteLine();
        }
    }
}
