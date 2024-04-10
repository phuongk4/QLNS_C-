using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using QLNS.Model;
using System.Data;

namespace QLNS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Roll_CastController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        public Roll_CastController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = "select  EmpID, BreakDay,AddDay,Total from Roll_Cast";
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
        public JsonResult Post(Roll_Cast roll_Cast)
        {
            //roll_Cast.Total = roll_Cast.BreakDay + roll_Cast.AddDay;
            string query = @"Insert into Roll_Cast values ('"+roll_Cast.EmpID+"'  ,'" + roll_Cast.BreakDay + "', '"+roll_Cast.AddDay+"','"+roll_Cast.Total+"')";
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
        public JsonResult Put(Roll_Cast roll_Cast)
        {
            roll_Cast.Total = roll_Cast.BreakDay + roll_Cast.AddDay;
            string query = @"Update Roll_Cast set BreakDay = N'" + roll_Cast.BreakDay + "',AddDay=N'" + roll_Cast.AddDay + "',Total=N'" + roll_Cast.Total+"' " + "where  EmpID = " + roll_Cast.EmpID;
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
            string query = @"Delete From Roll_Cast" + " where  EmpID  = " + EmpID;
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
