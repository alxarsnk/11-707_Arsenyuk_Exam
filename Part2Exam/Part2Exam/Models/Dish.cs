using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Part2Exam.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
    }
}
