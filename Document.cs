using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamProject.Models
{
    public class Document
    {
        public int DocumentID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
         
    }

}