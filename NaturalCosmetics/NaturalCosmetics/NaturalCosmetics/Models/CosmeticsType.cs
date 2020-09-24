using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalCosmetics.Models
{
    public class CosmeticsType
    {
        [Key]
        public int TypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string TypeName { get; set; }
        public ICollection<Cosmetics> Cosmetics { get; set; }
        public CosmeticsType()
        {
            Cosmetics = new Collection<Cosmetics>();
        }
    }
}
