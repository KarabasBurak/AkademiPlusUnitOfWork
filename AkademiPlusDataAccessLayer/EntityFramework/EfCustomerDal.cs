using AkademiPlusDataAccessLayer.Abstract;
using AkademiPlusDataAccessLayer.Concrete;
using AkademiPlusDataAccessLayer.Repositories;
using AkademiPlusEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusDataAccessLayer.EntityFramework
{
    public class EfCustomerDal:GenericRepository<Customer>,ICustomerDal
    {
        public EfCustomerDal(Context context):base(context)
        {
            
        }
    }
}
