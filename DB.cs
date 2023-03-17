using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Data.Entity;


namespace WebAPI
{
    public class db : DbContext
    {
        public db():base("<cencored>"){}
        public DbSet<Block> Blocks { set; get; }
    }
}