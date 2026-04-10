
using Microsoft.EntityFrameworkCore;
using myfinande_web_dotnet_domain.Entities;

namespace myfinance_web_dotnet_infra;


    public class MyFinanceDbContext : DbContext
    {
    
        public DbSet<PlanoConta> PlanoConta {get; set;}     
        public DbSet<Transacao> Transacao {get; set;}          
    
    
        //sub escrevendo o metodo abaixo para fazer a configurançao, dizendo a class quer usa o sql serverce
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  
        {   
            OptionsBulder.UseSqlServer(@"Server=..\SQLEXPRESS;Database=myfinance;Trusted_Connection=True;");
        }
    
    }