# Class 02 - Static classes, members and polymorphism 🍔
## Static Classes 🔹
Until this point, classes were something that we can create an instance and use it whenever we need it. If we need another object of that class, we can just create another instance and use it again. When our code block ends, we can't use our instances of the classes we instantiated in that code block. But there is another type of classes and members we can use that differ from this system. Those are the static classes and members. Static in C# basically means that it will be created and stored in memory at some point when the application starts running and it will stay there, accessible from everywhere, at the same place, until the application is finished. This means that the static class or members can be accessed from anywhere, any time, store stuff in them or use methods without worrying in what code block and in what scope you are currently working. Static classes also have ONLY ONE instance, meaning that you can't just create more instances of a static class. The one instance that is created automatically is the only one you can interact for the rest of the application. This means that there is also no use in the new keyword, or a variable that holds this static class. The class is already created when you start running your code, so you can immediately use it by just writing the name of the class, as if it existed already. 
#### Static class with static members
```csharp
public static class TextHelper
{
    public static int CapitalLetterUses = 0;
    public static string CapitalFirstLetter(string word)
    {
        if (word.Length == 0)
        {
            return "Empty String";
        } 
        else if (word.Length == 1)
        {
            return char.ToUpper(word[0]).ToString(); ;
        }
        else
        {
            return char.ToUpper(word[0]) + word.Substring(1);
        }
        CapitalLetterUses++;
    }
}
```
#### Using static class
```csharp
Console.WriteLine(TextHelper.CapitalFirstLetter("bob"));
```
### Static Members
Because a static class has only one instance and you can't use a variable to store it or make another instance, ALL MEMBERS of the static class MUST BE STATIC as well. But this is not the case for all static members. We can have static members in a class that is not static. This is a different scenario. Since the class is not static, we can create multiple instance of it, but the static members will not be part of any new instance. The static members can only be accessed from the class name it self, separately. With the class name, we can only access the static members and not the non-static members. 

### Where to use and not to use static classes
Static classes are very convenient when developers are writing logic that is universal and that they will need at multiple different places, fast, without jumping through the hoops of instantiation, constructors etc. Static classes can also keep data that is available throughout the application, like configuration data or just storing some values until the end of our application. This can be used to simulate a temporary database for quick development. But, as cool as the static classes sound, they carry weight with them when we run the application. Unlike the standard classes that are cleared from the memory when we are done using them, the static classes stay in memory throughout the whole application cycle and never go away. This can be an issue if we rely too much on them, so that is why they are used only when their usefulness outweighs their cost in memory. 

#### Standard class with static method
```csharp
public class Order
{
  public int Id { get; set; }
  public string Title { get; set; }
  public string Description { get; set; }
  public string Print()
  {
    // We can use the helper class anywhere we need it without an instance
    return $"{TextHelper.CapitalFirstLetter(Title)} - {Description}";
  }
  public static bool IsOrderValid(Order order)
  {
    if (order.Id <= 0 && order.Title == "") return false;
    return true;
  }
}
```
#### Using the standard class and the static method
```csharp
// We must have an instance to call Print()
Order ord = new Order();
Console.WriteLine(ord.Print());
// We can't call Print() on the Order class
Order.Print(); // Will show as an error
// We can call IsOrderValid on Order class
Console.WriteLine(Order.IsOrderValid(ord));
// We can't call IsOrderValid on the instance of the class Order
ord.IsOrderValid(ord); // Will show an error
```
