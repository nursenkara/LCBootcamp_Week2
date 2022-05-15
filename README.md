# LCBootcamp_Week2
# LCBootCamp 2. Hafta Ödevim

Bir internet sitesindeki ürün ve kategoriyi örnek alarak bir web api oluşturdum.

## Paketler 
    dotnet add package Microsoft.EntityFrameworkCore -v 5.0.10
    dotnet add package AutoMapper -v 11.0.0
    dotnet add package FluentValidation -v 10.0.4
    dotnet add package FluentValidation.DependencyInjectionExtensions -v 9.5.4
    dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.10
    dotnet add package Microsoft.EntityFrameworkCore.Tools -v 5.0.10
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 5.0.10
    
    
    
# Endpoints
|HTTP|URL|METOT|
|---|---|---|
|GET| https://localhost:44339/api/Categories |GetCategories|
|GET| https://localhost:44339/api/Categories/{id} |GetById|
|PUT| https://localhost:44339/api/Categories?id={id} |UpdateCategory|
|POST| https://localhost:44339/api/Categories |AddCategory|
|DELETE| https://localhost:44339/api/Categories?id={id} |DeleteCategory|

    
# Endpoints
|HTTP|URL|METOT|
|---|---|---|
|GET| https://localhost:44339/api/Products |GetProducts|
|GET| https://localhost:44339/api/Products/{id} |GetById|
|PUT| https://localhost:44339/api/Products?id={id} |UpdateProduct|
|POST| https://localhost:44339/api/Products |AddProduct|
|DELETE| https://localhost:44339/api/Products?id={id} |DeleteProduct|



# API 

## GetCategories
![GetCategoriesPicture](/images/category_getall.png)

## GetById
![GetByIdPicture](/images/category_getbyid.png)

## UpdateCategory
![UpdateCategory](/images/category_update.png)
 
## AddCategory
![AddCategory](/images/category_add.png)

## DeleteCategory
![DeleteCategory](/images/category_delete.png)

## GetProducts
![GetProductsPicture](/images/product_getall.png)

## GetById
![GetByIdPicture](/images/product_getbyid.png)

## UpdateProduct
![UpdateProduct](/images/product_update.png)
 
## AddProduct
![AddProduct](/images/product_add.png)

## DeleteProduct
![DeleteProduct](/images/product_delete.png)


## Entities
## Product
![entity1](images/product.png)
## Category
![entity2](images/category.png)
