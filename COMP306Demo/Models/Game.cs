using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP306Demo.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
    }
}