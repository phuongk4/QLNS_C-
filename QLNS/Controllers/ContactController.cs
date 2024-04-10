using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using QLNS.Model;
using System.Data;

namespace QLNS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public ContactController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            //truy vấn cơ sở dữ liệu
            string query = "select ContactID, EmpId, JoinedDate, PeriodOfContact, PostID, EmpTypeID, DepID, Sal from Contact";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("QLNS");
            SqlDataReader myReader;
            using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using(SqlCommand myCommand = new SqlCommand(query, myCon)) 
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult(table);
        }


        [HttpPost]
        public JsonResult Post(Contact contact)
        {
            string query = @"INSERT INTO Contact values ( N'" + contact.EmpId + "',N'" + contact.JoinedDate + "', N'" + contact.PeriodOfContact + "',N'" + contact.PostID + "', N'"+contact.EmpTypeID+"', N'"+contact.DepID +"', N'" + contact.Sal + "')";
            DataTable table = new DataTable();
            string sqlDataSoure = _configuration.GetConnectionString("QLNS");
            SqlDataReader myReader;
            using(SqlConnection myCon = new SqlConnection( sqlDataSoure))
            {
                myCon.Open();
                using(SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Thêm thành công ");
        }

        [HttpPut]
        public JsonResult Put(Contact contact)
        {
            string query = @"Update Contact set EmpId=N'" + contact.EmpId + "', JoinedDate=N'" + contact.JoinedDate + "', PeriodOfContact=N'" + contact.PeriodOfContact + "', PostID=N'" + contact.PostID + "', EmpTypeID=N'" + contact.EmpTypeID + "', DepID=N'" + contact.DepID + "', Sal=N'" + contact.Sal + "' where ContactID = " + contact.ContactID;
            DataTable table = new DataTable();
            string sqlDataSoure = _configuration.GetConnectionString("QLNS");
            SqlDataReader myReader;
            using(SqlConnection myCon = new SqlConnection( sqlDataSoure))
            {
                myCon.Open() ;
                using(SqlCommand myCommand = new SqlCommand( query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Cập nhật thành công");   
        }

        [HttpDelete("{ContactID}")]
        public JsonResult Delete(int ContactID) 
        {
            string query = @"Delete From Contact" + " where ContactID = " + ContactID;
            DataTable table = new DataTable();
            string sqlDataSoure = _configuration.GetConnectionString("QLNS");
            SqlDataReader myReader;
            using(SqlConnection myCon = new SqlConnection(sqlDataSoure))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Xóa thành công");
        }
    }
}
