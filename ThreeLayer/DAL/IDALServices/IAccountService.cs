using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IDALServices
{
    public interface IAccountService
    {
        List<Account> GetAll();
        void Create(Account account);
    }
}
