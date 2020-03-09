using System;
using System.Collections.Generic;

namespace Pencil.Models.Db
{
    public partial class BuyerTable
    {
        public BuyerTable()
        {
            PencilTableBuyerId1Navigation = new HashSet<PencilTable>();
            PencilTableBuyerId2Navigation = new HashSet<PencilTable>();
            PencilTableBuyerId3Navigation = new HashSet<PencilTable>();
        }

        public int BuyerId { get; set; }
        public string Buyer { get; set; }

        public virtual ICollection<PencilTable> PencilTableBuyerId1Navigation { get; set; }
        public virtual ICollection<PencilTable> PencilTableBuyerId2Navigation { get; set; }
        public virtual ICollection<PencilTable> PencilTableBuyerId3Navigation { get; set; }
    }
}
