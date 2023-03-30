using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210042130_lab10
{
    internal class Book130 : Item130 <string>
    {
        public string isbn { get; set; }
        public int numPages { get; set; }

        public Book130(string id, string title,string author, string category,  string isbn , int numPages)
        {
          this.id = id;
          this.title = title;
          this.author = author;
          this.category = category;
          this.isbn = isbn;
          this.numPages = numPages;
        }
        public override void displayDetails()
        {
        
        }
        public override void borrowItem()
        {
        
        }
        public override void returnItem()
        { 
        
        }
    }
}
