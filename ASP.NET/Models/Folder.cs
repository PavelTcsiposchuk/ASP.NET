using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET.Models
{
    public class Folder
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int? ParentID { get; set; }

        public Folder Parent { get; set; }

        public bool IsRoot { get; set; } = false;

        [NotMapped]
        public ICollection<Folder> Childs;

        [NotMapped]
        public string Path { get; set; }


    }
}