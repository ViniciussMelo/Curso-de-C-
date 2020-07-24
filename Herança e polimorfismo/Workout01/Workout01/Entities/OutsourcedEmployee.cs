using System;
using System.Globalization;

namespace Workout01.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + ((AdditionalCharge * 110) / 100);
        }

        public override string ToString()
        {
            return Name
                + " - $ "
                + Payment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
