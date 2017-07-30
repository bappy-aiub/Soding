using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace User
{
    public class DBSeeder : DropCreateDatabaseIfModelChanges<TaskDBContext>
    {
        protected override void Seed(TaskDBContext context)
        {
            Task t = new Task()
            {

                name = "Bappy",
                description = "Student",
                dateCreated = DateTime.Now,
                dateUpdated = DateTime.Now
            };
            context.Tasks.Add(t);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}