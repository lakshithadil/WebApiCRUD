﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCRUD.Interfaces
{
    public interface IProduct
    {
        public long Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; } 

        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        public string Category { get; set; } 
    }
}
