namespace NashvilleNumberPractice.Data
{
    public static class NashvilleNumberData
    {
        public static readonly int NUM_CHORDS_IN_KEY = 7;

        public static Dictionary<string, string[]> NashvilleNumbers = new Dictionary<string, string[]>() 
        {
            {"A", new string[7]{"A", "Bm", "Cm", "D", "E", "F#m", "G#"} },
            {"B", new string[7]{"B", "C#m", "D#m", "E", "F#", "G#m", "A#"} },
            {"C", new string[7]{"C", "Dm", "Em", "F", "G", "Am", "B"} },
            {"D", new string[7]{"D", "Em", "F#m", "G", "A", "Bm", "C#"} },
            {"E", new string[7]{"E", "F#m", "G#m", "A", "B", "C#m", "D#"} },
            {"F", new string[7]{"F", "Gm", "Am", "Bb", "C", "Dm", "E"} },
            {"G", new string[7]{"G", "Am", "Bm", "C", "D", "Em", "F#"} }
        };
    }
}
