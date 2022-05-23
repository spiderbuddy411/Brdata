using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Contexto : DbContext
    { 
        public Contexto() :base("Connection")
        {
            
        }
        public DbSet<Cliente> ObjetoCliente { get; set; }
    }
}
