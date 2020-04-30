using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole.Data;
using Joole.Repo.Repositories;

namespace Joole.Repo
{
    //  public class CategoriesRepo : GenericRepo<CategoriesRepo>
    public class CategoriesRepo : GenericRepo<tblCategory>
    {
        JooleDataContext _jooleDataContext;
        public CategoriesRepo(JooleDataContext context) : base(context)
        {
            _jooleDataContext = context;
        }
    }
}
