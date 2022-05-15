using Business.Abstract;
using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager: Manager<Product>, IProductService
    {
        public ProductManager(IEntityRepository<Product> repository) : base(repository)
        {
        }
        public async Task<Product> GetWithCategoryByIdAsync(int categoryId)
        {
            return await GetWithCategoryByIdAsync(categoryId);
        }
    }
}
