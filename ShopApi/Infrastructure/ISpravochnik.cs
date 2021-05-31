using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks;

using ShopApi.Models.Spravochnik;

namespace ShopApi.Infrastructure
{
    public interface ISpravochnik
    {
        /// <summary>
        /// Получить список всех продуктов
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<AllProductsModel>> GetAllProducts();

        
    }
}
