using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Form.Connect;

namespace WebIntroduce_BTL.Controller
{
    public class AccountController : ApiController
    {

        public Boolean Login(String _id, String _pass)
        {
            // return "value";
            try
            {
                MySqlConnection conn = Connected.GetDBConnection();
                String sql = "SELECT * FROM webintroduce.account where User = '"+ _id+ "' and Password = '" + _pass + "' " +
                    "or Email = '" + _id + "' and Password = '" + _pass + "'";
                MySqlDataAdapter Adapter = new MySqlDataAdapter(sql, conn);
                DataTable m_table = new DataTable();
                Adapter.Fill(m_table);
                if (m_table.Rows.Count > 0)
                {
                    /*return JsonConvert.SerializeObject(m_table);*/
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                
                //return "Error" + ex.ToString();
                return false;
            }
            
        }


        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}