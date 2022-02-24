using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIBank_0.Models.Context;
using WebAPIBank_0.Models.Entities;

namespace WebAPIBank_0.DesignPatterns.StrategyPattern.Init
{
    public class MyInit:CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            CardInformation ci = new CardInformation();
            ci.CardUserName = "Yalcın Tan";
            ci.CardNumber = "1111 1111 1111 1111";
            ci.CardExpiryYear = 2024;
            ci.CardExpiryMonth = 10;
            ci.SecurityNumber = "222";
            ci.Limit = 50000;
            ci.Balance = 50000;
            context.Cards.Add(ci);
            context.SaveChanges();
        }
    }
}