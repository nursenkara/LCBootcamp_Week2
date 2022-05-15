using AutoMapper;
using Entities.Concrete;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Common
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductsViewModel>();
            CreateMap<ProductsViewModel, Product>();
            CreateMap<Category, CategoriesViewModel > ();
            CreateMap<CategoriesViewModel, Category>();

            CreateMap<CreateCategoryModel, Category>();
            CreateMap<Category, CreateCategoryModel>();
            CreateMap<CreateProductModel, Product>();
            CreateMap<Product, CreateProductModel>();
            CreateMap<UpdateCategoryModel, Category>();
            CreateMap<Category, UpdateCategoryModel>();
            CreateMap<UpdateProductModel, Product>();
            CreateMap<Product, UpdateProductModel>();
        }
    }
}
