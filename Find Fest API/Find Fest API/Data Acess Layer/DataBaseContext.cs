using Find_Fest_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Fest_API.Data_Acess_Layer {
    public class DataBaseContext : DbContext{
        public DbSet<Event> Events { get; set; }
    }
}
