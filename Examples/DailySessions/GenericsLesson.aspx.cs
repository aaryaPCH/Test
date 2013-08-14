using System;

namespace DailySessions
{
    public partial class GenericsLesson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var reverser = new Reverser<char>();
            var input = new[] {'a', 'b', 'c', 'd'};
            var reversed = reverser.Reverse(input);
            myLiteralControl.Text = new string(reversed);

            var reverser2 = new Reverser<int>();
            var input2 = new[] { 1, 2, 3, 4 };
            var reversed2 = reverser2.Reverse(input2);
            myLiteralControl2.Text = String.Join(",", reversed2);
        }
    }

    class Reverser<T>
    {
        public T[] Reverse(T[] input)
        {
            if (input == null) return null;
            var output = new T[input.Length];
            for (int i = 0, j = input.Length - 1; i < input.Length; i++, j--)
            {
                output[j] = input[i];
            }

            return output;
        }
    }
}