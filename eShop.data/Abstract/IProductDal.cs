using eShop.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.data.Abstract
{
    public interface IProductDal : IGenericRepository<Product>
    {
    }
}
