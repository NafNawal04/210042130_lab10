using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210042130_lab10
{
    internal class DVD130 : Item130 <string>
    {
        public string director { get; set; }
        public int length { get; set; }

        public DVD130(string id, string title, string author, string category, string director, int length)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.category = category;
            this.director = director;
            this.length = length;
        }
        public override void displayDetails()
        { }

        public override void borrowItem() { }
        public override void returnItem() { }
    }
}
