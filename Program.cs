class Program
{
  static void Main(string[] args)
  {
    List<Talkable> zoo = new List<Talkable>();
    StreamWriter streamWriter = new StreamWriter("animals.txt", true);

    // zoo.Add(new Dog(true, "Bean"));
    // zoo.Add(new Cat(9, "Charlie"));
    // zoo.Add(new Teacher(44, "Stacy Read"));

    UserInput userInput = new UserInput(zoo);
    userInput.CreateNewAnimal();

    zoo.ForEach(thing =>
    {
      printOut(thing);
    });

    void printOut(Talkable p)
    {
      Console.WriteLine(p.GetName() + " says " + p.Talk());
      streamWriter.WriteLine(p.GetName() + " | " + p.Talk());
    }
    streamWriter.Close();

    string line = "";
    StreamReader streamReader = new StreamReader("animals.txt");
    while ((line = streamReader.ReadLine()) != null)
    {
      Console.WriteLine(line);
    }

  }
}