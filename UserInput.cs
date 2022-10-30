public class UserInput
{
  public List<Talkable> Zoo { get; set; }

  public UserInput(List<Talkable> zoo)
  {
    this.Zoo = zoo;
  }

  public void CreateNewAnimal()
  {
    Console.WriteLine("What kind of animal do you want to make? Select a number: \n 1. cat \n 2. dog \n 3. teacher");
    var input = Console.ReadLine();
    Console.WriteLine("What is the name of the animal?");
    var name = Console.ReadLine();
    if(String.IsNullOrWhiteSpace(name))
    {
      Console.WriteLine("You must enter a valid input");
    }

    switch(input)
    {
      case "1":
        Console.WriteLine("How many mice has the cat killed?");
        var miceKilled = int.Parse(Console.ReadLine());
        if(name != null)
        {
          this.Zoo.Add(new Cat(miceKilled, name));
        }
      break;
      case "2":
        Console.WriteLine("Is the dog friendly? Enter Y/N");
        var friendly = Console.ReadLine();
        if(name != null && friendly != null && friendly.ToUpper() == "Y")
        {
          this.Zoo.Add(new Dog(true, name));
        }
        else if(name != null && friendly != null && friendly.ToUpper() == "N")
        {
          this.Zoo.Add(new Dog(false, name));
        }
        else
        {
          Console.WriteLine("You must enter a valid input");
        }
      break;
      case "3":
        Console.WriteLine("What is the teacher's age?");
        var age = int.Parse(Console.ReadLine());
        if(age >= 0 && name != null)
        {
          this.Zoo.Add(new Teacher(age, name));
        }
        else
        {
          Console.WriteLine("Age needs to be above 0");
        }
      break;
      default:
        Console.WriteLine("Please enter a valid input");
        break;
    }


  }
}