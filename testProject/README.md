// Hello World
Console.WriteLine("Hello, World!");

// Variables
int age = 25;
string name = "John";
float price = 19.99f;

// Constants
const double PI = 3.14159;

// Data Types
int, float, double, char, string, bool

// Type Conversion
int x = 10;
double y = x;    // Implicit conversion
int z = (int)y;  // Explicit conversion

// Operators
+ - * / % ++ --

// Control Flow
if (condition)
{
    // code
}
else if (anotherCondition)
{
    // code
}
else
{
    // code
}

switch (variable)
{
    case value1:
        // code
        break;
    case value2:
        // code
        break;
    default:
        // code
        break;
}

for (int i = 0; i < 5; i++)
{
    // code
}

while (condition)
{
    // code
}

do
{
    // code
} while (condition);

// Functions
int Add(int a, int b)
{
    return a + b;
}

// Arrays
int[] numbers = { 1, 2, 3, 4, 5 };

// Lists
List<int> myList = new List<int>();

// Classes and Objects
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

Person person1 = new Person();
person1.Name = "Alice";
person1.Age = 30;

// Inheritance
class Student : Person
{
    public int StudentID { get; set; }
}

// Interfaces
interface IDisplay
{
    void ShowInfo();
}

class Employee : IDisplay
{
    public void ShowInfo()
    {
        // code
    }
}

// Exception Handling
try
{
    // code that might throw an exception
}
catch (Exception ex)
{
    // handle the exception
}
finally
{
    // code that will always run
}

// File I/O
using System.IO;

// Read from a file
string content = File.ReadAllText("filename.txt");

// Write to a file
File.WriteAllText("filename.txt", "Hello, File!");

// LINQ
var result = from num in numbers
             where num % 2 == 0
             select num;

// Async/Await
async Task<string> DownloadDataAsync()
{
    // asynchronous code
    return await SomeAsyncMethod();
}


delegate void MyDelegate(string message);

void MyMethod(string text)
{
    Console.WriteLine(text);
}

MyDelegate myDelegate = new MyDelegate(MyMethod);
myDelegate("Hello, Delegate!");


class Publisher
{
    public event EventHandler MyEvent;

    public void RaiseEvent()
    {
        MyEvent?.Invoke(this, EventArgs.Empty);
    }
}

class Subscriber
{
    public void Subscribe(Publisher publisher)
    {
        publisher.MyEvent += HandleEvent;
    }

    void HandleEvent(object sender, EventArgs e)
    {
        Console.WriteLine("Event handled!");
    }
}


class MyGenericClass<T>
{
    public T Value { get; set; }

    public void Display()
    {
        Console.WriteLine(Value);
    }
}

MyGenericClass<int> intInstance = new MyGenericClass<int>();
intInstance.Value = 42;

MyGenericClass<string> stringInstance = new MyGenericClass<string>();
stringInstance.Value = "Hello, Generics!";


List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

var result = from num in numbers
             where num % 2 == 0
             select num;

foreach (var item in result)
{
    Console.WriteLine(item);
}


async Task<string> DownloadDataAsync()
{
    HttpClient client = new HttpClient();
    string result = await client.GetStringAsync("https://example.com");
    return result;
}


Type type = typeof(MyClass);
MethodInfo method = type.GetMethod("MyMethod");

object instance = Activator.CreateInstance(type);
method.Invoke(instance, null);


using System.Threading;

void MyThreadMethod()
{
    Console.WriteLine("Thread is running.");
}

Thread myThread = new Thread(MyThreadMethod);
myThread.Start();
myThread.Join(); // Wait for the thread to finish

using System.Text.Json;

var jsonString = JsonSerializer.Serialize(obj);
var deserializedObj = JsonSerializer.Deserialize<MyClass>(jsonString);

using System.Xml.Serialization;

var serializer = new XmlSerializer(typeof(MyClass));
using (var writer = new StreamWriter("data.xml"))
{
    serializer.Serialize(writer, obj);
}

Frameworks:
1. .NET Core/.NET 5+:
.NET Core is a cross-platform, open-source framework for building modern, cloud-based, and cross-platform applications. 
    1. It has evolved into .NET 5 and subsequent versions.

# .NET CLI commands
dotnet new console -n MyConsoleApp
dotnet restore
dotnet build
dotnet run

// Startup.cs
public void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }

    app.UseRouting();
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
}

// DbContext
public class MyDbContext : DbContext
{
    public DbSet<MyEntity> MyEntities { get; set; }
}

// Query
var result = dbContext.MyEntities.Where(e => e.Property == value).ToList();

// Xamarin.Forms
<StackLayout>
    <Label Text="Hello, Xamarin!" />
    <Button Text="Click Me" Clicked="Button_Clicked" />
</StackLayout>

<!-- XAML -->
<Window x:Class="MyApp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="My App" Height="350" Width="525">
    <Grid>
        <TextBlock Text="Hello, WPF!" />
    </Grid>
</Window>

// NUnit
[TestFixture]
public class MyTests
{
    [Test]
    public void TestMethod()
    {
        // Test code
    }
}

// Hub
public class MyHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}


Functions:
1. Anonymous Functions (Lambda Expressions):
Lambda expressions provide a concise way to create anonymous methods.

Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(3, 5)); // Output: 8

2. Extension Methods:

public static class StringExtensions
{
    public static bool IsPalindrome(this string str)
    {
        // Check if the string is a palindrome
        return str.SequenceEqual(str.Reverse());
    }
}

// Usage
string text = "level";
bool isPalindrome = text.IsPalindrome(); // true

3. Action and Func Delegates:

Action<string> printMessage = message => Console.WriteLine(message);
printMessage("Hello, Action!");

Func<int, int, int> multiply = (a, b) => a * b;
int result = multiply(4, 6); // Result: 24

Classes:

1. Abstract Classes:

public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

2. Partial Classes:

// File1.cs
partial class MyClass
{
    public void Method1() { /* implementation */ }
}

// File2.cs
partial class MyClass
{
    public void Method2() { /* implementation */ }
}

3. Static Classes:

public static class MathUtils
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

4. Nested Classes:

public class OuterClass
{
    public class InnerClass
    {
        // Inner class members
    }
}

5. Indexers:

public class MyCollection
{
    private int[] data = new int[5];

    public int this[int index]
    {
        get { return data[index]; }
        set { data[index] = value; }
    }
}

6. Operator Overloading:

public class ComplexNumber
{
    public int Real { get; set; }
    public int Imaginary { get; set; }

    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber { Real = a.Real + b.Real, Imaginary = a.Imaginary + b.Imaginary };
    }
}

