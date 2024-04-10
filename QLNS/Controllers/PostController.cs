using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using QLNS.Model;
using System.Data;

namespace QLNS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public PostController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get() 
        {
            string qurey = "select PostID, PostName from  Post";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("QLNS");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open(); 
                using(SqlCommand sqlCommand = new SqlCommand(qurey, myCon))
                {
                    myReader = sqlCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
           return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(Post post)
        {
            string qurey = @"INSERT INTO Post VALUES(N'"+post.PostName+"')";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("QLNS");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using( SqlCommand sqlCommand = new SqlCommand(qurey, myCon))
                {
                    myReader = sqlCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("thêm thành công");
        }
        [HttpPut]
        public JsonResult Put(Post post)
        {
            string qurey = @"Update Post set PostName =N'" + post.PostName + "'" + "Where PostID = " +post.PostID;
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("QLNS");
            SqlDataReader myReader;
            using ( SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using(SqlCommand sqlCommand = new SqlCommand( qurey, myCon))
                {
                    myReader = sqlCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("sửa thành công ");
        }

        [HttpDelete("{PostID}")]
        public JsonResult Delete(int PostID) 
        {
            string qurey = @"Delete From Post" + " where PostID = " + PostID;
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("QLNS");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using( SqlCommand sqlCommand = new SqlCommand(qurey, myCon))
                {
                    myReader = sqlCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("xóa thành công");
        }

    }
}
