using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementSystem
{
    public class Person
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public Person(string name, string telephone, string email, string role)
        {
            Name = name;
            Telephone = telephone;
            Email = email;
            Role = role;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Telephone: {Telephone}, Email: {Email}, Role: {Role}");
        }
    }
}
