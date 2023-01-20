using Examen.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Data
{
    public class UserDatabase
    {
        private SQLiteAsyncConnection _database;

        public UserDatabase()
        {
        }

        public UserDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();
        }
        public async Task<bool> AddUserAsync(User user)
        {
            if (user.Id != 0)
            {
                await _database.UpdateAsync(user);
            }
            else
            {
                await _database.InsertAsync(user);
            }
            return await Task.FromResult(true);
        }

       
        public async Task<User> GetUser(string username, string password)
        {

            return await _database.Table<User>().Where(user => user.username.Equals(username) && user.password.Equals(password)).FirstOrDefaultAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _database.Table<User>().Where(user => user.Id == id).FirstOrDefaultAsync();

        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _database.Table<User>().ToListAsync();

        }

      
        
    }
}

