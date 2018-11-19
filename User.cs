using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamProject.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

    }
}