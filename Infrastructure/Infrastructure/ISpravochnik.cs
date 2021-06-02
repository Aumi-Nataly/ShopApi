using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Models;

namespace Infrastructure.Infrastructure
{
  public  interface ISpravochnik
    {
        public interface ISpravochnik
        {
            /// <summary>
            /// Получить список всех продуктов
            /// </summary>
            /// <returns></returns>
            public Task<List<AllProductsModel>> GetAllProducts();


        }
    }
}
