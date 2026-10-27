using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominLayer.Models
{
    #region Part 04
    public class BaseEntity<TKey>
    {
        public TKey Id { get; set; } // Primary key property
    }
    #endregion

}
