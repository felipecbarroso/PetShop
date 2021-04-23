using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    public class Service
    {
        public Service(DateTime date, int littleDogs, int bigDogs)
        {
            Date = date;
            LittleDogs = littleDogs;
            BigDogs = bigDogs;
        }
        public DateTime Date { get; set; }
        public int LittleDogs { get; set; }
        public int BigDogs { get; set; }
        public double Total { get; set; }
    }
}
