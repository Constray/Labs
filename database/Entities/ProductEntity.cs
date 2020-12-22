using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.EFCore.Entities
{
    [Table("Product")]
    public class ProductEntity
    {
        public int Id { get; set; }
        
        public string Code { get; set; }
        
        public string Name { get; set; }
        
        public DateTime CreationDate { get; set; }
        
        public int Quantity { get; set; }
    }
}