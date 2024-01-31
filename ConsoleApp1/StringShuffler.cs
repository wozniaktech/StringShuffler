public class StringShuffler
{
    private Random random;

    public StringShuffler()
    {
        random = new Random();
    }

    public List<string> ShuffleStrings(List<string> inputStrings)
    {
        List<string> shuffledStrings = new List<string>(inputStrings);
        int n = shuffledStrings.Count;

        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            string value = shuffledStrings[k];
            shuffledStrings[k] = shuffledStrings[n];
            shuffledStrings[n] = value;
        }
        return shuffledStrings;
    }
}
