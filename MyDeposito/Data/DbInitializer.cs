using MyDeposito.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDeposito.Data
{
    public static class DbInitializer
    {
        public static void Initializer(AppDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Transactions.Any())
            {
                return;
            }

            var Transactions = new Transaction[]
            {
                new Transaction{Jumlah=50, Created_at=DateTime.Parse("2021-03-04")},
                new Transaction{Jumlah=120, Created_at=DateTime.Parse("2021-03-05")},
                new Transaction{Jumlah=420, Created_at=DateTime.Parse("2021-03-09")},
            };

            foreach(var t in Transactions)
            {
                context.Transactions.Add(t);
            }

            context.SaveChanges();
        }
    }
}
