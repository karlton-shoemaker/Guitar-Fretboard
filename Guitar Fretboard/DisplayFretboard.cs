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
            Console.ReadKey();
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
            Console.ReadKey();
        }
        public void LeftHanded24(GuitarString eString, GuitarString highEString, GuitarString bString, GuitarString gString, GuitarString dString, GuitarString aString)
        {
            Console.WriteLine("Below is a fretboard diagram for a left-handed guitar.");
            eString.CountLeft24();
            Console.WriteLine();
            highEString.DrawStringLeft24();
            Console.WriteLine();
            bString.DrawStringLeft24();
            Console.WriteLine();
            gString.DrawStringLeft24();
            Console.WriteLine();
            dString.DrawStringLeft24();
            Console.WriteLine();
            aString.DrawStringLeft24();
            Console.WriteLine();
            eString.DrawStringLeft24();
            Console.WriteLine();
            Console.ReadKey();
        }
        public void RightHanded24(GuitarString eString, GuitarString highEString, GuitarString bString, GuitarString gString, GuitarString dString, GuitarString aString)
        {
            Console.WriteLine("Below is a fretboard diagram for a right-handed guitar.");
            eString.CountRight24();
            Console.WriteLine();
            highEString.DrawStringRight24();
            Console.WriteLine();
            bString.DrawStringRight24();
            Console.WriteLine();
            gString.DrawStringRight24();
            Console.WriteLine();
            dString.DrawStringRight24();
            Console.WriteLine();
            aString.DrawStringRight24();
            Console.WriteLine();
            eString.DrawStringRight24();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
