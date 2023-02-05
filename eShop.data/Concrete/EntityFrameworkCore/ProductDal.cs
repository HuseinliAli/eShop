using eShop.data.Abstract;
using eShop.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.data.Concrete.EntityFrameworkCore
{
    public class ProductDal : EfCoreGenericRepository<Product, EShopContext>, IProductDal
    {
    }
}
