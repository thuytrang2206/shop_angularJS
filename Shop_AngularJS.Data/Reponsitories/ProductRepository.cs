using Shop_AngularJS.Data.Infrastructure;
using Shop_AngularJS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_AngularJS.Data.Reponsitories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetByAlias(string alias);
    }
    public class ProductRepository: RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }

        public IEnumerable<Product> GetByAlias(string alias)
        {
            return this.DbContext.Products.Where(x => x.Alias == alias);
        }
    }
}
