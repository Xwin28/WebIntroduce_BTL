
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

        [HttpGet]
        public string GetLogin( String id)
        {
            // return "value";
            try
            {
                MySqlConnection conn = Connected.GetDBConnection();
                String sql = "SELECT * FROM webintroduce.account WHERE BINARY User =  BINARY '" + id + "' or BINARY Email = BINARY'" + id+"';";
                MySqlDataAdapter Adapter = new MySqlDataAdapter(sql, conn);
                DataTable m_table = new DataTable();
                Adapter.Fill(m_table);
                if (m_table.Rows.Count > 0)
                {
                    return JsonConvert.SerializeObject(m_table);
                }
                else
                {
                    return "Error";
                }
            }
            catch (Exception ex)
            {
                return "Error" + ex.ToString();
            }

        }

        [HttpGet]
        public string GetLogin()
        {
            // return "value";
            try
            {
                MySqlConnection conn = Connected.GetDBConnection();
                String sql = "SELECT * FROM webintroduce.account";
                MySqlDataAdapter Adapter = new MySqlDataAdapter(sql, conn);
                DataTable m_table = new DataTable();
                Adapter.Fill(m_table);
                if (m_table.Rows.Count > 0)
                {
                    return JsonConvert.SerializeObject(m_table);
                }
                else
                {
                    return "Error";
                }
            }
            catch (Exception ex)
            {
                return "Error" + ex.ToString();
            }

        }





        /*[HttpGet]
        public IEnumerable<Account> GetLogin(*//*String _id*//*)
        {
            String _id = "User";
            // return "value";

                MySqlConnection conn = Connected.GetDBConnection();
                String sql = "SELECT * FROM webintroduce.account where User = '" + _id ;
                MySqlDataAdapter Adapter = new MySqlDataAdapter(sql, conn);
                Account m_account = new Account();
                DataTable m_table = new DataTable();
                Adapter.Fill(m_table);
                
                if (m_table.Rows.Count > 0)
                {

                    DataRow dataRow = m_table.Select("User = '" + _id +"'").FirstOrDefault();
                    if (dataRow != null)
                    {
                        m_account.Password = (string)dataRow["Password"];
                    }
                    
                    return (IEnumerable<Account>)m_account;
                    
                }
                else
                {
                    
                    return (IEnumerable<Account>)m_account;
                }


        }*/


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