Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neigboursDog = new Dog("Good Girl");


Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neigbours dogs name is {neigboursDog.Name}.");

myDog.Rename("Bad boy");

while (myDog.LevelOfHappiness !=5)
{
    myDog.Bark();
    }

myDog.WagTail();    

class Dog
{
    private string _name;
   private  int _levelOfHappiness;

    //constructor
    public Dog(string name) //name - lets the user name the dog
    {
        _name = name;
        _levelOfHappiness = 0;


    }

    //getter



    public int LevelOfHappiness
    {
        get { return _levelOfHappiness; }

    }


    public string Name
    {
       get { return _name; }
    }
   public void  Rename(string newName)
    {


        _name = newName;
        Console.WriteLine($"the dog has been renamed to: {newName}");
    }




    public void Bark()
    {

        Console.WriteLine("Woof-woof!");
        _levelOfHappiness++;
    }

   
    
        public void WagTail()
        {

            Console.WriteLine("Woigge-wiggle!");
            


        }




    }
