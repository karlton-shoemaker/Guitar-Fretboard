using System;

namespace Guitar_Fretboard
{
    class Program
    {
        static void Main(string[] args)
        {
            //Goals for program:
            //-Add additional tunings
            //-Rework fretboard diagrams so that fret numbers accurately correspond to correct notes
            //-Create filter for different keys
            //-Add menu
            //-Add quizzes for other instruments: bass (cut off bString and highEString), ukulele, banjo, etc.

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

            QuestionAnswer questionAnswer = new QuestionAnswer();
            questionAnswer.RepeatQuestionAnswerLoop(eString, highEString, bString, gString, dString, aString);
        }
    }
}
