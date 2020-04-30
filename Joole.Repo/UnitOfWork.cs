using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole.Data;

namespace Joole.Repo
{
    public class UnitOfWork : IDisposable 
    {
        private UsersRepo _usersRepo;
        private CategoriesRepo _categoriesRepo;
        private SubCategoriesRepo _subCategoriesRepo;
        private ProductsRepo _productsRepo;

        private JooleDataContext _jooleDataContext;

        public UnitOfWork (JooleDataContext context)
        {
            _jooleDataContext = context;
        }

        public UsersRepo GetUsersRepo
        {
            get
            {
                if (_usersRepo == null) _usersRepo = new UsersRepo(_jooleDataContext);
                return _usersRepo;
            }
        }

        public CategoriesRepo GetCategoriesRepo
        {
            get
            {
                if (_categoriesRepo == null) _categoriesRepo = new CategoriesRepo(_jooleDataContext);
                return _categoriesRepo;
            }
        }
        public SubCategoriesRepo GetSubCategoriesRepo
        {
            get
            {
                if (_subCategoriesRepo == null) _subCategoriesRepo = new SubCategoriesRepo(_jooleDataContext);
                return _subCategoriesRepo;
            }
        }

        public ProductsRepo GetProductsRepo
        {
            get
            {
                if (_productsRepo == null) _productsRepo = new ProductsRepo(_jooleDataContext);
                return _productsRepo;
            }
        }

        public void SaveChanges()
        {
            
            _jooleDataContext.SaveChanges();
        }

        public void Dispose()
        {
            _jooleDataContext.Dispose();
        }
    }
}
