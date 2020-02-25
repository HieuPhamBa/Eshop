using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop.Data.EF
{
    public class EShopDBContext: DbContext
    {
        public EShopDBContext(DbContextOptions options): base(options)
        {
        }

        
    }
}
