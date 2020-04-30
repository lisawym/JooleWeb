using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole.Data;
using Joole.Repo.Repositories;

namespace Joole.Repo
{
    public class SubCategoriesRepo : GenericRepo<tblSubCategory>
    {
        JooleDataContext _jooleDataContext;
        public SubCategoriesRepo(JooleDataContext context) : base (context)
        {
            _jooleDataContext = context;
        }
    }
}
