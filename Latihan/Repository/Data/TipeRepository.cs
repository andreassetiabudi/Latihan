using Latihan.Model;
using Latihan.MyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan.Repository.Data
{
    public class TipeRepository : GeneralRepository<Tipe, Context>
    {

        public TipeRepository(Context myContext) : base(myContext)
        {

        }
    }
}

