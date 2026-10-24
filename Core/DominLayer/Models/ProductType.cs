using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominLayer.Models
{
    #region Part 04
    public class ProudctType : BaseEntity<int>
    {
        public string Name { get; set; } = null!;
    }
    #endregion
}
