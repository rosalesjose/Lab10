using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Movie
    {
        private string title;
        private string category;

        public string Title
        {
            set { title = value; } 

            get { return title; } 
        }

        public string Category
        {
            set { category = value; } 

            get { return category; } 
        }               

        public void PrintTitle()
        {
            Console.WriteLine(Title);
        }

        public void PrintCategory()
        {
            Console.WriteLine(Category);
        }
    }
}
