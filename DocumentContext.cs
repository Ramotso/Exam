using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamProject.Models
{
    public class DocumentContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }
    }
}