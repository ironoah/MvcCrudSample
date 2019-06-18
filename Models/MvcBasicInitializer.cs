using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MvcCrudSample.Models
{
    public class MvcBasicInitializer : DropCreateDatabaseAlways<MvcBasicContext>
    {
        protected override void Seed(MvcBasicContext context)
        {
            var members = new List<Member> {
        new Member {
          name = "Adam Smith",
          email = "smith@msn.com",
          birth = DateTime.Parse("1970-03-21"),
          married = false,
          memo = "tall"
        },
        new Member {
          name = "Kobe Gabriel",
          email = "Kobe@hotmail.com",
          birth = DateTime.Parse("1955-01-03"),
          married = false,
          memo = "I wish for peace on the earth"
        }
      };
            members.ForEach(m => context.Members.Add(m));
            context.SaveChanges();
        }
    }
}
