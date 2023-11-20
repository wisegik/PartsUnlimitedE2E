using System;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class CartItem : ILineItem
    {
        // my second change.
        [Key]
        public int CartItemId { get; set; }
        // my third change

        [Required]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        // new change 1 //
        public int Count { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}