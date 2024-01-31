StringShuffler sf = new StringShuffler();

var listOfStrings = new List<string>() {
    "one",
    "two",
    "three",
};

var result = sf.ShuffleStrings(listOfStrings);

foreach (string str in result)
{
    Console.WriteLine(str);

}

Console.WriteLine("Press key to exit");
Console.ReadKey();