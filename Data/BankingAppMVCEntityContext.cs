using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankingAppMVCEntity.Models;
using BankingAppMVCEntity.ViewModel;

namespace BankingAppMVCEntity.Data
{
    public class BankingAppMVCEntityContext : DbContext
    {
        public BankingAppMVCEntityContext (DbContextOptions<BankingAppMVCEntityContext> options)
            : base(options)
        {
        }

        public DbSet<BankingAppMVCEntity.Models.Account> Account { get; set; } = default!;
        public DbSet<BankingAppMVCEntity.ViewModel.LoginViewModel> LoginViewModel { get; set; } = default!;
    }
}
