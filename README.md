# Back-End Web Development 1 - HTTP-5125

This repository contains projects and assignments for **C# and .NET backend development**.

---

## Links  
[Course Documentation](https://learn.humber.ca/ultra/courses/_262268_1/outline)  

---

## Image  
![Backend Project](https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/Microsoft_.NET_logo.svg/800px-Microsoft_.NET_logo.svg.png)  

---

## Note  
- ASP.NET Core is **cross-platform**, meaning apps can run on Windows, macOS, and Linux.  
- C# is **strongly typed**, so always declare variables with the correct types.

---

## Code Sample  
```csharp
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Student: {Name}, Age: {Age}");
    }
}
