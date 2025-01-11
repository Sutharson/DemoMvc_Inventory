using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models.Invent
{
    public class TransferOutLine : INetcoreBasic
    {
        public TransferOutLine()
        {
            this.createdAt = DateTime.UtcNow;
        }

        
        [Display(Name = "Transfer Out Line Id")]
        public int transferOutLineId { get; set; }

       
        [Display(Name = "Goods Issue Id")]
        public int transferOutId { get; set; }

        [Display(Name = "Goods Issue")]
        public TransferOut transferOut { get; set; }

        
        [Display(Name = "Product Id")]
        public int productId { get; set; }

        [Display(Name = "Product")]
        public Product product { get; set; }

        [Display(Name = "Qty")]
        public float qty { get; set; }

        [Display(Name = "Qty Inventory")]
        public float qtyInventory { get; set; }
    }
}
