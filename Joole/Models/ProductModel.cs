using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Joole.Data;

namespace Joole.Models
{
    public class ProductModel
    {
        public IEnumerable<tblProduct> products { get; set; }
    }


}