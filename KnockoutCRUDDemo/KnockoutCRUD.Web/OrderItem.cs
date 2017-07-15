namespace KnockoutCRUDDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderItem
    {
        public int OrderItemId { get; set; }

        public int OrderId { get; set; }

        [Required]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public virtual Order Order { get; set; }
    }
}
