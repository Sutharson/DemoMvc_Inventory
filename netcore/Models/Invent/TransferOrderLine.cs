using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models.Invent
{
    public class TransferOrderLine : INetcoreBasic
    {
        public TransferOrderLine()
        {
            this.createdAt = DateTime.UtcNow;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Transfer Order Line Id")]
        public int transferOrderLineId { get; set; }

        
        [Display(Name = "Transfer Order Id")]
        public int transferOrderId { get; set; }

        [Display(Name = "Transfer Order")]
        public TransferOrder transferOrder { get; set; }

        
        [Display(Name = "Product Id")]
        public int productId { get; set; }

        [Display(Name = "Product")]
        public Product product { get; set; }

        [Display(Name = "Qty")]
        public float qty { get; set; }
    }
}
