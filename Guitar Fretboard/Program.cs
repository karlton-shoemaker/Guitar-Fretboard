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

            List<InstrumentString> eStandard = new List<InstrumentString>();
            tuning.EStandard(eStandard);

            List<InstrumentString> eFlatStandard = new List<InstrumentString>();
            tuning.EFlatStandard(eFlatStandard);

            List<InstrumentString> bassEStandard = new List<InstrumentString>();
            tuning.BassEStandard(bassEStandard);

            List<InstrumentString> currentTuning = eStandard;
            int currentNumberOfFrets = 22;

            bool refreshMenu = true;

            while (refreshMenu)
            {
                Console.Clear();
                Console.WriteLine("Which option would you like to do? Press 'Q' to exit");
                Console.WriteLine("1. Display Left-handed fretboard");
                Console.WriteLine("2. Display Right-handed fretboard");
                Console.WriteLine("3. Begin random fret quiz");
                Console.WriteLine("4. Change tuning (alternate tunings only available for guitar)");
                Console.WriteLine("5. Change instrument");
                string menuOption = Console.ReadLine().ToLower();

                switch (menuOption)
                {
                    case "1":
                        Console.Clear();
                        DisplayFretboard.LeftHanded(currentTuning, currentNumberOfFrets);
                        break;

                    case "2":
                        Console.Clear();
                        DisplayFretboard.RightHanded(currentTuning, currentNumberOfFrets);
                        break;

                    case "3":
                        Console.Clear();
                        QuestionAnswer.RepeatQuestionAnswerLoop(currentTuning, currentNumberOfFrets);
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Select your tuning:");
                        Console.WriteLine("1. E Standard (default)");
                        Console.WriteLine("2. E Flat Standard (AKA D# Standard)");
                        string tuningChoice = Console.ReadLine().ToLower();

                        switch (tuningChoice)
                        {
                            case "1":
                                currentTuning = eStandard;
                                currentNumberOfFrets = 22;
                                break;
                            case "2":
                                currentTuning = eFlatStandard;
                                currentNumberOfFrets = 22;
                                break;
                            default:
                                Console.WriteLine("Invalid selection. You will be returned to main menu.");
                                Console.ReadLine();
                                break;
                        }
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Select your instrument:");
                        Console.WriteLine("1. Guitar (default)");
                        Console.WriteLine("2. Bass guitar");
                        string instrumentChoice = Console.ReadLine().ToLower();

                        switch (instrumentChoice)
                        {
                            case "1":
                                currentTuning = eStandard;
                                currentNumberOfFrets = 22;
                                break;
                            case "2":
                                currentTuning = bassEStandard;
                                currentNumberOfFrets = 20;
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
