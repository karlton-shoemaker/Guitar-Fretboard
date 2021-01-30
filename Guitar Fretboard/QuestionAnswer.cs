using System;
using System.Collections.Generic;
using System.Text;

namespace Guitar_Fretboard
{
    class QuestionAnswer
    {
        GuitarString guitarString = new GuitarString();

        public void AskQuestion(GuitarString guitarString, int randomNote)
        {
            //Random random = new Random();
            //int randomString = random.Next(6);
            //int randomNote = random.Next(25);
            //string answerNote;
            int answerFret;

            //answerNote = guitarString.Note[randomNote];
            answerFret = guitarString.Fret[randomNote];
            Console.WriteLine($"{guitarString.Note[0]}{answerFret}");
            //Console.WriteLine(answerNote);

            //string answerFretAsString = Convert.ToString(answerFret);

            //string[] answers = new string[2];
            //answers[0] = answerNote;
            //answers[1] = answerFretAsString;

            //return answers;
        }
        public void AnswerDisplay(GuitarString guitarString, int randomNote)
        {
            //int answerFret = Convert.ToInt32(answers[1]);
            //string answerNote = answers[0];
            string answerNote;
           

            answerNote = guitarString.Note[randomNote];
            

            Console.ReadKey();
            Console.WriteLine($"{answerNote}");
        }
    }
}
