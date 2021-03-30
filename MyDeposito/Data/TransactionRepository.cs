using MyDeposito.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDeposito.Data
{
    public class TransactionRepository : ITransaction
    {
        private AppDbContext _db;

        public TransactionRepository(AppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Transaction> GetAll()
        {
            return _db.Transactions.OrderBy(t => t.Created_at);
        }
    }
}
