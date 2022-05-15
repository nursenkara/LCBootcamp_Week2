using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table("Product", Schema = "dbo")]
    public class Product:IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 3,
        ErrorMessage = "The property {0} should have {1} maximum characters and {2} minimum characters")]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [RegularExpression(@"([0-9]+)",
        ErrorMessage = "Characters are not allowed.")]
        public string QuantityPerUnit { get; set; }
        [RegularExpression(@"([0-9]+)",
        ErrorMessage = "Characters are not allowed.")]
        public decimal UnitPrice { get; set; }
        [RegularExpression(@"([0-9]+)",
        ErrorMessage = "Characters are not allowed.")]
        public short UnitsInStock { get; set; }
    }
}
