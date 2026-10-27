using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominLayer.Models
{
    #region Part 04
    public class Product : BaseEntity<int>
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string PictureUrl { get; set; } = null!;
        public decimal Price { get; set; }
        public ProudctBrand ProudctBrand { get; set; }
        public ProudctType ProudctType { get; set; }
        public int BrandId { get; set; }
        public int TypeId { get; set; }

    }
    #endregion
}

