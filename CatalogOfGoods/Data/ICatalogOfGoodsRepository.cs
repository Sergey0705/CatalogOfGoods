using CatalogOfGoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogOfGoods.Data
{
    public interface ICatalogOfGoodsRepository
    {
        bool SaveChanges();
        IEnumerable<Good> GetCatalogOfGoods();
        Good GetGoodById(int id);
        void CreateNewGood(Good good);
        void UpdateGood(Good good);
        void DeleteGood(Good good);
    }
}
