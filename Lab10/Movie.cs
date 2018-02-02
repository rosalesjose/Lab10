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
        private int id;

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

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public Movie(string title, string category, int id)
        {
            Title = title;
            Category = category;
            Id = id;
        }
    }
}
