using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using QLNS.Model;
using System.Data;

namespace QLNS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public DepartmentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = "select DepID, DepName from Department";
            DataTable table = new DataTable();
            //gọi sql data 
            string sqlDataSource = _configuration.GetConnectionString("QLNS");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, myCon))
                {
                    myReader = sqlCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(table);
        }

        //[HttpGet]

        [HttpPost]
        public JsonResult Post(Department department)
        {
            string query = @"Insert into Department values (N'" + department.DepName + "' )";
            DataTable table = new DataTable();
            //gọi sql data 
            string sqlDataSource = _configuration.GetConnectionString("QLNS");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, myCon))
                {
                    myReader = sqlCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Thêm mới thành công!");
        }

        [HttpPut]
        public JsonResult Put(Department department)
        {
            string query = @"Update Department set DepName =N'" + department.DepName +"'" + "where DepID = " + department.DepID;
            DataTable table = new DataTable();
            //gọi sql data 
            string sqlDataSource = _configuration.GetConnectionString("QLNS");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, myCon))
                {
                    myReader = sqlCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("cập nhật  thành công!");
        }

        [HttpDelete("{DepID}")]
        public JsonResult Delete(int DepID)
        {
            string query = @"Delete From Department" + " where DepID = " + DepID;
            DataTable table = new DataTable();
            //gọi sql data 
            string sqlDataSource = _configuration.GetConnectionString("QLNS");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, myCon))
                {
                    myReader = sqlCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("xóa  thành công!");
        }

    }
}
