 using System;
using System.Collections.Generic;
using System.Text;

namespace Guitar_Fretboard
{
    class DisplayFretboard
    {
        GuitarString guitarString = new GuitarString();

        public void LeftHanded(GuitarString eString, GuitarString highEString, GuitarString bString, GuitarString gString, GuitarString dString, GuitarString aString)
        {
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
