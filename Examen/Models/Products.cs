using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen.Models
{
    public class Products
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Price { get; set; }
        public String Description { get; set; }

    }
}
