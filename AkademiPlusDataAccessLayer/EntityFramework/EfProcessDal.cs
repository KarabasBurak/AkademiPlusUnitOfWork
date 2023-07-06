using AkademiPlusDataAccessLayer.Abstract;
using AkademiPlusDataAccessLayer.Concrete;
using AkademiPlusDataAccessLayer.Repositories;
using AkademiPlusEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusDataAccessLayer.EntityFramework
{
    public class EfProcessDal:GenericRepository<Process>,IProcessDal
    {
        public EfProcessDal(Context context):base(context)
        {
            context.
        }
    }
}
