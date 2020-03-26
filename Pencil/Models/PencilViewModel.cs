using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pencil.Models
{
    public class PencilViewModel
    {
        public int? BuyerId1 { get; set; }
        public int? BuyerId2 { get; set; }
        public int? BuyerId3 { get; set; }
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

    }
}
