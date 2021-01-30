using System;
using System.Collections.Generic;
using System.Text;

namespace Guitar_Fretboard
{
    class QuestionAnswer
    {
        public void AskQuestion(GuitarString guitarString, int randomNote)
        {
            int answerFret;
            answerFret = guitarString.Fret[randomNote];
            Console.WriteLine(guitarString.Note[0] + answerFret);
        }
        public void DisplayAnswer(GuitarString guitarString, int randomNote)
        {
            string answerNote;
            answerNote = guitarString.Note[randomNote];
            Console.ReadKey();
            Console.WriteLine(answerNote);
        }
    }
}
