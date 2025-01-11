using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models.Invent
{
    public class TransferIn : INetcoreMasterChild
    {
        public TransferIn()
        {
            this.createdAt = DateTime.UtcNow;
            this.transferInNumber = DateTime.UtcNow.Date.ToString("yyyyMMdd") + Guid.NewGuid().ToString().Substring(0, 5).ToUpper() + "#IN";
            this.transferInDate = DateTime.UtcNow;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Transfer In Id")]
        public int transferInId { get; set; }

        
        [Required]
        [Display(Name = "Transfer Order Id")]
        public int transferOrderId { get; set; }

        [Display(Name = "Transfer Order")]
        public TransferOrder transferOrder { get; set; }

        [StringLength(20)]
        [Required]
        [Display(Name = "Goods Receive Number")]
        public string transferInNumber { get; set; }

        [Required]
        [Display(Name = "Goods Receive Date")]
        public DateTime transferInDate { get; set; }

        [StringLength(100)]
        [Required]
        [Display(Name = "Description")]
        public string description { get; set; }


        
        [Display(Name = "From Branch Id")]
        public int branchIdFrom { get; set; }

        [Display(Name = "From Branch")]
        public Branch branchFrom { get; set; }

        
        [Display(Name = "From Warehouse Id")]
        public int warehouseIdFrom { get; set; }

        [Display(Name = "From Warehouse")]
        public Warehouse warehouseFrom { get; set; }

        [StringLength(38)]
        [Display(Name = "To Branch Id")]
        public string branchIdTo { get; set; }

        [Display(Name = "To Branch")]
        public Branch branchTo { get; set; }

        
        [Display(Name = "To Warehouse Id")]
        public int warehouseIdTo { get; set; }

        [Display(Name = "To Warehouse")]
        public Warehouse warehouseTo { get; set; }

        [Display(Name = "Transfer In Lines")]
        public List<TransferInLine> transferInLine { get; set; } = new List<TransferInLine>();
    }
}
