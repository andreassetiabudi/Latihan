using Latihan.Model;
using Latihan.MyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan.Repository.Data
{
    public class AssetRepository : GeneralRepository<Asset, Context>
    {

        public AssetRepository(Context myContext) : base(myContext)
        {

        }
    }
}

