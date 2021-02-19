 using System;
using System.Collections.Generic;
using System.Text;

namespace Guitar_Fretboard
{
    static class DisplayFretboard
    {
        public static void LeftHanded(List<InstrumentString> strings, int numberOfFrets)
        {
            Console.WriteLine("Below is a fretboard diagram for a left-handed guitar/bass.");
            strings[0].CountLeft(numberOfFrets);
            Console.WriteLine();
            int numberOfStrings = strings.Count;

            for (int index = 0; index < numberOfStrings; index++)
            {
                strings[index].DrawStringLeft(numberOfFrets);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public static void RightHanded(List<InstrumentString> strings, int numberOfFrets)
        {
            Console.WriteLine("Below is a fretboard diagram for a right-handed guitar/bass.");
            strings[0].CountRight(numberOfFrets);
            Console.WriteLine();
            int numberOfStrings = strings.Count;

            for (int index = 0; index < numberOfStrings; index++)
            {
                strings[index].DrawStringRight(numberOfFrets);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
