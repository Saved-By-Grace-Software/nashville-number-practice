namespace NashvilleNumberPractice.Data
{
    public static class NashvilleNumberData
    {
        public static Dictionary<string, string[]> NashvilleNumbers = new Dictionary<string, string[]>() 
        {
            {"A", new string[6]{"A", "Bm", "Cm", "D", "E", "F#m"} },
            {"B", new string[6]{"B", "C#m", "D#m", "E", "F#", "G#m"} },
            {"C", new string[6]{"C", "Dm", "Em", "F", "G", "Am"} },
            {"D", new string[6]{"D", "Em", "F#m", "G", "A", "Bm"} },
            {"E", new string[6]{"E", "F#m", "G#m", "A", "B", "C#m"} },
            {"F", new string[6]{"F", "Gm", "Am", "Bb", "C", "Dm"} },
            {"G", new string[6]{"G", "Am", "Bm", "C", "D", "Em"} }
        };
    }
}
