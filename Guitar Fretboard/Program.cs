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

            Tuning tuning = new Tuning();

            List<GuitarString> eStandard = new List<GuitarString>();
            tuning.EStandard(eStandard);

            List<GuitarString> eFlatStandard = new List<GuitarString>();
            tuning.EFlatStandard(eFlatStandard);

            List<GuitarString> bassEStandard = new List<GuitarString>();
            tuning.BassEStandard(bassEStandard);

            List<GuitarString> currentTuning = eStandard;

            bool refreshMenu = true;

            while (refreshMenu)
            {
                Console.Clear();
                Console.WriteLine("Which option would you like to do? Press 'Q' to exit");
                Console.WriteLine("1. Display Left-handed fretboard");
                Console.WriteLine("2. Display Right-handed fretboard");
                Console.WriteLine("3. Display Left-handed fretboard with 24 frets");
                Console.WriteLine("4. Display Right-handed fretboard with 24 frets");
                Console.WriteLine("5. Begin random fret quiz");
                Console.WriteLine("6. Change Tuning");
                string menuOption = Console.ReadLine().ToLower();

                switch (menuOption)
                {
                    case "1":
                        Console.Clear();
                        DisplayFretboard.LeftHanded(currentTuning);
                        break;

                    case "2":
                        Console.Clear();
                        DisplayFretboard.RightHanded(currentTuning);
                        break;

                    case "3":
                        Console.Clear();
                        DisplayFretboard.LeftHanded24(currentTuning);
                        break;

                    case "4":
                        Console.Clear();
                        DisplayFretboard.RightHanded24(currentTuning);
                        break;

                    case "5":
                        Console.Clear();
                        QuestionAnswer.RepeatQuestionAnswerLoop(currentTuning);
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("Select your tuning:");
                        Console.WriteLine("1. E Standard (default)");
                        Console.WriteLine("2. E Flat Standard (AKA D# Standard)");
                        string tuningChoice = Console.ReadLine().ToLower();

                        switch (tuningChoice)
                        {
                            case "1":
                                currentTuning = eStandard;
                                break;
                            case "2":
                                currentTuning = eFlatStandard;
                                break;
                            default:
                                Console.WriteLine("Invalid selection. You will be returned to main menu.");
                                Console.ReadLine();
                                break;
                        }
                        break;

                    case "q":
                        refreshMenu = false;
                        break;
                }
            }
        }
    }
}
