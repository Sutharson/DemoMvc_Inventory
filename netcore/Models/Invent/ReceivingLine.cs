using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models.Invent
{
    public class ReceivingLine : INetcoreBasic
    {
        public ReceivingLine()
        {
            this.createdAt = DateTime.UtcNow;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Receiving Line Id")]
        public int receivingLineId { get; set; }

        [StringLength(38)]
        [Display(Name = "Receiving Id")]
        public int receivingId { get; set; }

        [Display(Name = "Receiving")]
        public Receiving receiving { get; set; }

        
        [Display(Name = "Branch Id")]
        public int branchId { get; set; }

        [Display(Name = "Branch")]
        public Branch branch { get; set; }

        
        [Display(Name = "Warehouse Id")]
        public int warehouseId { get; set; }

        [Display(Name = "Warehouse")]
        public Warehouse warehouse { get; set; }

        
        [Display(Name = "Product Id")]
        public int productId { get; set; }

        [Display(Name = "Product")]
        public Product product { get; set; }

        [Display(Name = "Qty Order")]
        public float qty { get; set; }

        [Display(Name = "Qty Receive")]
        public float qtyReceive { get; set; }

        [Display(Name = "Qty Inventory")]
        public float qtyInventory { get; set; }
    }
}
