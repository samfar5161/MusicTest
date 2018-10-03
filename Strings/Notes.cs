using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Notes
    {
        // declare variables to hold notes of a scale or chord
        public string first;
        public string second;
        public string third;
        public string fourth;
        public string fifth;
        public string sixth;
        public string seventh;

        public int rootIndex;

        // build sorted dictionary and load 1 octave of notes starting at 'C'
        public SortedDictionary<int, string> NoteDict = new SortedDictionary<int, string>()
        {
            [0] = "C",
            [1] = "C#",
            [2] = "D",
            [3] = "D#",
            [4] = "E",
            [5] = "F",
            [6] = "F#",
            [7] = "G",
            [8] = "G#",
            [9] = "A",
            [10] = "A#",
            [11] = "B"
        };
    }
}
