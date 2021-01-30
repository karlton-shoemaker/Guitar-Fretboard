using System;

namespace Guitar_Fretboard
{
    class Program
    {
        static void Main(string[] args)
        {
            GuitarString eString = new GuitarString("E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#");
            GuitarString aString = new GuitarString("A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#");
            GuitarString dString = new GuitarString("D ", "D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#");
            GuitarString gString = new GuitarString("G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#");
            GuitarString bString = new GuitarString("B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#");
            GuitarString highEString = new GuitarString("e ", "f ", "f#", "g ", "g#", "a ", "a#", "b ", "c ", "c#", "d ", "d#");

            //eString.CountLeft();
            //Console.WriteLine();
            //highEString.DrawStringLeft();
            //Console.WriteLine();
            //bString.DrawStringLeft();
            //Console.WriteLine();
            //gString.DrawStringLeft();
            //Console.WriteLine();
            //dString.DrawStringLeft();
            //Console.WriteLine();
            //aString.DrawStringLeft();
            //Console.WriteLine();
            //eString.DrawStringLeft();
            //Console.WriteLine();

            DisplayFretboard displayFretboard = new DisplayFretboard();
            displayFretboard.LeftHanded(eString, highEString, bString, gString, dString, aString);
            Console.WriteLine();
            displayFretboard.RightHanded(eString, highEString, bString, gString, dString, aString);

            //Console.WriteLine();
            //eString.CountRight();
            //Console.WriteLine();
            //highEString.DrawStringRight();
            //Console.WriteLine();
            //bString.DrawStringRight();
            //Console.WriteLine();
            //gString.DrawStringRight();
            //Console.WriteLine();
            //dString.DrawStringRight();
            //Console.WriteLine();
            //aString.DrawStringRight();
            //Console.WriteLine();
            //eString.DrawStringRight();
            //Console.WriteLine();

            Console.ReadKey();
            Console.Clear();

            Random random = new Random();
            int randomString = random.Next(6);
            int randomNote = random.Next(25);

            QuestionAnswer questionAnswer = new QuestionAnswer();

            //string[] answers = new string[2];

            //questionAnswer.AskQuestion(eString, randomNote);
            //questionAnswer.AnswerDisplay(eString, randomNote);

            //string answerNote;
            //int answerFret;

            switch (randomString)
            {
                case 0:
                    questionAnswer.AskQuestion(eString, randomNote);
                    questionAnswer.AnswerDisplay(eString, randomNote);
                    //        answerNote = eString.Note[randomNote];
                    //        answerFret = eString.Fret[randomNote];
                    //        Console.WriteLine("E" + answerFret);
                    //        Console.WriteLine(answerNote);
                    break;
                case 1:
                    questionAnswer.AskQuestion(aString, randomNote);
                    questionAnswer.AnswerDisplay(aString, randomNote);
                    //        answerNote = aString.Note[randomNote];
                    //        answerFret = aString.Fret[randomNote];
                    //        Console.WriteLine("A" + answerFret);
                    //        Console.WriteLine(answerNote);
                    break;
                case 2:
                    questionAnswer.AskQuestion(dString, randomNote);
                    questionAnswer.AnswerDisplay(dString, randomNote);
                    //        answerNote = dString.Note[randomNote];
                    //        answerFret = dString.Fret[randomNote];
                    //        Console.WriteLine("D" + answerFret);
                    //        Console.WriteLine(answerNote);
                    break;
                case 3:
                    questionAnswer.AskQuestion(gString, randomNote);
                    questionAnswer.AnswerDisplay(gString, randomNote);
                    //        answerNote = gString.Note[randomNote];
                    //        answerFret = gString.Fret[randomNote];
                    //        Console.WriteLine("G" + answerFret);
                    //        Console.WriteLine(answerNote);
                    break;
                case 4:
                    questionAnswer.AskQuestion(bString, randomNote);
                    questionAnswer.AnswerDisplay(bString, randomNote);
                    //        answerNote = bString.Note[randomNote];
                    //        answerFret = bString.Fret[randomNote];
                    //        Console.WriteLine("B" + answerFret);
                    //        Console.WriteLine(answerNote);
                    break;
                case 5:
                    questionAnswer.AskQuestion(highEString, randomNote);
                    questionAnswer.AnswerDisplay(highEString, randomNote);
                    //        answerNote = highEString.Note[randomNote];
                    //        answerFret = highEString.Fret[randomNote];
                    //        Console.WriteLine("e" + answerFret);
                    //        Console.WriteLine(answerNote);
                    break;
            }
        }
    }
}
