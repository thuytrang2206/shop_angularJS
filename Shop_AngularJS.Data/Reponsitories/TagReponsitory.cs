using Shop_AngularJS.Data.Infrastructure;
using Shop_AngularJS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_AngularJS.Data.Reponsitories
{
    public interface ITagReponsitory
    {

    }
    public class TagReponsitory : RepositoryBase<Tag>, IPostTagReponsitory
    {
        public TagReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
