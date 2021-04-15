# C# LINQ-Practice
A practice project for learning LINQ in C#

## How to use this project?
This project was created to be as easy to use as possible. Everything is already setup. Just clone the Master branch to your PC and open it in Visual Studio. In the ``Program.cs`` file you will see the code below.

```
class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Welcome to LINQ practice!");

        var itemMasters = await new List<ItemMaster>().LoadFromFile();
    }
}
```

When you run the program the ``itemMasters`` list will popuplate with items from a zip file included with this repository. You can use that to practice all of the LINQ extensions.



## Exampe:

In this example code we are using the LINQ extension ``FirstOrDefault`` to find the first item whose name is ``HP Potion I``. We're then outputting the item's name to console to show whether or not it successfully found it.
```
class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Welcome to LINQ practice!");

        var itemMasters = await new List<ItemMaster>().LoadFromFile();
        
        // new code here
        var hpPotion = itemMasters.FirstOrDefault(item => item.Name == "HP Potion I");
        Console.WriteLine(hpPotion.Name);
    }
}
```
