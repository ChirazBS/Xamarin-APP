using Examen.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    interface ISQLite
    {
        SQLiteConnection GetConnectionWithCreateDatabase();

        bool savePro(Products products);

        List<Products> GetProducts();

        bool UpdateProducts(Products products);
        void DeleteProducts(int Id);
    }
}
