using System;

namespace HW2_Task3
{
    class Program
    {
        enum University
        {
            HSE,
            MSU,
            MIPT,
            MEPhI,
            MTUCI
        }

        struct Employee
        {
            public string Name;
            public string Surname;
            public decimal Salary;
            public University Institue;
        }
        
        static void Main()
        {
            Employee person;
            person.Name = "Yuri";
            person.Surname = "Fedotov";
            person.Salary = 31337.77M;
            person.Institue = University.MTUCI;
            Console.WriteLine($"Hello, {person.Name} {person.Surname}!");
            Console.WriteLine($"Your salary is {person.Salary} and you are working in {person.Institue}.");
        }
    }
}