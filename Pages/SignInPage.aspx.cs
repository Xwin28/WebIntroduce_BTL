using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using WebIntroduce_BTL.Controller;
using Newtonsoft.Json;
using System.Data;

namespace WebIntroduce_BTL.Pages
{
    public partial class SignInPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                String _user = txt_Email.Value.ToString().Trim();
                String _pass = txt_Password.Value.ToString().Trim();
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
                    foreach (Account a in convertedList)
                    {
                        m_tempUser = a.User;
                        m_tempPass = a.Password;
                    }

                    if (_user.Equals(m_tempUser) && _pass.Equals(m_tempPass))
                    {
                        Response.Write(" Dang Nhap Thanh Con User " + m_tempUser + " Pass " + m_tempPass);
                    }
                    else
                    {
                        Response.Write(" Dang Nhap That Bai " + m_tempUser + " Pass " + m_tempPass);
                    }

                }
                else
                {
                    Response.Write("Fail");
                }
            }
            catch(Exception ex)
            {
                Response.Write(" Dang Nhap That Bai " +ex.ToString());
            }

        }
    }
}