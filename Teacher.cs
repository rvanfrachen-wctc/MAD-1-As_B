public class Teacher : Person, Talkable
{
  private int Age { get; set; }

  public Teacher(int age, string name) :base(name)
  {
    this.Age = age;
  }
  
  public String Talk() 
  {
    return "Don't forget to do the assigned reading!";
  }

  public string GetName()
  {
    return base.Name;
  }
}
