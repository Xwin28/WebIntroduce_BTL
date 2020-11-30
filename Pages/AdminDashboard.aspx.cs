using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebIntroduce_BTL.Controller;

namespace WebIntroduce_BTL.Pages
{
    
    public partial class AdminDashboard : System.Web.UI.Page
    {
        public String m_SProduct_1, m_SProduct_2, m_SProduct_3, m_SProduct_4, m_SProduct_5;
        public int m_Current_Page=1;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Hident all product
            m_SProduct_1 = "style=" + "\"" + "display:none; margin-top: 20px;" + "\"";
            m_SProduct_2 = "style=" + "\"" + "display:none; margin-top: 20px;" + "\"";
            m_SProduct_3 = "style=" + "\"" + "display:none; margin-top: 20px;" + "\"";
            m_SProduct_4 = "style=" + "\"" + "display:none; margin-top: 20px;" + "\"";
            m_SProduct_5 = "style=" + "\"" + "display:none; margin-top: 20px;" + "\"";
            if (IsPostBack)
            {
                btn_Product.BorderColor = Color.Red;
                btn_Product.Font.Bold = true;
            }

            try
            {
                // Get data From API
                HttpClient hc = new HttpClient
                {
                    BaseAddress = new Uri("https://localhost:44304/api/")
                };
                var comsumapi = hc.GetAsync("Account/GetLogin/");
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

                    //Show div Product if have in database
                    switch(convertedList.Count)
                    {
                        case 1:
                            m_SProduct_1 = "style=" + "\"" + "margin-top: 20px;" + "\"";
                            break;
                        case 2:
                            m_SProduct_1 = "style=" + "\"" + "margin-top: 20px;" + "\"";
                            m_SProduct_2 = "style=" + "\"" + "margin-top: 20px;" + "\"";

                            break;
                        case 3:
                            m_SProduct_1 = "style=" + "\"" + "margin-top: 20px;" + "\"";
                            m_SProduct_2 = "style=" + "\"" + "margin-top: 20px;" + "\"";
                            m_SProduct_3 = "style=" + "\"" + "margin-top: 20px;" + "\"";
                            break;
                        case 4:
                            m_SProduct_1 = "style=" + "\"" + "margin-top: 20px;" + "\"";
                            m_SProduct_2 = "style=" + "\"" + "margin-top: 20px;" + "\"";
                            m_SProduct_3 = "style=" + "\"" + "margin-top: 20px;" + "\"";
                            m_SProduct_4 = "style=" + "\"" + "margin-top: 20px;" + "\"";
                            break;
                        case 5:
                            m_SProduct_1 = "style=" + "\"" + "margin-top: 20px;" + "\"";
                            m_SProduct_2 = "style=" + "\"" + "margin-top: 20px;" + "\"";
                            m_SProduct_3 = "style=" + "\"" + "margin-top: 20px;" + "\"";
                            m_SProduct_4 = "style=" + "\"" + "margin-top: 20px;" + "\"";
                            m_SProduct_5 = "style=" + "\"" + "margin-top: 20px;" + "\"";
                            break;
                    }


                    String m_tempUser = "";
                    String m_tempPass = "";
                    String m_tempEmail = "";
                    foreach (Account a in convertedList)
                    {
                        m_tempUser = a.User;
                        m_tempPass = a.Password;
                        m_tempEmail = a.Email;
                    }



                }

            }
            catch (Exception ex)
            {
                Response.Write(" Exception " + ex.ToString());
                
            }

        }
    }
}