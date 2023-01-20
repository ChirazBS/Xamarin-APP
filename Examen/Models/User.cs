using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Examen.Models
{
    public class User
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public String username{ get; set; }
        public String email { get; set; }
        public String password { get; set; }

    }
}
