using System;
using System.Collections.Generic;
using System.Text;
using ShopApi.Models.Spravochnik;
using ShopApi.Infrastructure;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Infrastructure.Spravochnik
{
    public class Spravochnik : ISpravochnik
    {
        string connectionString = @"Data Source=DESKTOP-DVSENK7\SQLEXPRESS;Initial Catalog=Spravochnik;Integrated Security=True";


        /// <summary>
        /// Получить справочную информацию о всех товарах
        /// </summary>
        /// <returns></returns>
        public async Task<List<AllProductsModel>> GetAllProducts()
        {
            string sqlExpression = "procAllProduct";
            var productList = new List<AllProductsModel>();
            
            SqlConnection connection = new SqlConnection(connectionString);
           
            try
            {      
                    await connection.OpenAsync();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {

                        while (await reader.ReadAsync())
                        {
                            productList.Add(new AllProductsModel()
                            {
                                bookid = await reader.GetFieldValueAsync<int>(0),
                                bookname = await reader.GetFieldValueAsync<string>(1),
                                categotyname = await reader.GetFieldValueAsync<string>(2),
                                tgid = await reader.GetFieldValueAsync<int>(3)
                            });

                        }
                    }
                    reader.Close();
                
            }
            catch (Exception ex)
            {
                connection.Close();
            }

            return productList;
        }
    }
}
