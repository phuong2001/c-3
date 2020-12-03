using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ages { get; set; }

        public string Mails { get; set; }
        public int Number { get; set; }
        public string ImgUrl { get; set; }
    }
}
