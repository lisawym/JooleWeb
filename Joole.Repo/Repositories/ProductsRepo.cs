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
    }
}

