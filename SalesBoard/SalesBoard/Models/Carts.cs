using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesBoard.Models
{
    public class Carts
    {
        public int Id { get; set; }

        [Display(Name = "Cart ID"), Required]
        public string CartId { get; set; }

        [Display(Name = "Name"), Required]
        public string ItemName { get; set; }


        [Display(Name = "Item ID"), Required]
        public int ItemId { get; set; }

        public int Quantity { get; set; }

        [Display(Name = "Price "), Required]
        public string ItemPrice { get; set; }
    }
}
