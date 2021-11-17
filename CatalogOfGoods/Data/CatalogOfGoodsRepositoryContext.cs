using CatalogOfGoods.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogOfGoods.Data
{
    public class CatalogOfGoodsContext : DbContext
    {
        public CatalogOfGoodsContext(DbContextOptions<CatalogOfGoodsContext> options) : base(options)
        {

        }

        public DbSet<Good> CatalogOfGoods { get; set; }
    }
}
