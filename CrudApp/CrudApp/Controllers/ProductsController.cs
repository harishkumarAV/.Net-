using System.Data.SqlClient;
using CrudApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CrudApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly string connectionString;

        public ProductsController(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductDto productDto)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO products " +
                                 "(name, brand, category, price, description) VALUES " +
                                 "(@name, @brand, @category, @price, @description)";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", productDto.Name);
                        command.Parameters.AddWithValue("@brand", productDto.Brand);
                        command.Parameters.AddWithValue("@category", productDto.Category);
                        command.Parameters.AddWithValue("@price", productDto.Price);
                        command.Parameters.AddWithValue("@description", productDto.Description);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Product", "Sorry, but we have an exception.");
                return BadRequest(ModelState);
            }
            return Ok();
        }
    }
}
