using System;
using OOP1;



class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        Person person2 = new Person("John");
        Person person3 = new Person("Jane", 30);

        person1.Name = "Bob";
        person1.Age = 25;
        person1.Address = "123 Main St.";
        person1.PhoneNumber = "555-1234";

        person2.Address = "456 Main St.";
        person2.SetPhoneNumber("555-5678");

        person3.SetPhoneNumber(555, "9012");

        person1.SayHello(); // Hello, my name is Bob.
        person1.SayAge(); // I am 25 years old.
        person1.SayAddress(); // My address is 123 Main St.
        Console.WriteLine(person1.FullName); // Bob (25 years old)

        person2.SayHello(); // Hello, my name is John.
        person2.SayAge(); // I am 0 years old.

        Person.SayHelloTo(person3); // Hello, Jane!

        Console.ReadKey();
    }
}
