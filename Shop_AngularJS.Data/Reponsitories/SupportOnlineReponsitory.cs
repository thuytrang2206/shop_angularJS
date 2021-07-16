using Shop_AngularJS.Data.Infrastructure;
using Shop_AngularJS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_AngularJS.Data.Reponsitories
{
    public interface ISupportOnlineReponsitory
    {

    }
    public class SupportOnlineReponsitory : RepositoryBase<SupportOnline>, IPostTagReponsitory
    {
        public SupportOnlineReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
