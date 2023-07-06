using AkademiPlusDataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusDataAccessLayer.UnitOfWork
{
    public class UowDal:IUowDal
    {
        private readonly Context _context;

        public UowDal(Context context)
        {

        }
    }
}
