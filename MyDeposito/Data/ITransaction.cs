using MyDeposito.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDeposito.Data
{
    public interface ITransaction
    {
        IEnumerable<Transaction> GetAll();
    }
}
