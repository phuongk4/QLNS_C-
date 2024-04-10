using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using QLNS.Model;
using System.Data;

namespace QLNS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpTypeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public EmpTypeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = "select EmpTypeID, EmpTypeName from EmpType";
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
        public JsonResult Post(EmpType empType)
        {
            string query = @"Insert into EmpType values (N'" + empType.EmpTypeName + "')";
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
        public JsonResult Put(EmpType empType)
        {
            string query = @"Update EmpType set EmpTypeName =N'" + empType.EmpTypeName +"'" + "where EmpTypeID = " + empType.EmpTypeID;
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

        [HttpDelete("{EmpTypeID}")]
        public JsonResult Delete(int EmpTypeID)
        {
            string query = @"Delete From EmpType" + " where  EmpTypeID  = " + EmpTypeID;
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

