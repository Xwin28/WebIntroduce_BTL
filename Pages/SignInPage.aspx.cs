using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using WebIntroduce_BTL.Controller;
using Newtonsoft.Json;
using System.Data;
using System.Security.Cryptography;

namespace WebIntroduce_BTL.Pages
{
    public partial class SignInPage : System.Web.UI.Page
    {
        public String _Error, _WrongUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            _WrongUser = "style=" + "\"" + "display:none" + "\"";
            if (IsPostBack)
            {
                
            }
            
        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {

            try
            {
                String _user = txt_Email.Value.ToString();
                _user = _user.Replace(".com", "").Trim();
                 
                String _pass = txt_Password.Value.ToString().Trim();


                SHA256 sha256 = SHA256.Create();
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(_pass));
                String PassEncpt = BitConverter.ToString(bytes);

                // Get data From API
                HttpClient hc = new HttpClient
                {
                    BaseAddress = new Uri("https://localhost:44304/api/")
                };
                var comsumapi = hc.GetAsync("Account/GetLogin/" + _user);
                comsumapi.Wait();// Wait for Excute
                var readDate = comsumapi.Result;
                if (readDate.IsSuccessStatusCode)
                {
                    //Get Json
                    var displayrecord = readDate.Content.ReadAsAsync<String>();
                    displayrecord.Wait();
                    String _AcountJson = displayrecord.Result;
                    DataTable _table = JsonConvert.DeserializeObject<DataTable>(_AcountJson);
                    //Change Json to List of "Account"
                    var convertedList = (from rw in _table.AsEnumerable()
                                         select new Account()
                                         {
                                             User = Convert.ToString(rw["User"]),
                                             Email = Convert.ToString(rw["Email"]),
                                             Password = Convert.ToString(rw["Password"])
                                         }).ToList();
                    String m_tempUser = "";
                    String m_tempPass = "";
                    String m_tempEmail = "";
                    foreach (Account a in convertedList)
                    {
                        m_tempUser = a.User;
                        m_tempPass = a.Password;
                        m_tempEmail = a.Email;
                    }

                    if (_user.Equals(m_tempUser) && PassEncpt.Equals(m_tempPass)
                        || _user.Equals(m_tempEmail) && PassEncpt.Equals(m_tempPass))
                    {
                        Session["user"] = _user;
                        //Response.Write(" Success ");

                    }
                    else
                    {
                        //Response.Write(" Wrong Pass User =" +m_tempUser+ "/n pass= "+ m_tempPass +" Email =" +m_tempEmail);
                        _WrongUser = null;
                    }

                }
                else
                {
                    _WrongUser = null;
                }
            }
            catch(Exception ex)
            {
                //Response.Write(" Exception " + ex.ToString());
                _WrongUser = null;
            }

        }
    }
}