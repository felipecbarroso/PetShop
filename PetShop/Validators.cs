using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    public static class Validators
    {

        public static bool IsWeekend(DayOfWeek day)
        {
            if (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
            {
                return true;
            }
            return false;
        }
    }
}
