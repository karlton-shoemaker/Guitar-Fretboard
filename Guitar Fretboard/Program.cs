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

            DisplayFretboard displayFretboard = new DisplayFretboard();
            displayFretboard.LeftHanded(eString, highEString, bString, gString, dString, aString);
            Console.WriteLine();
            displayFretboard.RightHanded(eString, highEString, bString, gString, dString, aString);

            Console.ReadKey();
            Console.Clear();

            Random random = new Random();
            int randomString = random.Next(6);
            int randomNote = random.Next(25);

            QuestionAnswer questionAnswer = new QuestionAnswer();

            switch (randomString)
            {
                case 0:
                    questionAnswer.AskQuestion(eString, randomNote);
                    questionAnswer.AnswerDisplay(eString, randomNote);
                    break;
                case 1:
                    questionAnswer.AskQuestion(aString, randomNote);
                    questionAnswer.AnswerDisplay(aString, randomNote);
                    break;
                case 2:
                    questionAnswer.AskQuestion(dString, randomNote);
                    questionAnswer.AnswerDisplay(dString, randomNote);
                    break;
                case 3:
                    questionAnswer.AskQuestion(gString, randomNote);
                    questionAnswer.AnswerDisplay(gString, randomNote);
                    break;
                case 4:
                    questionAnswer.AskQuestion(bString, randomNote);
                    questionAnswer.AnswerDisplay(bString, randomNote);
                    break;
                case 5:
                    questionAnswer.AskQuestion(highEString, randomNote);
                    questionAnswer.AnswerDisplay(highEString, randomNote);
                    break;
            }
        }
    }
}
