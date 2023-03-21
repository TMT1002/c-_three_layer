using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDataContext : DbContext
    {
        public AccountDataContext(DbContextOptions<AccountDataContext> options) : base(options) { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Device> Devices { get; set; }
    }
}
