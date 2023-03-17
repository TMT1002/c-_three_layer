using DAL.Entities;
using DAL.IDALServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALServices
{
    public class AccountService : IAccountService
    {
        private readonly AccountContext _context;
        public AccountService(AccountContext context)
        {
            _context = context;
        }

        //public AccountService(){}

        public List<Account> GetAll()
        {
            var account = _context.Accounts.ToList();
            return account;
        }
        //public string GetAll()
        //{
        //    return "huhu";
        //}
    }
}
