using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models.Invent
{
    public class TransferInLine : INetcoreBasic
    {
        public TransferInLine()
        {
            this.createdAt = DateTime.UtcNow;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Transfer In Line Id")]
        public int transferInLineId { get; set; }

        
        [Display(Name = "Goods Receive Id")]
        public int transferInId { get; set; }

        [Display(Name = "Goods Receive")]
        public TransferIn transferIn { get; set; }

        
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
