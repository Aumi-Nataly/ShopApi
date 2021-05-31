using System;
using System.Collections.Generic;
using System.Text;
using ShopApi.Models.Spravochnik;
using ShopApi.Infrastructure;
using System.Threading.Tasks;

namespace Infrastructure.Spravochnik
{
    public class Spravochnik : ISpravochnik
    {
        public Task<IEnumerable<AllProductsModel>> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
