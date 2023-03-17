using BUS.IServices;
using DAL.Entities;
using DAL.IDALServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class QLAccountService : IQLAccountService
    {
        private readonly IAccountService _accountService;
        public QLAccountService(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public List<Account> GetAllAccount()
        {
            return _accountService.GetAll();
        }
        //public string GetAllAccount()
        //{
        //    return _accountService.GetAll();
        //}

    }

}
