using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole.Data;
using Joole.Repo.Repositories;

namespace Joole.Repo
{
    public class ProductsRepo : GenericRepo<tblProduct>
    {
        JooleDataContext _jooleDataContext;
        public ProductsRepo(JooleDataContext context) : base (context)
        {
            _jooleDataContext = context;
        }


        public IEnumerable<tblProduct> GetResult(int id)
        {
            return _jooleDataContext.tblProducts.Where(x => x.SubCategoryID == id).ToList();
        }
    }
}

