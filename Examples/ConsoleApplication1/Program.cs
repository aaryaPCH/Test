using System;

namespace ConsoleApplication1
{
    class Program
    {
        private static void Main(string[] args)
        {

            // Factory example
            //Person person = Person.CreatePerson("engineer", "C++, C#");
            //person.PrintResume();
            //person = Person.CreatePerson("manager", "Agile");
            //person.PrintResume();

            // Singleton example
            Console.WriteLine(Dean.TheInstance.IsCollegeManaged());
            Dean.TheInstance.RunCollege();
            Console.WriteLine(Dean.TheInstance.IsCollegeManaged());

            //Person a = new Person();
            //a.Salary = 2000;
            //Person b = a;
            //a.Salary++;

            //Console.WriteLine("A = " + a.Salary);
            //Console.WriteLine("B = " + b.Salary);



            //TaxCalculator taxCalc = new TaxCalculator();
            //Person person = new Person();
            //person.MaritalStatus = 2;
            //person.Salary = 80000;

            //taxCalc.TaxCalculationForSingles = OnTaxCalculationForSingles;
            //taxCalc.TaxCalculationForMarriedJoint = OnTaxCalculationForMarriedJoint;
            //taxCalc.TaxCalculationForMarriedSeparate = OnTaxCalculationForMarriedSeparate;

            //var result = taxCalc.CalculateTax(person);
            //Console.WriteLine("You're paying " + result + " dollars in tax");
        }

        private static int OnTaxCalculationForMarriedSeparate(int discount)
        {
            return 40 - discount;
        }

        private static int OnTaxCalculationForMarriedJoint(int discount)
        {
            return 35 - discount;
        }

        private static int OnTaxCalculationForSingles(int discount)
        {
            return 30;
        }
    }
}
