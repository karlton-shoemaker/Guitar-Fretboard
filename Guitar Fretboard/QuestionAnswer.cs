﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Guitar_Fretboard
{
    static class QuestionAnswer
    {
        public static void AskQuestion(InstrumentString guitarString, int randomNote)
        {
            Console.WriteLine("What note is this?");
            int answerFret;
            answerFret = guitarString.Fret[randomNote];
            Console.WriteLine(guitarString.Note[0] + answerFret);
        }
        public static void DisplayAnswer(InstrumentString guitarString, int randomNote)
        {
            string answerNote;
            answerNote = guitarString.Note[randomNote];
            Console.ReadKey();
            Console.WriteLine("Answer: (Press 'Q' to return to menu.)");
            Console.WriteLine(answerNote);
        }
        public static void RandomFretQuestion(List<InstrumentString> strings, int numberOfFrets)
        {
            Random random = new Random();
            int randomString = random.Next(6);
            int randomNote = random.Next(numberOfFrets);
            int numberOfStrings = strings.Count;

            switch (randomString)
            {
                case 0:
                    AskQuestion(strings[0], randomNote);
                    DisplayAnswer(strings[0], randomNote);
                    break;
                case 1:
                    AskQuestion(strings[1], randomNote);
                    DisplayAnswer(strings[1], randomNote);
                    break;
                case 2:
                    AskQuestion(strings[2], randomNote);
                    DisplayAnswer(strings[2], randomNote);
                    break;
                case 3:
                    AskQuestion(strings[3], randomNote);
                    DisplayAnswer(strings[3], randomNote);
                    break;
                case 4:
                    if (numberOfStrings <= 4)
                    {
                        break;
                    }
                    AskQuestion(strings[4], randomNote);
                    DisplayAnswer(strings[4], randomNote);
                    break;
                case 5:
                    if (numberOfStrings <= 5)
                    {
                        break;
                    }
                    AskQuestion(strings[5], randomNote);
                    DisplayAnswer(strings[5], randomNote);
                    break;
            }
        }
        public static void RepeatQuestionAnswerLoop(List<InstrumentString> strings, int numberOfFrets)
        {
            int numberForRNG = numberOfFrets + 1;
            bool repeatQuestion = true;
            while (repeatQuestion)
            {
                RandomFretQuestion(strings, numberForRNG);

                string quit = Console.ReadLine();
                quit = quit.ToLower();
                if (quit == "q")
                {
                    repeatQuestion = false;
                }
                Console.Clear();
            }
        }
        public static void RepeatQuestionAnswerLoop24Fret(List<InstrumentString> strings)
        {
            bool repeatQuestion = true;
            while (repeatQuestion)
            {
                RandomFretQuestion(strings, 25);

                string quit = Console.ReadLine();
                quit = quit.ToLower();
                if (quit == "q")
                {
                    repeatQuestion = false;
                }
                Console.Clear();
            }
        }
    }
}
