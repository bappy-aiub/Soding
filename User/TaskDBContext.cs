using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace User
{
    public class TaskDBContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }
}