using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Person
    {
        // Поля
        private string name; // доступ только из класса
        protected int age; // доступ из класса и его наследников
        public string gender; // доступ из любого места программы
        internal string address; // доступ из любого места внутри того же проекта
        protected internal string phoneNumber; // доступ из любого места внутри того же проекта или его наследников

        // Константы
        public const string DefaultName = "Unknown";
        public readonly string Nationality = "Russian"; // поле только для чтения

        // Конструкторы
        public Person()
        {
            name = DefaultName;
            age = 0;
        }

        public Person(string name)
        {
            this.name = name;
            age = 0;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Свойства
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string FullName
        {
            get { return $"{name} ({age} years old)"; }
        }

        // Методы
        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {name}.");
        }

        public void SayAge()
        {
            Console.WriteLine($"I am {age} years old.");
        }

        public void SayAddress()
        {
            Console.WriteLine($"My address is {address}.");
        }

        public string GetPhoneNumber()
        {
            return phoneNumber;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        // перегруженный метод SetPhoneNumber
        public void SetPhoneNumber(int areaCode, string phoneNumber)
        {
            this.phoneNumber = $"{areaCode}-{phoneNumber}";
        }

        public static void SayHelloTo(Person person)
        {
            Console.WriteLine($"Hello, {person.Name}!");
        }

        // Финализатор
        ~Person()
        {
            Console.WriteLine($"Person object with name {name} has been destroyed.");
        }
    }

}
