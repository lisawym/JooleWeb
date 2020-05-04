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

        public bool IsUserNameExist(string userName)
        {
            var returnVal = _jooleDataContext.tblUsers.FirstOrDefault(x => x.UserName == userName);
            if (returnVal != null) return true; //exists
            else return false;
        }

        public bool IsEmailExist(string userEmail)
        {
            var returnVal = _jooleDataContext.tblUsers.FirstOrDefault(x => x.UserEmail == userEmail);
            if (returnVal != null) return true; //already exists
            else return false;
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
