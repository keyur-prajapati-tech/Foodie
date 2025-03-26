using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Foodie.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartnerAPI : ControllerBase
    {
        private readonly string _connectionString;

        public PartnerAPI(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // ✅ Check if email exists for login
        [HttpGet("CheckEmail")]
        public IActionResult CheckEmail(string email)
        {
            bool isRegistered = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM [deliverypartner].[tbl_deliveryPartners] WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                isRegistered = count > 0;
            }

            return new JsonResult(new { isRegistered });
        }

        // ✅ Check if email and password match
        [HttpGet("CheckCredentials")]
        public IActionResult CheckCredentials(string email, string password)
        {
            bool isValidUser = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM [deliverypartner].[tbl_deliveryPartners] WHERE Email = @Email AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                isValidUser = count > 0;
            }

            return new JsonResult(new { isValidUser });
        }
    }
}
