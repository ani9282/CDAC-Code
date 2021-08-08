using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace EF_CODEFIRST_RELATION_WINDEMO
{
   public class MyDbContext:DbContext
    {
       public MyDbContext()
           : base("name=TescoDBConStr")
       {

       }

       public DbSet<Participant> Participants { get; set; }
       public DbSet<Result> Results { get; set; }
    }
}
