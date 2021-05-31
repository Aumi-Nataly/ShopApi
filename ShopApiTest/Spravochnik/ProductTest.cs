using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infrastructure.Spravochnik;
using ShopApi.Models.Spravochnik;
using System.Threading.Tasks;

namespace ShopApiTest.Spravochnik
{
    [TestClass]
  public  class ProductTest
    {
        [TestMethod]
        public async Task TestGetAllProduct()
        {
            Infrastructure.Spravochnik.Spravochnik sprav = new Infrastructure.Spravochnik.Spravochnik();
            var productList = new System.Collections.Generic.List<AllProductsModel>();

            productList =await sprav.GetAllProducts();

            Assert.IsNotNull(productList);
        }
    }
}
