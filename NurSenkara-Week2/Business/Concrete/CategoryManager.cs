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
    public class CategoryManager : Manager<Category>, ICategoryService
    {
        public CategoryManager(IEntityRepository<Category> repository) : base(repository)
        {
        }
    }
}
