using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models.Invent
{
    public class ShipmentLine : INetcoreBasic
    {
        public ShipmentLine()
        {
            this.createdAt = DateTime.UtcNow;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Shipment Line Id")]
        public int shipmentLineId { get; set; }

        
        [Display(Name = "Shipment Id")]
        public int shipmentId { get; set; }

        [Display(Name = "Shipment")]
        public Shipment shipment { get; set; }

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

        [Display(Name = "Qty")]
        public float qty { get; set; }

        [Display(Name = "Qty Shipment")]
        public float qtyShipment { get; set; }

        [Display(Name = "Qty Inventory")]
        public float qtyInventory { get; set; }
    }
}
