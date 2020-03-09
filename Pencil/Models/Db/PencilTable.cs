using System;
using System.Collections.Generic;

namespace Pencil.Models.Db
{
    public partial class PencilTable
    {
        public int PencilId { get; set; }
        public int? BuyerId1 { get; set; }
        public int? BuyerId2 { get; set; }
        public int? BuyerId3 { get; set; }
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

        public virtual BuyerTable BuyerId1Navigation { get; set; }
        public virtual BuyerTable BuyerId2Navigation { get; set; }
        public virtual BuyerTable BuyerId3Navigation { get; set; }
    }
}
