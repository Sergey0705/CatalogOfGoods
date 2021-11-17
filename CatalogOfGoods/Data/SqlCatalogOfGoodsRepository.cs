using CatalogOfGoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogOfGoods.Data
{
    public class SqlCatalogOfGoodsRepository : ICatalogOfGoodsRepository
    {
        private readonly CatalogOfGoodsContext _context;

        public SqlCatalogOfGoodsRepository(CatalogOfGoodsContext context)
        {
            _context = context;
        }

        public void CreateNewGood(Good good)
        {
            if (good == null)
            {
                throw new ArgumentNullException(nameof(good));
            }

            _context.CatalogOfGoods.Add(good);
        }

        public void DeleteGood(Good good)
        {
            if (good == null)
            {
                throw new ArgumentNullException(nameof(good));
            }

            _context.CatalogOfGoods.Remove(good);
        }

        public IEnumerable<Good> GetCatalogOfGoods()
        {
            return _context.CatalogOfGoods.ToList();
        }

        public Good GetGoodById(int id)
        {
            return _context.CatalogOfGoods.FirstOrDefault(i => i.Id == id);
        }

        public bool SaveChanges()
        {
           return (_context.SaveChanges() >= 0);
        }

        public void UpdateGood(Good good)
        {
            //Nothing
        }
    }
}
