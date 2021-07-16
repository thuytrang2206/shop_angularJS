using Shop_AngularJS.Data.Infrastructure;
using Shop_AngularJS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_AngularJS.Data.Reponsitories
{
    public interface IProductTagReponsitory
    {

    }
    public class ProductTagReponsitory : RepositoryBase<ProductTag>, IProductTagReponsitory
    {
        public ProductTagReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
