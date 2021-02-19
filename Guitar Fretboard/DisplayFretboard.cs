 using System;
using System.Collections.Generic;
using System.Text;

namespace Guitar_Fretboard
{
    static class DisplayFretboard
    {
        //public static void LeftHanded(List<GuitarString> strings)
        //{
        //    Console.WriteLine("Below is a fretboard diagram for a left-handed guitar.");
        //    strings[0].CountLeft();
        //    Console.WriteLine();
        //    strings[0].DrawStringLeft();
        //    Console.WriteLine();
        //    strings[1].DrawStringLeft();
        //    Console.WriteLine();
        //    strings[2].DrawStringLeft();
        //    Console.WriteLine();
        //    strings[3].DrawStringLeft();
        //    Console.WriteLine();
        //    strings[4].DrawStringLeft();
        //    Console.WriteLine();
        //    strings[5].DrawStringLeft();
        //    Console.WriteLine();
        //    Console.ReadKey();
        //}

        public static void LeftHanded(List<InstrumentString> strings)
        {
            Console.WriteLine("Below is a fretboard diagram for a left-handed guitar.");
            strings[0].CountLeft(24);
            Console.WriteLine();
            int numberOfStrings = strings.Count;

            for (int index = 0; index < numberOfStrings; index++)
            {
                strings[index].DrawStringLeft(24);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public static void RightHanded(List<InstrumentString> strings)
        {
            Console.WriteLine("Below is a fretboard diagram for a right-handed guitar.");
            strings[0].CountRight(24);
            Console.WriteLine();
            int numberOfStrings = strings.Count;

            for (int index = 0; index < numberOfStrings; index++)
            {
                strings[index].DrawStringRight(24);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        //public static void RightHanded(List<InstrumentString> strings)
        //{
        //    Console.WriteLine("Below is a fretboard diagram for a right-handed guitar.");
        //    strings[0].CountRight();
        //    Console.WriteLine();
        //    strings[0].DrawStringRight();
        //    Console.WriteLine();
        //    strings[1].DrawStringRight();
        //    Console.WriteLine();
        //    strings[2].DrawStringRight();
        //    Console.WriteLine();
        //    strings[3].DrawStringRight();
        //    Console.WriteLine();
        //    strings[4].DrawStringRight();
        //    Console.WriteLine();
        //    strings[5].DrawStringRight();
        //    Console.WriteLine();
        //    Console.ReadKey();
        //}
        public static void LeftHanded24(List<InstrumentString> strings)
        {
            Console.WriteLine("Below is a fretboard diagram for a left-handed guitar.");
            strings[0].CountLeft24();
            Console.WriteLine();
            strings[0].DrawStringLeft24();
            Console.WriteLine();
            strings[1].DrawStringLeft24();
            Console.WriteLine();
            strings[2].DrawStringLeft24();
            Console.WriteLine();
            strings[3].DrawStringLeft24();
            Console.WriteLine();
            strings[4].DrawStringLeft24();
            Console.WriteLine();
            strings[5].DrawStringLeft24();
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void RightHanded24(List<InstrumentString> strings)
        {
            Console.WriteLine("Below is a fretboard diagram for a right-handed guitar.");
            strings[0].CountRight24();
            Console.WriteLine();
            strings[0].DrawStringRight24();
            Console.WriteLine();
            strings[1].DrawStringRight24();
            Console.WriteLine();
            strings[2].DrawStringRight24();
            Console.WriteLine();
            strings[3].DrawStringRight24();
            Console.WriteLine();
            strings[4].DrawStringRight24();
            Console.WriteLine();
            strings[5].DrawStringRight24();
            Console.WriteLine();
            Console.ReadKey();
        }
        //public void LeftHanded(GuitarString eString, GuitarString highEString, GuitarString bString, GuitarString gString, GuitarString dString, GuitarString aString)
        //{
        //    Console.WriteLine("Below is a fretboard diagram for a left-handed guitar.");
        //    eString.CountLeft();
        //    Console.WriteLine();
        //    highEString.DrawStringLeft();
        //    Console.WriteLine();
        //    bString.DrawStringLeft();
        //    Console.WriteLine();
        //    gString.DrawStringLeft();
        //    Console.WriteLine();
        //    dString.DrawStringLeft();
        //    Console.WriteLine();
        //    aString.DrawStringLeft();
        //    Console.WriteLine();
        //    eString.DrawStringLeft();
        //    Console.WriteLine();
        //    Console.ReadKey();
        //}
        //public void RightHanded(GuitarString eString, GuitarString highEString, GuitarString bString, GuitarString gString, GuitarString dString, GuitarString aString)
        //{
        //    Console.WriteLine("Below is a fretboard diagram for a right-handed guitar.");
        //    eString.CountRight();
        //    Console.WriteLine();
        //    highEString.DrawStringRight();
        //    Console.WriteLine();
        //    bString.DrawStringRight();
        //    Console.WriteLine();
        //    gString.DrawStringRight();
        //    Console.WriteLine();
        //    dString.DrawStringRight();
        //    Console.WriteLine();
        //    aString.DrawStringRight();
        //    Console.WriteLine();
        //    eString.DrawStringRight();
        //    Console.WriteLine();
        //    Console.ReadKey();
        //}
        //public void LeftHanded24(GuitarString eString, GuitarString highEString, GuitarString bString, GuitarString gString, GuitarString dString, GuitarString aString)
        //{
        //    Console.WriteLine("Below is a fretboard diagram for a left-handed guitar.");
        //    eString.CountLeft24();
        //    Console.WriteLine();
        //    highEString.DrawStringLeft24();
        //    Console.WriteLine();
        //    bString.DrawStringLeft24();
        //    Console.WriteLine();
        //    gString.DrawStringLeft24();
        //    Console.WriteLine();
        //    dString.DrawStringLeft24();
        //    Console.WriteLine();
        //    aString.DrawStringLeft24();
        //    Console.WriteLine();
        //    eString.DrawStringLeft24();
        //    Console.WriteLine();
        //    Console.ReadKey();
        //}
        //public void RightHanded24(GuitarString eString, GuitarString highEString, GuitarString bString, GuitarString gString, GuitarString dString, GuitarString aString)
        //{
        //    Console.WriteLine("Below is a fretboard diagram for a right-handed guitar.");
        //    eString.CountRight24();
        //    Console.WriteLine();
        //    highEString.DrawStringRight24();
        //    Console.WriteLine();
        //    bString.DrawStringRight24();
        //    Console.WriteLine();
        //    gString.DrawStringRight24();
        //    Console.WriteLine();
        //    dString.DrawStringRight24();
        //    Console.WriteLine();
        //    aString.DrawStringRight24();
        //    Console.WriteLine();
        //    eString.DrawStringRight24();
        //    Console.WriteLine();
        //    Console.ReadKey();
        //}
    }
}
