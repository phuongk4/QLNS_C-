using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using QLNS.Model;

namespace QLNS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public EmployeeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = "select EmpID, Name, Birthday, Gender, Phone, Address, Qualification from Employee";
            DataTable table = new DataTable();
            //gọi sql data 
            string sqlDataSource = _configuration.GetConnectionString("QLNS");
            SqlDataReader myReader;
            using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {   
                myCon.Open();
                using(SqlCommand sqlCommand = new SqlCommand(query, myCon))
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
        public JsonResult Post(Employee employee)
        {
            string query = @"Insert into Employee values (N'"+employee.Name+ "', '"+employee.Birthday+ "', '"+employee.Gender+ "', '"+employee.Phone+ "', '"+employee.Address+ "', '"+employee.Qualification+"' )";
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
        public JsonResult Put(Employee employee)
        {
            string query = @"Update Employee set Name =N'" + employee.Name + "',Birthday =N'"+employee.Birthday+ "',Gender = '"+employee.Gender+ "',Phone = '"+employee.Phone+ "',Address = '"+employee.Address+ "', Qualification = '"+employee.Qualification+"' " + "where EmpID = " +employee.EmpID;
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

        [HttpDelete("{EmpID}")]
        public JsonResult Delete(int EmpID)
        {
            string query = @"Delete From Employee" + " where EmpID = " + EmpID;
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
