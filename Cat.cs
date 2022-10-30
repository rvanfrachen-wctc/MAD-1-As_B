public class Cat : Pet, Talkable
{
  private int MiceKilled { get; set; }

  public Cat(int miceKilled, string name) 
  {
    this.Name = name;
    this.MiceKilled = miceKilled;
  }

  public void AddMouse()
  {
    MiceKilled++;
  }

  public string Talk()
  {
    return "Meow";
  }
  public string GetName()
  {
    return Name;
  }

  public override string ToString()
  {
    return "Cat: " + "name=" + Name + " miceKilled=" + MiceKilled;
  }
}