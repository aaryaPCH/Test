using System;

namespace ConsoleApplication1
{
    public abstract class Person
    {
        /// <summary>
        /// 0 = single
        /// 1 = Married filing jointly
        /// 2 = Married filing separately
        /// </summary>
        public int MaritalStatus { get; set; }
        public int Salary { get; set; }

        public virtual void PrintResume()
        {

        }

        public static Person CreatePerson(string personType, string credentials)
        {
            if (personType == "engineer")
            {
                return new Engineer(credentials);
            }

            if (personType == "manager")
            {
                return new Manager(credentials);
            }

            return null;
        }
    }

    public class Engineer : Person
    {
        public string Skillsets { get; set; }

        internal Engineer(string skillSet)
        {
            Skillsets = skillSet;
        }

        public override void PrintResume()
        {
            Console.WriteLine(Skillsets);
        }
    }

    public class Manager : Person
    {
        public string Frameworks { get; set; }

        internal Manager(string frameworks)
        {
            Frameworks = frameworks;
        }

        public override void PrintResume()
        {
            Console.WriteLine(Frameworks);
        }
    }

    public class Dean
    {
        private bool _collegeManaged;
        private static Dean _instance;

        private Dean()
        {

        }

        public static Dean TheInstance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new Dean();
                return _instance;
            }
        }

        public void RunCollege()
        {
            _collegeManaged = true;
        }

        public bool IsCollegeManaged()
        {
            return _collegeManaged;
        }
    }
}