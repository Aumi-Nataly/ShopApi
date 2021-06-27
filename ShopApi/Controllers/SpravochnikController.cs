using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Models;
using Infrastructure.Infrastructure;
using Infrastructure.Spravochnik;

namespace ShopApi.Controllers
{
    [ApiController]
    public class SpravochnikController : Controller
    {
       // private readonly ISpravochnik _spravochnik;
        private readonly Infrastructure.Spravochnik.Spravochnik _spravochnik;

        //public SpravochnikController(ISpravochnik spravochnik)
        //{
        //    // _spravochnik = spravochnik;
        //    _spravochnik = new Infrastructure.Spravochnik.Spravochnik();
        //}

        public SpravochnikController()
        {
            // _spravochnik = spravochnik;
            _spravochnik = new Infrastructure.Spravochnik.Spravochnik();
        }

        /// <summary>
        /// https://localhost:44388/Spravochnik/AllProduct
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Spravochnik/AllProduct")]
        public async Task<IEnumerable<AllProductsModel>> AllProduct()
        {
             var prod = await _spravochnik.GetAllProducts();
             return prod;
        }
    }
}
