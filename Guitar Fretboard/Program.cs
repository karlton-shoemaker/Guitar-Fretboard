using System;
using System.Collections.Generic;

namespace Guitar_Fretboard
{
    class Program
    {
        static void Main(string[] args)
        {
            //Goals for program:
            //-Add additional tunings
            //-Create filter for different keys
            //-Add quizzes for other instruments: bass (cut off bString and highEString), ukulele, banjo, etc.

            //GuitarString eString = new GuitarString("E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#");
            //GuitarString aString = new GuitarString("A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#");
            //GuitarString dString = new GuitarString("D ", "D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#");
            //GuitarString gString = new GuitarString("G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#");
            //GuitarString bString = new GuitarString("B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#");
            //GuitarString highEString = new GuitarString("e ", "f ", "f#", "g ", "g#", "a ", "a#", "b ", "c ", "c#", "d ", "d#");

            Tuning tuning = new Tuning();

            DisplayFretboard displayFretboard = new DisplayFretboard();
            QuestionAnswer questionAnswer = new QuestionAnswer();

            List<GuitarString> eStandard = new List<GuitarString>();
            tuning.EStandard(eStandard);

            List<GuitarString> eFlatStandard = new List<GuitarString>();
            tuning.EFlatStandard(eFlatStandard);

            bool refreshMenu = true;

            while (refreshMenu)
            {
                Console.Clear();
                Console.WriteLine("Which option would you like to do? Press 'Q' to exit.");
                Console.WriteLine("1. Display Left-handed fretboard.");
                Console.WriteLine("2. Display Right-handed fretboard.");
                Console.WriteLine("3. Display Left-handed fretboard with 24 frets.");
                Console.WriteLine("4. Display Right-handed fretboard with 24 frets.");
                Console.WriteLine("5. Begin random fret quiz.");
                string menuOption = Console.ReadLine().ToLower();

                switch (menuOption)
                {
                    case "1":
                        Console.Clear();
                        displayFretboard.LeftHanded(eStandard);
                        break;

                    case "2":
                        Console.Clear();
                        displayFretboard.RightHanded(eStandard);
                        break;

                    case "3":
                        Console.Clear();
                        displayFretboard.LeftHanded24(eStandard);
                        break;

                    case "4":
                        Console.Clear();
                        displayFretboard.RightHanded24(eStandard);
                        break;

                    case "5":
                        Console.Clear();
                        questionAnswer.RepeatQuestionAnswerLoop(eStandard);
                        break;

                    case "q":
                        refreshMenu = false;
                        break;
                }
            }
        }
    }
}
