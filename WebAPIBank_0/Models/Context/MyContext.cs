using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIBank_0.DesignPatterns.StrategyPattern.Init;
using WebAPIBank_0.Models.Entities;

namespace WebAPIBank_0.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {
            Database.SetInitializer(new MyInit());
        }

        public DbSet<CardInformation> Cards { get; set; }
    }
}