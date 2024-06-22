using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Game
    {
        public int Sale { get; set; } = 10;
        public int IdGame { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string PriceWithSale { get => $"{Price:0.00} rub./{Price*Sale:0.00}"; }
    }
}
