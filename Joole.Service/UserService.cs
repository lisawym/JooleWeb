using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole.Repo;
using Joole.Data;

namespace Joole.Service
{
    public class UserService
    {
        public void AddUser(tblUser newUser)
        {
            UnitOfWork uow = new UnitOfWork(new JooleDataContext());
            uow.GetUsersRepo.Add(newUser);
            uow.SaveChanges();
            uow.Dispose();
        }


        public tblUser GetUserProfile(int id)
        {
            UnitOfWork uow = new UnitOfWork(new JooleDataContext());
            tblUser user =  uow.GetUsersRepo.GetUser(id);
       
            return user;

        }

        
        public IEnumerable<tblUser> GetUsers()
        {

            UnitOfWork uow = new UnitOfWork(new JooleDataContext());
            IEnumerable<tblUser> users = uow.GetUsersRepo.GetAll();
            return users;
        }

        public IEnumerable<tblCategory> GetCategories()
        {

            UnitOfWork uow = new UnitOfWork(new JooleDataContext());
            IEnumerable<tblCategory> categories = uow.GetCategoriesRepo.GetAll();
            return categories;
        }

        public IEnumerable<tblSubCategory> GetSubCategories()
        {

            UnitOfWork uow = new UnitOfWork(new JooleDataContext());
            IEnumerable<tblSubCategory> subcategories = uow.GetSubCategoriesRepo.GetAll();
            return subcategories;
        }
        public IEnumerable<tblProduct> GetProducts()
        {

            UnitOfWork uow = new UnitOfWork(new JooleDataContext());
            IEnumerable<tblProduct> products = uow.GetProductsRepo.GetAll();
            return products;
        }

    }
}
