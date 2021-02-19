using System;
using System.Collections.Generic;
using System.Text;

namespace Guitar_Fretboard
{
    class Tuning
    {
        public List<GuitarString> EStandard(List<GuitarString> strings)
        {
            strings.Add(new GuitarString("e ", "f ", "f#", "g ", "g#", "a ", "a#", "b ", "c ", "c#", "d ", "d#"));
            strings.Add(new GuitarString("B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#"));
            strings.Add(new GuitarString("G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#"));
            strings.Add(new GuitarString("D ", "D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#"));
            strings.Add(new GuitarString("A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#"));
            strings.Add(new GuitarString("E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#"));

            return strings;
        }

        public List<GuitarString> EFlatStandard(List<GuitarString> strings)
        {
            strings.Add(new GuitarString("d#", "e ", "f ", "f#", "g ", "g#", "a ", "a#", "b ", "c ", "c#", "d "));
            strings.Add(new GuitarString("A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#", "A "));
            strings.Add(new GuitarString("F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F "));
            strings.Add(new GuitarString("C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C "));
            strings.Add(new GuitarString("G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G "));
            strings.Add(new GuitarString("D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#", "D "));

            return strings;
        }

        public List<GuitarString> BassEStandard(List<GuitarString> strings)
        {
            strings.Add(new GuitarString("G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#"));
            strings.Add(new GuitarString("D ", "D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#"));
            strings.Add(new GuitarString("A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#"));
            strings.Add(new GuitarString("E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#"));

            return strings;
        }

        //GuitarString eString = new GuitarString("E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#");
        //GuitarString aString = new GuitarString("A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#");
        //GuitarString dString = new GuitarString("D ", "D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#");
        //GuitarString gString = new GuitarString("G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#");
        //GuitarString bString = new GuitarString("B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#");
        //GuitarString highEString = new GuitarString("e ", "f ", "f#", "g ", "g#", "a ", "a#", "b ", "c ", "c#", "d ", "d#");
        //public GuitarString EString { get; set; }
        //public GuitarString AString { get; set; }
        //public GuitarString DString { get; set; }
        //public GuitarString GString { get; set; }
        //public GuitarString BString { get; set; }
        //public GuitarString HighEString { get; set; }

        //public Tuning(GuitarString eString, GuitarString highEString, GuitarString bString, GuitarString gString, GuitarString dString, GuitarString aString)
        //{
        //    EString = eString;
        //    AString = aString;
        //    DString = dString;
        //    GString = gString;
        //    BString = bString;
        //    HighEString = highEString;
        //}
        //public void EFlatStandard(GuitarString eString, GuitarString highEString, GuitarString bString, GuitarString gString, GuitarString dString, GuitarString aString)
        //{
        //GuitarString eFlatString = new GuitarString("D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ");
        //GuitarString aFlatString = new GuitarString("G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G ");
        //GuitarString dFlatString = new GuitarString("C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ");
        //GuitarString gFlatString = new GuitarString("F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ");
        //GuitarString bFlatString = new GuitarString("A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#", "A ");
        //GuitarString highEFlatString = new GuitarString("d#","e ", "f ", "f#", "g ", "g#", "a ", "a#", "b ", "c ", "c#", "d ");

        //eString = eFlatString;
        //highEString = highEFlatString;
        //bString = bFlatString;
        //gString = gFlatString;
        //dString = dFlatString;
        //aString = aFlatString;

        //foreach (int fret in eString.Fret)
        //{
        //    int shiftIndex = 1;
        //    eString.Fret[fret] = eString.Fret[fret - shiftIndex];
        //}
        //}
    }
}
