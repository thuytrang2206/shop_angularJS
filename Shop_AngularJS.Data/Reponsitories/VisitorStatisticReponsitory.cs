using Shop_AngularJS.Data.Infrastructure;
using Shop_AngularJS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_AngularJS.Data.Reponsitories
{
    public interface IVisitorStatisticReponsitory
    {

    }
    public class VisitorStatisticReponsitory: RepositoryBase<VisitorStatistic>,IVisitorStatisticReponsitory
    {
        public VisitorStatisticReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
