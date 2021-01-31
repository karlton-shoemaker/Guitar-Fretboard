using System;
using System.Collections.Generic;
using System.Text;

namespace Guitar_Fretboard
{
    class QuestionAnswer
    {
        public void AskQuestion(GuitarString guitarString, int randomNote)
        {
            Console.WriteLine("What note is this?");
            int answerFret;
            answerFret = guitarString.Fret[randomNote];
            Console.WriteLine(guitarString.Note[0] + answerFret);
        }
        public void DisplayAnswer(GuitarString guitarString, int randomNote)
        {
            string answerNote;
            answerNote = guitarString.Note[randomNote];
            Console.ReadKey();
            Console.WriteLine("Answer: (Press 'Q' to exit.)");
            Console.WriteLine(answerNote);
        }
        public void RandomFretQuestion(GuitarString eString, GuitarString highEString, GuitarString bString, GuitarString gString, GuitarString dString, GuitarString aString)
        {
            Random random = new Random();
            int randomString = random.Next(6);
            int randomNote = random.Next(23);
            QuestionAnswer questionAnswer = new QuestionAnswer();

            switch (randomString)
            {
                case 0:
                    questionAnswer.AskQuestion(eString, randomNote);
                    questionAnswer.DisplayAnswer(eString, randomNote);
                    break;
                case 1:
                    questionAnswer.AskQuestion(aString, randomNote);
                    questionAnswer.DisplayAnswer(aString, randomNote);
                    break;
                case 2:
                    questionAnswer.AskQuestion(dString, randomNote);
                    questionAnswer.DisplayAnswer(dString, randomNote);
                    break;
                case 3:
                    questionAnswer.AskQuestion(gString, randomNote);
                    questionAnswer.DisplayAnswer(gString, randomNote);
                    break;
                case 4:
                    questionAnswer.AskQuestion(bString, randomNote);
                    questionAnswer.DisplayAnswer(bString, randomNote);
                    break;
                case 5:
                    questionAnswer.AskQuestion(highEString, randomNote);
                    questionAnswer.DisplayAnswer(highEString, randomNote);
                    break;
            }
        }
        public void RandomFretQuestion24Fret(GuitarString eString, GuitarString highEString, GuitarString bString, GuitarString gString, GuitarString dString, GuitarString aString)
        {
            Random random = new Random();
            int randomString = random.Next(6);
            int randomNote = random.Next(25);
            QuestionAnswer questionAnswer = new QuestionAnswer();

            switch (randomString)
            {
                case 0:
                    questionAnswer.AskQuestion(eString, randomNote);
                    questionAnswer.DisplayAnswer(eString, randomNote);
                    break;
                case 1:
                    questionAnswer.AskQuestion(aString, randomNote);
                    questionAnswer.DisplayAnswer(aString, randomNote);
                    break;
                case 2:
                    questionAnswer.AskQuestion(dString, randomNote);
                    questionAnswer.DisplayAnswer(dString, randomNote);
                    break;
                case 3:
                    questionAnswer.AskQuestion(gString, randomNote);
                    questionAnswer.DisplayAnswer(gString, randomNote);
                    break;
                case 4:
                    questionAnswer.AskQuestion(bString, randomNote);
                    questionAnswer.DisplayAnswer(bString, randomNote);
                    break;
                case 5:
                    questionAnswer.AskQuestion(highEString, randomNote);
                    questionAnswer.DisplayAnswer(highEString, randomNote);
                    break;
            }
        }
        public void RepeatQuestionAnswerLoop(GuitarString eString, GuitarString highEString, GuitarString bString, GuitarString gString, GuitarString dString, GuitarString aString)
        {
            bool repeatQuestion = true;
            while (repeatQuestion)
            {
                QuestionAnswer questionAnswer = new QuestionAnswer();
                questionAnswer.RandomFretQuestion(eString, highEString, bString, gString, dString, aString);

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
