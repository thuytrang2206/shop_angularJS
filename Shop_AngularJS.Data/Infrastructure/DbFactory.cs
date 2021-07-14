using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_AngularJS.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
       private Shop_AngularJSDBContext dbContext;
        public Shop_AngularJSDBContext Init()
        {
            return dbContext ?? (dbContext = new Shop_AngularJSDBContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
