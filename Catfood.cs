using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sd_knowledge_check_2
{
    internal class Product(Catfood)
    {
        public string? Flavor { get; set; }
        {
            return $"{base.ToString()}, Flavor: {Flavor}";
        }
    }
}
