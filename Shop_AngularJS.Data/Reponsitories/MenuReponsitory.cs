using Shop_AngularJS.Data.Infrastructure;
using Shop_AngularJS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_AngularJS.Data.Reponsitories
{
    public interface IMenuReponsitory
    {

    }
    public class MenuReponsitory: RepositoryBase<Menu>, IMenuReponsitory
    {
        public MenuReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
