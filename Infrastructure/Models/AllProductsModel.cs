using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models
{
    /// <summary>
    /// Справочная информация по товарам
    /// </summary>
    public class AllProductsModel
    {
        public int bookid { get; set; }

        public string bookname { get; set; }

        public string categotyname { get; set; }
        public int tgid { get; set; }
    }
}
