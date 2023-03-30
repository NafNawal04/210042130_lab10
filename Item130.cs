using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210042130_lab10
{
    abstract class Item130 <T>
    {
        public T id { get; set; }
        public T title { get; set; }
        public T author { get; set; }
        public T category { get; set; }

        public bool isavailable { get; set; }

        public abstract void displayDetails();
        public abstract void borrowItem();
        public abstract void returnItem();
    }
}
