namespace ConsoleApplication1
{
    class TaxCalculator
    {
        public delegate int TaxPercentageEventHandler(int discount);

        public TaxPercentageEventHandler TaxCalculationForSingles;
        public TaxPercentageEventHandler TaxCalculationForMarriedJoint;
        public TaxPercentageEventHandler TaxCalculationForMarriedSeparate;

        public int CalculateTax(Person person)
        {
            return Percent(person.Salary, GetTaxPercentForMaritalStatus(person.MaritalStatus));
        }

        private int GetTaxPercentForMaritalStatus(int maritalStatus)
        {
            int flatDiscount = 3;
            if (maritalStatus == 0) // Single
                return TaxCalculationForSingles(flatDiscount);
            else if (maritalStatus == 1) // Married + Joint
                return TaxCalculationForMarriedJoint(flatDiscount);
            else // Married + Separate
                return TaxCalculationForMarriedSeparate(flatDiscount);
        }

        private int Percent(int mainNumber, int percentage)
        {
            return (mainNumber*percentage)/100;
        }
    }
}