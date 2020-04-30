using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole.Data;
using Joole.Repo.Repositories;

namespace Joole.Repo
{
    public class UsersRepo : GenericRepo<tblUser>
    {
        JooleDataContext _jooleDataContext;
        public UsersRepo (JooleDataContext context) : base(context)
        {
            _jooleDataContext = context;
        }

        public tblUser GetUser(int id)
        {
            return _jooleDataContext.tblUsers.SingleOrDefault(s => s.UserId == id);
        }

        /*
        public IEnumerable<tblUser> GetAll()
        {
            return _jooleDataContext.tblUsers.AsEnumerable();
        }
        */

        //public void Add (tblUser user)
        //{
        //    _jooleDataContext.tblUsers.Add(user);
        //}
    }
}
