

//  DATE

//   9/12/2025


/*
 
 Immutable , mutable , Void, Tuples Return types (INT,STRING,DECIMAL...ETC)

Objects (classes,records,structs)

 


  Mutable

object state is changable.

*/


class Person
{ public string Name  { get; set; } }

var p = new Person
{
    Name = "Alice",

};

p.Name = "Bob";








using System;

class Person { public string Name { get; set; } }

class Program
{
    static void Main()
    {
        var p = new Person { Name = "Alice" }; // create + set
        Console.WriteLine(p.Name);             // Alice

        p.Name = "Bob";                        // call setter again
        Console.WriteLine(p.Name);             // Bob

        var q = p;
        q.Name = "Carol";
        Console.WriteLine(p.Name);             // Carol (same object)
    }
}



/* 
 
immutable

object state is unchangable. 
using read only fieds, init setters or not expossing setters at all.




*/


class Person2
{
    public string Name { get; }  // no "set"
    public Person2(string name) => Name = name;
}

var p = new Person2("Alice");


// p.Name = "Bob"; Error (immutable)

Console.WriteLine(p.Name);


// Output: Alice




/* void 
 
Means method does not rreturn anything

*/

void PrintMessage(string message);
{
    Console.WriteLine("message");
}



/* Tupples as retun types,
 

A tuple is a data structure that groups multiple values into a single object, without needing to create a custom class or struct.



Normally, a method can only return one value. If you want to return multiple values, you either:

Create a class/struct to hold them, or

Use out parameters, or

Use a tuple (cleaner & simpler). 


*/



public (int, string, decimal) GetStudentInfo()
{
    int id = 1;
    string name = "Alice";
    decimal gpa = 3.8m;

    return (id, name, gpa);
}


// accesng the tupple values


var student = GetStudentInfo();

// Access  default names (Item1, Item2, Item3)

Console.WriteLine(student.Item1); // 1
Console.WriteLine(student.Item2); // Alice
Console.WriteLine(student.Item3); // 3.8












(string, int, decimal) GetUserInfo()

{
    return ("Alice", 25, 1000.50m);
}

var result = GetUserInfo();


Console.WriteLine(result.Item1); // Alice
Console.WriteLine(result.Item2); // 25
Console.WriteLine(result.Item3); // 1000.50




// you can also asign names for readability

// lets say

public (int Id, string Name, decimal GPA) GetStudentInfo()
{
    return (1, "Alice", 3.8m);
}

var student = GetStudentInfo();

// Access using names
Console.WriteLine(student.Id);   // 1
Console.WriteLine(student.Name); // Alice
Console.WriteLine(student.GPA);  // 3.8



// Instead of accessing with student.Id, you can “unpack” values directly:

var (id, name, gpa) = GetStudentInfo();
Console.WriteLine(id);   // 1
Console.WriteLine(name); // Alice
Console.WriteLine(gpa);  // 3.8



/*
When to Use Tuples as Return Types

 Great for temporary groupings of data
 When you want a lightweight alternative to a class/struct
 Useful in LINQ queries and utility/helper methods

But if the data structure is central to your domain, it’s better to use a record/class/struct for clarity and maintainability.