using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTest
{
    class Notes
    {
        // variables to hold notes of a scale or chord
        public string first;
        public string second;
        public string third;
        public string fourth;
        public string fifth;
        public string sixth;
        public string seventh;

        public int rootIndex;

        // build sorted dictionary with notes starting at "C"
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

        // build major scale from root. 
        public string[] BuildMajorScale(string r)
        {
            // array to hold notes of scale
            string[] major = new string[7];
        
            // assign users input to the "first" or root note.
            first = r;
                
            // get the index of the root
            for (int i = 0; i < NoteDict.Count; i++)
            {
                if (NoteDict[i] == r)
                    rootIndex = i;
            }

            // build major scale based off of index. 
            second = NoteDict[(rootIndex + 2) % NoteDict.Count];
            third = NoteDict[(rootIndex + 4) % NoteDict.Count];
            fourth = NoteDict[(rootIndex + 5) % NoteDict.Count];
            fifth = NoteDict[(rootIndex + 7) % NoteDict.Count];
            sixth = NoteDict[(rootIndex + 9) % NoteDict.Count];
            seventh = NoteDict[(rootIndex + 11) % NoteDict.Count];

            //// print the major scale
            //Console.WriteLine("Root = {0}\n" +
            //    "Major Scale:\n" +
            //    "{1}, {2}, {3}, {4}, {5}, {6}, {7}", 
            //    first, first, second, third, fourth, fifth, sixth, seventh);

            major[0] = first;
            major[1] = second;
            major[2] = third;
            major[3] = fourth;
            major[4] = fifth;
            major[5] = sixth;
            major[6] = seventh;

            return major;            
        }

        // build minor scale from root. 
        public string[] BuildMinorScale(string r)
        {
            // array to hold notes of scale
            string[] minor = new string[7];

            // assign users input to the "first" or root note.
            first = r;

            // get the index of the root
            for (int i = 0; i < NoteDict.Count; i++)
            {
                if (NoteDict[i] == r)
                    rootIndex = i;
            }

            // build major scale based off of index. 
            second = NoteDict[(rootIndex + 2) % NoteDict.Count];
            third = NoteDict[(rootIndex + 3) % NoteDict.Count];
            fourth = NoteDict[(rootIndex + 5) % NoteDict.Count];
            fifth = NoteDict[(rootIndex + 7) % NoteDict.Count];
            sixth = NoteDict[(rootIndex + 8) % NoteDict.Count];
            seventh = NoteDict[(rootIndex + 10) % NoteDict.Count];

            //// print the major scale
            //Console.WriteLine("Root = {0}\n" +
            //    "Major Scale:\n" +
            //    "{1}, {2}, {3}, {4}, {5}, {6}, {7}", 
            //    first, first, second, third, fourth, fifth, sixth, seventh);

            minor[0] = first;
            minor[1] = second;
            minor[2] = third;
            minor[3] = fourth;
            minor[4] = fifth;
            minor[5] = sixth;
            minor[6] = seventh;

            return minor;
        }
    }
}
