using System;
using System.Collections.Generic;
using System.Text;

namespace Guitar_Fretboard
{
    class Tuning
    {
        public List<InstrumentString> EStandard(List<InstrumentString> strings)
        {
            strings.Add(new InstrumentString("e ", "f ", "f#", "g ", "g#", "a ", "a#", "b ", "c ", "c#", "d ", "d#"));
            strings.Add(new InstrumentString("B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#"));
            strings.Add(new InstrumentString("G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#"));
            strings.Add(new InstrumentString("D ", "D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#"));
            strings.Add(new InstrumentString("A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#"));
            strings.Add(new InstrumentString("E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#"));

            return strings;
        }

        public List<InstrumentString> EFlatStandard(List<InstrumentString> strings)
        {
            strings.Add(new InstrumentString("d#", "e ", "f ", "f#", "g ", "g#", "a ", "a#", "b ", "c ", "c#", "d "));
            strings.Add(new InstrumentString("A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#", "A "));
            strings.Add(new InstrumentString("F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F "));
            strings.Add(new InstrumentString("C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C "));
            strings.Add(new InstrumentString("G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G "));
            strings.Add(new InstrumentString("D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#", "D "));

            return strings;
        }

        public List<InstrumentString> BassEStandard(List<InstrumentString> strings)
        {
            strings.Add(new InstrumentString("G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#"));
            strings.Add(new InstrumentString("D ", "D#", "E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#"));
            strings.Add(new InstrumentString("A ", "A#", "B ", "C ", "C#", "D ", "D#", "E ", "F ", "F#", "G ", "G#"));
            strings.Add(new InstrumentString("E ", "F ", "F#", "G ", "G#", "A ", "A#", "B ", "C ", "C#", "D ", "D#"));

            return strings;
        }
    }
}
