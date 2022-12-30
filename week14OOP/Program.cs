Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good girl");


Console.WriteLine($"My dog name is {myDog.Name}.");
Console.WriteLine($"My neighbours dog name is {neighboursDog.Name}.");

while (myDog.LevelOfHapiness != 5)
{
    myDog.bark();
}

myDog.WagTail();
Console.WriteLine($"Level of happiness: {myDog.LevelOfHapiness}");

class Dog
{
    private string _name;
    private int _levelOfHapiness;

    //constructor
   
    public Dog(string name)
    {
        _name = name;
        _levelOfHapiness = 0;
    }
  
    //Getter
    public string Name
    {
        get { return _name; }
    }

   public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }

    public void rename(string newname)
    {
        _name = newname;
        Console.WriteLine($"The new name of dog is {newname}.");
    }
   
    public void bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }
}