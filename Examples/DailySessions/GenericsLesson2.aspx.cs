using System;

namespace DailySessions
{
    public partial class GenericsLesson2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(FindLargest(new[] { 5, 28, 1, 7, 6 }));
            Response.Write("<br />");
            Response.Write(FindLargest(new[] { "a", "b", "c" }));
            Response.Write("<br />");

            var employees = new[]
                                {
                                    new Employee {Name = "Harry", Salary = 1000},
                                    new Employee {Name = "Sally", Salary = 2000},
                                    new Employee {Name = "Jeff", Salary = 3000}
                                };
            Response.Write(FindLargest(employees));
        }

        public class Employee : IComparable
        {
            public string Name { get; set; }
            public int Salary { get; set; }

            public override string ToString()
            {
                return string.Format("{0}: {1}", Name, Salary);
            }

            #region << IComparable Members >>

            public int CompareTo(object obj)
            {
                var other = obj as Employee;
                if (other == null) return 1;
                return (Salary.CompareTo(other.Salary));
            }

            #endregion
        }

        public T FindLargest<T>(T[] array) where T : IComparable
        {
            if (array == null) return default(T);
            var largest = default(T);
            foreach (var i in array)
            {
                if (i.CompareTo(largest) > 0) largest = i;
            }

            return largest;
        }
    }
}