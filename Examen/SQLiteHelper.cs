using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using Examen.Models;
using System.Collections;

namespace Examen
{
    public class SQLiteHelper
    {
        private readonly SQLiteAsyncConnection db;

        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Products>();
        }

        public Task<int> CreateProduct(Products pro)
        {
            return db.InsertAsync(pro);
        }
        public Task<List<Products>>ReadProduct()
        {
            return db.Table<Products>().ToListAsync();
        }
        public Task<int>UpdateProduct(Products pro)
        {
            return db.UpdateAsync(pro);
        }
        public Task<int> DeleteProduct(Products pro)
        {
            return db.DeleteAsync(pro);
        }
        public Task<List<Products>>Search(string sear)
        {
            return db.Table<Products>().Where(p => p.Name.StartsWith(sear)).ToListAsync();
        }

        internal Task<IEnumerable> Search(object newTextValue)
        {
            throw new NotImplementedException();
        }
    }
}
