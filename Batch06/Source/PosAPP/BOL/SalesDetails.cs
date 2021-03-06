﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class SalesDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesDetailsId { get; set; }

        public int SalesId { get; set; }
        [ForeignKey("SalesId")]
        public virtual Sales Sales { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Vat")]
        public float Vat { get; set; }

        [Display(Name = "Discount")]
        public float Discount { get; set; }

        [Required(ErrorMessage = "Create/Modification Date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
                       ApplyFormatInEditMode = true)]
        [Display(Name = "Create/Modification Date")]
        public DateTime ModifiedDate { get; set; }
    }
}
