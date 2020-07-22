using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout01.Entities
{
    class HourContract
    {
        public DateTime date { get; set; }
        public double valuePerhour { get; set; }
        public int hours { get; set; }

        public double totalValue()
        {
            return valuePerhour * hours;
        }
    }
}
