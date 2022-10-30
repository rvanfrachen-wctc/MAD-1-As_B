public class Dog : Pet, Talkable
{
  private bool Friendly { get; set; }

  public Dog(bool friendly, string name) 
  {
    this.Name = name;
    this.Friendly = friendly;
  }

  public string Talk()
  {
    return "Bark";
  }
  public string GetName()
  {
    return Name;
  }

  public override string ToString()
  {
  return "Dog: " + "name=" + Name + " friendly=" + Friendly;
  }

}