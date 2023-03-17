using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLAccountService
    {
        List<Account> GetAllAccount();
        //string GetAllAccount();
    }
}
