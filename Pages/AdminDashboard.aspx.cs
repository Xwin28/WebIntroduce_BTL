using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebIntroduce_BTL.Controller;

namespace WebIntroduce_BTL.Pages
{

    public partial class AdminDashboard : System.Web.UI.Page
    {
        public String m_SProduct_1, m_SProduct_2, m_SProduct_3, m_SProduct_4, m_SProduct_5;
        public String mSpagePre, mSpage_1, mSpage_2, mSpage_3, mSpage_4, mSpage_5, mSpage_6, mSpage_7, mSpageNext;
        List<Account> convertedList;
        protected void btn_page_7_Click(object sender, EventArgs e)
        {
            m_Current_Page = m_NumberProduct;
            Session["m_Current_Page"] = m_Current_Page;
            btn_page_next.Enabled = false;
            PostBack();
        }

        protected void btn_page_2_Click(object sender, EventArgs e)
        {

            if (m_NumberProduct > 5 && m_NumberProduct <= 10)
            {
                m_Current_Page = 2;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(2);
                btn_page_next.Enabled = false;
                PostBack();
            }
            else if (m_NumberProduct > 10 && m_NumberProduct <= 15)
            {
                m_Current_Page = 2;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(2);
                PostBack();
            }
            else if (m_NumberProduct > 15 && m_NumberProduct <= 20)
            {
                m_Current_Page = 2;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(2);
                PostBack();
            }
            else if (m_NumberProduct > 20 && m_NumberProduct <= 25)
            {
                m_Current_Page = 2;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(2);
                PostBack();
            }
            else if (m_NumberProduct > 25 && m_NumberProduct <= 30)
            {
                m_Current_Page = 2;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(2);
                PostBack();
            }
            else if (m_NumberProduct > 30 && m_NumberProduct <= 35)
            {
                m_Current_Page = 2;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(2);
                PostBack();
            }
            else if (m_NumberProduct > 35 && m_Current_Page < 5)
            {
                m_Current_Page = 2;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(2);
                PostBack();
            }
            else if (m_NumberProduct > 30 && m_Current_Page > (m_NumberProduct - 5))
            {
                // Enable Flase
            }
            else if (m_NumberProduct > 30 && m_Current_Page < (m_NumberProduct - 5) && m_Current_Page > 5)
            {
                // Enable Flase
            }
        }

        protected void btn_page_3_Click(object sender, EventArgs e)
        {
            if (m_NumberProduct > 5 && m_NumberProduct <= 10)
            {
                // not show <12>
            }
            else if (m_NumberProduct > 10 && m_NumberProduct <= 15)
            {   //<123>
                m_Current_Page = 3;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(3);
                btn_page_next.Enabled = false;
                PostBack();
            }
            else if (m_NumberProduct > 15 && m_NumberProduct <= 20)
            {   //<1234>
                m_Current_Page = 3;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(3);
                PostBack();
            }
            else if (m_NumberProduct > 20 && m_NumberProduct <= 25)
            {   //<12345>
                m_Current_Page = 3;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(3);
                PostBack();
            }
            else if (m_NumberProduct > 25 && m_NumberProduct <= 30)
            {   //<123456>
                m_Current_Page = 3;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(3);
                PostBack();
            }
            else if (m_NumberProduct > 30 && m_NumberProduct <= 35)
            {   //<1234567>
                m_Current_Page = 3;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(3);
                PostBack();
            }
            else if (m_NumberProduct > 35 && m_Current_Page < 5)
            {   //<12345...last>
                m_Current_Page = 3;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(3);
                PostBack();
            }
            else if (m_NumberProduct > 30 && m_Current_Page > (m_NumberProduct - 5))
            {
                m_Current_Page = m_NumberProduct - 4;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(3);
                PostBack();
            }
            else if (m_NumberProduct > 30 && m_Current_Page < (m_NumberProduct - 5) && m_Current_Page > 5)
            {
                m_Current_Page = m_Current_Page - 1;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(3);
                PostBack();
            }
        }

        protected void btn_page_4_Click(object sender, EventArgs e)
        {
            if (m_NumberProduct > 5 && m_NumberProduct <= 10)
            {
                //<12>
            }
            else if (m_NumberProduct > 10 && m_NumberProduct <= 15)
            {
                //<123>
            }
            else if (m_NumberProduct > 15 && m_NumberProduct <= 20)
            {
                //<1234>
                m_Current_Page = 4;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(4);
                btn_page_next.Enabled = false;
                PostBack();
            }
            else if (m_NumberProduct > 20 && m_NumberProduct <= 25)
            {
                //<12345>
                m_Current_Page = 4;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(4);
                PostBack();
            }
            else if (m_NumberProduct > 25 && m_NumberProduct <= 30)
            {
                //<123456>
                m_Current_Page = 4;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(4);
                PostBack();
            }
            else if (m_NumberProduct > 30 && m_NumberProduct <= 35)
            {
                //<1234567>
                m_Current_Page = 4;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(4);
                PostBack();
            }
            else if (m_NumberProduct > 35 && m_Current_Page < 5)
            {
                //<12345...7>
                m_Current_Page = 4;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(4);
                PostBack();
            }
            else if (m_NumberProduct > 30 && m_Current_Page > (m_NumberProduct - 5))
            {
                //<1..34567>
                m_Current_Page = m_NumberProduct - 3;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(4);
                PostBack();
            }
            else if (m_NumberProduct > 30 && m_Current_Page < (m_NumberProduct - 5) && m_Current_Page > 5)
            {
                //<1...3 4 5...7> 4 = currenPages
            }
        }

        protected void btn_page_5_Click(object sender, EventArgs e)
        {
            if (m_NumberProduct > 5 && m_NumberProduct <= 10)
            {
                //<12>
            }
            else if (m_NumberProduct > 10 && m_NumberProduct <= 15)
            {
                //<123>
            }
            else if (m_NumberProduct > 15 && m_NumberProduct <= 20)
            {
                //<1234>
            }
            else if (m_NumberProduct > 20 && m_NumberProduct <= 25)
            {
                //<12345>
                m_Current_Page = 5;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(5);
                btn_page_next.Enabled = false;
                PostBack();
            }
            else if (m_NumberProduct > 25 && m_NumberProduct <= 30)
            {
                //<123456>
                m_Current_Page = 5;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(5);
                PostBack();
            }
            else if (m_NumberProduct > 30 && m_NumberProduct <= 35)
            {
                //<1234567>
                m_Current_Page = 5;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(5);
                PostBack();
            }
            else if (m_NumberProduct > 35 && m_Current_Page < 5)
            {
                //<123456...7>
                m_Current_Page = 5;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(5);
                PostBack();
            }
            else if (m_NumberProduct > 30 && m_Current_Page > (m_NumberProduct - 5))
            {
                //<1...34567>
                m_Current_Page = m_NumberProduct - 2;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(5);
                PostBack();
            }
            else if (m_NumberProduct > 30 && m_Current_Page < (m_NumberProduct - 5) && m_Current_Page > 5)
            {
                //<...3 4 5 ... 7>
                m_Current_Page = m_Current_Page + 1;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(5);
                PostBack();
            }
        }

        protected void btn_page_6_Click(object sender, EventArgs e)
        {
            if (m_NumberProduct > 5 && m_NumberProduct <= 10)
            {
                //<12>
            }
            else if (m_NumberProduct > 10 && m_NumberProduct <= 15)
            {
                //<123>
            }
            else if (m_NumberProduct > 15 && m_NumberProduct <= 20)
            {
                //<1234>
            }
            else if (m_NumberProduct > 20 && m_NumberProduct <= 25)
            {
                //<12345>
            }
            else if (m_NumberProduct > 25 && m_NumberProduct <= 30)
            {
                //<123456>
                m_Current_Page = 6;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(6);
                btn_page_next.Enabled = false;
                PostBack();
            }
            else if (m_NumberProduct > 30 && m_NumberProduct <= 35)
            {
                //<1234567>
                m_Current_Page = 6;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(6);
                PostBack();
            }
            else if (m_NumberProduct > 35 && m_Current_Page < 5)
            {
                //<12345...7>
                // not set
            }
            else if (m_NumberProduct > 30 && m_Current_Page > (m_NumberProduct - 5))
            {
                //<1..34567>
                m_Current_Page = 6;
                Session["m_Current_Page"] = m_Current_Page;
                SwitchPageColor(6);
                PostBack();

            }
            else if (m_NumberProduct > 30 && m_Current_Page < (m_NumberProduct - 5) && m_Current_Page > 5)
            {
                //<1... 3 4 5 ... 7>
                //not set

            }
        }

        protected void btn_page_next_Click(object sender, EventArgs e)
        {
            if (m_Current_Page < m_NumberProduct)
            {
                m_Current_Page = m_Current_Page + 1;
                SwitchPageColor(m_Current_Page);
                Session["m_Current_Page"] = m_Current_Page;
            }

            if (m_Current_Page == m_NumberProduct)
            {
                btn_page_next.Enabled = false;
            }
            PostBack();
        }

        protected void btn_page_1_Click(object sender, EventArgs e)
        {
            m_Current_Page = 1;
            Session["m_Current_Page"] = m_Current_Page;
            btn_page_previous.Enabled = false;
            PostBack();
        }

        protected void btn_page_previous_Click(object sender, EventArgs e)
        {
            if (m_Current_Page > 1)
            {
                m_Current_Page = m_Current_Page - 1;
                SwitchPageColor(m_Current_Page);
                Session["m_Current_Page"] = m_Current_Page;
            }

            if (m_Current_Page == 1)
            {
                btn_page_previous.Enabled = false;
            }
            PostBack();
        }

        public int m_Current_Page, m_NumberProduct;
        protected void Page_Load(object sender, EventArgs e)
        {

            //Post Back
            if (!IsPostBack)
            {
                //Run On First Time
                m_Current_Page = 1;
                Session["m_Current_Page"] = m_Current_Page;
                //Hident all product
                btn_page_1.ForeColor = Color.FromArgb(59, 110, 140);
                btn_page_1.Enabled = false;
                btn_page_previous.Enabled = false;
                m_SProduct_1 = "style=" + "\"" + "display:none; margin-top: 20px;" + "\"";
                m_SProduct_2 = "style=" + "\"" + "display:none; margin-top: 20px;" + "\"";
                m_SProduct_3 = "style=" + "\"" + "display:none; margin-top: 20px;" + "\"";
                m_SProduct_4 = "style=" + "\"" + "display:none; margin-top: 20px;" + "\"";
                m_SProduct_5 = "style=" + "\"" + "display:none; margin-top: 20px;" + "\"";
                mSpagePre = "style=" + "\"" + "display:none;" + "\"";
                mSpage_1 = "style=" + "\"" + "display:none;" + "\"";
                mSpage_2 = "style=" + "\"" + "display:none;" + "\"";
                mSpage_3 = "style=" + "\"" + "display:none;" + "\"";
                mSpage_4 = "style=" + "\"" + "display:none;" + "\"";
                mSpage_5 = "style=" + "\"" + "display:none;" + "\"";
                mSpage_6 = "style=" + "\"" + "display:none;" + "\"";
                mSpage_7 = "style=" + "\"" + "display:none;" + "\"";
                mSpageNext = "style=" + "\"" + "display:none;" + "\"";

                try
                {
                    // Get data From API
                    HttpClient hc = new HttpClient
                    {
                        BaseAddress = new Uri("https://localhost:44304/api/")
                    };
                    var comsumapi = hc.GetAsync("Account/GetLogin?begin=0&number=5");
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
                        convertedList = (from rw in _table.AsEnumerable()
                                         select new Account()
                                         {
                                             User = Convert.ToString(rw["User"]),
                                             Email = Convert.ToString(rw["Email"]),
                                             Password = Convert.ToString(rw["Password"])
                                         }).ToList();

                    }

                    // take count of all product
                    comsumapi = hc.GetAsync("Account/GetCountLogin/");
                    comsumapi.Wait();// Wait for Excute
                    readDate = comsumapi.Result;
                    if (readDate.IsSuccessStatusCode)
                    {
                        //Get Json
                        var displayrecord = readDate.Content.ReadAsAsync<String>();
                        displayrecord.Wait();
                        String _Json = displayrecord.Result;
                        JsonDocument doc = JsonDocument.Parse(_Json);
                        JsonElement root = doc.RootElement;
                        m_NumberProduct = int.Parse(root[0].GetProperty("COUNT(*)").ToString());
                        Session["m_NumberProduct"] = m_NumberProduct;
                    }

                    //Phan Trang
                    int m_TempPage = m_NumberProduct / 5;
                    int m_NumberProductinPage = 0;
                    if (m_Current_Page <= m_TempPage)
                    {
                        m_NumberProductinPage = 5;
                        Label[] m_label = { lbl_ProductName_1, lbl_ProductName_2, lbl_ProductName_3, lbl_ProductName_4, lbl_ProductName_5 };
                        int temp = 0;
                        foreach (Account m_acc in convertedList)
                        {
                            m_label[temp].Text = m_acc.User;
                            temp++;
                        }
                    }
                    else
                    {
                        m_NumberProductinPage = (m_NumberProduct % 5);
                        Label[] m_label = { lbl_ProductName_1, lbl_ProductName_2, lbl_ProductName_3, lbl_ProductName_4, lbl_ProductName_5 };
                        int temp = 0;
                        foreach (Account m_acc in convertedList)
                        {
                            m_label[temp].Text = m_acc.User;
                            temp++;
                        }
                    }
                    //Show div Product if have in database
                    switch (m_NumberProductinPage)
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

                    if (m_NumberProduct > 5 && m_NumberProduct <= 10)
                    {
                        mSpagePre = null;
                        mSpageNext = null;
                        mSpage_1 = null;
                        btn_page_1.Text = "1";
                        mSpage_2 = null;
                        btn_page_2.Text = "2";
                    }
                    else if (m_NumberProduct > 10 && m_NumberProduct <= 15)
                    {
                        mSpagePre = null;
                        mSpageNext = null;
                        mSpage_1 = null;
                        btn_page_1.Text = "1";
                        mSpage_2 = null;
                        btn_page_2.Text = "2";
                        mSpage_3 = null;
                        btn_page_3.Text = "3";
                    }
                    else if (m_NumberProduct > 15 && m_NumberProduct <= 20)
                    {
                        mSpagePre = null;
                        mSpageNext = null;
                        mSpage_1 = null;
                        btn_page_1.Text = "1";
                        mSpage_2 = null;
                        btn_page_2.Text = "2";
                        mSpage_3 = null;
                        btn_page_3.Text = "3";
                        mSpage_4 = null;
                        btn_page_4.Text = "4";
                    }
                    else if (m_NumberProduct > 20 && m_NumberProduct <= 25)
                    {
                        mSpagePre = null;
                        mSpageNext = null;
                        mSpage_1 = null;
                        btn_page_1.Text = "1";
                        mSpage_2 = null;
                        btn_page_2.Text = "2";
                        mSpage_3 = null;
                        btn_page_3.Text = "3";
                        mSpage_4 = null;
                        btn_page_4.Text = "4";
                        mSpage_5 = null;
                        btn_page_5.Text = "5";
                    }
                    else if (m_NumberProduct > 25 && m_NumberProduct <= 30)
                    {
                        mSpagePre = null;
                        mSpageNext = null;
                        mSpage_1 = null;
                        btn_page_1.Text = "1";
                        mSpage_2 = null;
                        btn_page_2.Text = "2";
                        mSpage_3 = null;
                        btn_page_3.Text = "3";
                        mSpage_4 = null;
                        btn_page_4.Text = "4";
                        mSpage_5 = null;
                        btn_page_5.Text = "5";
                        mSpage_6 = null;
                        btn_page_6.Text = "6";
                    }
                    else if (m_NumberProduct > 30 && m_NumberProduct <= 35)
                    {
                        mSpagePre = null;
                        mSpageNext = null;
                        mSpage_1 = null;
                        btn_page_1.Text = "1";
                        mSpage_2 = null;
                        btn_page_2.Text = "2";
                        mSpage_3 = null;
                        btn_page_3.Text = "3";
                        mSpage_4 = null;
                        btn_page_4.Text = "4";
                        mSpage_5 = null;
                        btn_page_5.Text = "5";
                        mSpage_6 = null;
                        btn_page_6.Text = "6";
                        mSpage_7 = null;
                        btn_page_7.Text = "7";
                    }
                    else if (m_NumberProduct > 35)
                    {
                        mSpagePre = null;
                        mSpageNext = null;
                        mSpage_1 = null;
                        btn_page_1.Text = "1";
                        mSpage_2 = null;
                        btn_page_2.Text = "2";
                        mSpage_3 = null;
                        btn_page_3.Text = "3";
                        mSpage_4 = null;
                        btn_page_4.Text = "4";
                        mSpage_5 = null;
                        btn_page_5.Text = "5";
                        mSpage_6 = null;
                        btn_page_6.Text = "...";
                        btn_page_6.Enabled = false;
                        mSpage_7 = null;
                        btn_page_7.Text = m_NumberProduct.ToString();
                    }



                }
                catch (Exception ex)
                {
                    Response.Write(" Exception " + ex.ToString());

                }

            }
            else
            {
                m_Current_Page = int.Parse(Session["m_Current_Page"].ToString());
                m_NumberProduct = int.Parse(Session["m_NumberProduct"].ToString());
            }

        }

        // Because Post back in Page_Load Run Before Function of Button
        public void PostBack()
        {
            Response.Write("POST BACK");
            m_SProduct_1 = "style=" + "\"" + "display:none; margin-top: 20px;" + "\"";
            m_SProduct_2 = "style=" + "\"" + "display:none; margin-top: 20px;" + "\"";
            m_SProduct_3 = "style=" + "\"" + "display:none; margin-top: 20px;" + "\"";
            m_SProduct_4 = "style=" + "\"" + "display:none; margin-top: 20px;" + "\"";
            m_SProduct_5 = "style=" + "\"" + "display:none; margin-top: 20px;" + "\"";
            mSpagePre = "style=" + "\"" + "display:none;" + "\"";
            mSpage_1 = "style=" + "\"" + "display:none;" + "\"";
            mSpage_2 = "style=" + "\"" + "display:none;" + "\"";
            mSpage_3 = "style=" + "\"" + "display:none;" + "\"";
            mSpage_4 = "style=" + "\"" + "display:none;" + "\"";
            mSpage_5 = "style=" + "\"" + "display:none;" + "\"";
            mSpage_6 = "style=" + "\"" + "display:none;" + "\"";
            mSpage_7 = "style=" + "\"" + "display:none;" + "\"";
            mSpageNext = "style=" + "\"" + "display:none;" + "\"";


            try
            {
                int m_TempPage = m_NumberProduct / 5;
                //set begin and number to select in Database
                String begin="", number="5";
                if (m_Current_Page <= m_TempPage)
                {
                    begin = ((m_Current_Page - 1) * 5).ToString();
                }
                else
                {
                    begin = ((m_Current_Page - 1) * 5).ToString();

                }

                // Get data From API
                HttpClient hc = new HttpClient
                {
                    BaseAddress = new Uri("https://localhost:44304/api/")
                };
                var comsumapi = hc.GetAsync("Account/GetLogin?begin="+begin+"&number="+number+"");
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
                    convertedList = (from rw in _table.AsEnumerable()
                                     select new Account()
                                     {
                                         User = Convert.ToString(rw["User"]),
                                         Email = Convert.ToString(rw["Email"]),
                                         Password = Convert.ToString(rw["Password"])
                                     }).ToList();

                }
                //Phan Trang
                
                float m_NumberProductinPage = 0;
                if (m_Current_Page <= m_TempPage)
                {
                    m_NumberProductinPage = 5;
                    Label[] m_label = { lbl_ProductName_1, lbl_ProductName_2, lbl_ProductName_3, lbl_ProductName_4, lbl_ProductName_5 };
                    int temp = 0;
                    foreach(Account m_acc in convertedList)
                    {
                        m_label[temp].Text = m_acc.User;
                        temp++;
                    }
                }
                else
                {
                    m_NumberProductinPage = (m_NumberProduct % 5);
                    Label[] m_label = { lbl_ProductName_1, lbl_ProductName_2, lbl_ProductName_3, lbl_ProductName_4, lbl_ProductName_5 };
                    int temp = 0;
                    foreach (Account m_acc in convertedList)
                    {
                        m_label[temp].Text = m_acc.User;
                        temp++;
                    }
                }
                //Show div Product if have in database
                switch (m_NumberProductinPage)
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

                if (m_NumberProduct > 5 && m_NumberProduct <= 10)
                {
                    mSpagePre = null;
                    mSpageNext = null;
                    mSpage_1 = null;
                    btn_page_1.Text = "1";
                    mSpage_2 = null;
                    btn_page_2.Text = "2";
                }
                else if (m_NumberProduct > 10 && m_NumberProduct <= 15)
                {
                    mSpagePre = null;
                    mSpageNext = null;
                    mSpage_1 = null;
                    btn_page_1.Text = "1";
                    mSpage_2 = null;
                    btn_page_2.Text = "2";
                    mSpage_3 = null;
                    btn_page_3.Text = "3";
                }
                else if (m_NumberProduct > 15 && m_NumberProduct <= 20)
                {
                    mSpagePre = null;
                    mSpageNext = null;
                    mSpage_1 = null;
                    btn_page_1.Text = "1";
                    mSpage_2 = null;
                    btn_page_2.Text = "2";
                    mSpage_3 = null;
                    btn_page_3.Text = "3";
                    mSpage_4 = null;
                    btn_page_4.Text = "4";
                }
                else if (m_NumberProduct > 20 && m_NumberProduct <= 25)
                {
                    mSpagePre = null;
                    mSpageNext = null;
                    mSpage_1 = null;
                    btn_page_1.Text = "1";
                    mSpage_2 = null;
                    btn_page_2.Text = "2";
                    mSpage_3 = null;
                    btn_page_3.Text = "3";
                    mSpage_4 = null;
                    btn_page_4.Text = "4";
                    mSpage_5 = null;
                    btn_page_5.Text = "5";
                }
                else if (m_NumberProduct > 25 && m_NumberProduct <= 30)
                {
                    mSpagePre = null;
                    mSpageNext = null;
                    mSpage_1 = null;
                    btn_page_1.Text = "1";
                    mSpage_2 = null;
                    btn_page_2.Text = "2";
                    mSpage_3 = null;
                    btn_page_3.Text = "3";
                    mSpage_4 = null;
                    btn_page_4.Text = "4";
                    mSpage_5 = null;
                    btn_page_5.Text = "5";
                    mSpage_6 = null;
                    btn_page_6.Text = "6";
                }
                else if (m_NumberProduct > 30 && m_NumberProduct <= 35)
                {
                    mSpagePre = null;
                    mSpageNext = null;
                    mSpage_1 = null;
                    btn_page_1.Text = "1";
                    mSpage_2 = null;
                    btn_page_2.Text = "2";
                    mSpage_3 = null;
                    btn_page_3.Text = "3";
                    mSpage_4 = null;
                    btn_page_4.Text = "4";
                    mSpage_5 = null;
                    btn_page_5.Text = "5";
                    mSpage_6 = null;
                    btn_page_6.Text = "6";
                    mSpage_7 = null;
                    btn_page_7.Text = "7";
                }
                else if (m_NumberProduct > 35 && m_Current_Page < 5)
                {
                    mSpagePre = null;
                    mSpageNext = null;
                    mSpage_1 = null;
                    btn_page_1.Text = "1";
                    mSpage_2 = null;
                    btn_page_2.Text = "2";
                    mSpage_3 = null;
                    btn_page_3.Text = "3";
                    mSpage_4 = null;
                    btn_page_4.Text = "4";
                    mSpage_5 = null;
                    btn_page_5.Text = "5";
                    mSpage_6 = null;
                    btn_page_6.Text = "...";
                    btn_page_6.Enabled = false;
                    mSpage_7 = null;
                    btn_page_7.Text = m_NumberProduct.ToString();
                }
                else if (m_NumberProduct > 30 && m_Current_Page > (m_NumberProduct - 5))
                {
                    mSpagePre = null;
                    mSpageNext = null;
                    mSpage_1 = null;
                    btn_page_1.Text = "1";
                    mSpage_2 = null;
                    btn_page_2.Text = "...";
                    btn_page_2.Enabled = false;
                    mSpage_3 = null;
                    btn_page_3.Text = (m_NumberProduct - 4).ToString();
                    mSpage_4 = null;
                    btn_page_4.Text = (m_NumberProduct - 3).ToString();
                    mSpage_5 = null;
                    btn_page_5.Text = (m_NumberProduct - 2).ToString();
                    mSpage_6 = null;
                    btn_page_6.Text = (m_NumberProduct - 1).ToString();
                    mSpage_7 = null;
                    btn_page_7.Text = m_NumberProduct.ToString();
                }
                else if (m_NumberProduct > 30 && m_Current_Page < (m_NumberProduct - 5) && m_Current_Page > 5)
                {
                    mSpagePre = null;
                    mSpageNext = null;
                    mSpage_1 = null;
                    btn_page_1.Text = "1";
                    mSpage_2 = null;
                    btn_page_2.Text = "...";
                    btn_page_2.Enabled = false;
                    mSpage_3 = null;
                    btn_page_3.Text = (m_Current_Page - 1).ToString();
                    mSpage_4 = null;
                    btn_page_4.Text = (m_Current_Page).ToString();
                    mSpage_5 = null;
                    btn_page_5.Text = (m_Current_Page + 1).ToString();
                    mSpage_6 = null;
                    btn_page_6.Text = "...";
                    btn_page_6.Enabled = false;
                    mSpage_7 = null;
                    btn_page_7.Text = m_NumberProduct.ToString();
                }





                /*// Get data From API
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
                    m_NumberProduct = convertedList.Count;
                    //Phan Trang
                    int m_TempPage = m_NumberProduct / 5;
                    float m_NumberProductinPage = 0;
                    if (m_Current_Page <= m_TempPage)
                    {
                        m_NumberProductinPage = 5;
                        Label[] m_label = { lbl_ProductName_1, lbl_ProductName_2, lbl_ProductName_3, lbl_ProductName_4, lbl_ProductName_5 };
                        int temp = 0;
                        for (int i = (m_Current_Page - 1) * 5; i < (m_Current_Page * 5); i++)
                        {
                            m_label[temp].Text = convertedList[i].User;
                            temp++;
                        }
                    }
                    else
                    {
                        m_NumberProductinPage = (m_NumberProduct % 5) * 5;
                        Label[] m_label = { lbl_ProductName_1, lbl_ProductName_2, lbl_ProductName_3, lbl_ProductName_4, lbl_ProductName_5 };
                        int temp = 0;
                        for (int i = (m_Current_Page - 1) * 5; i < m_NumberProduct; i++)
                        {
                            m_label[temp].Text = convertedList[i].User;
                            temp++;
                        }
                    }
                    //Show div Product if have in database
                    switch (m_NumberProductinPage)
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

                    if (m_NumberProduct > 5 && m_NumberProduct <= 10)
                    {
                        mSpagePre = null;
                        mSpageNext = null;
                        mSpage_1 = null;
                        btn_page_1.Text = "1";
                        mSpage_2 = null;
                        btn_page_2.Text = "2";
                    }
                    else if (m_NumberProduct > 10 && m_NumberProduct <= 15)
                    {
                        mSpagePre = null;
                        mSpageNext = null;
                        mSpage_1 = null;
                        btn_page_1.Text = "1";
                        mSpage_2 = null;
                        btn_page_2.Text = "2";
                        mSpage_3 = null;
                        btn_page_3.Text = "3";
                    }
                    else if (m_NumberProduct > 15 && m_NumberProduct <= 20)
                    {
                        mSpagePre = null;
                        mSpageNext = null;
                        mSpage_1 = null;
                        btn_page_1.Text = "1";
                        mSpage_2 = null;
                        btn_page_2.Text = "2";
                        mSpage_3 = null;
                        btn_page_3.Text = "3";
                        mSpage_4 = null;
                        btn_page_4.Text = "4";
                    }
                    else if (m_NumberProduct > 20 && m_NumberProduct <= 25)
                    {
                        mSpagePre = null;
                        mSpageNext = null;
                        mSpage_1 = null;
                        btn_page_1.Text = "1";
                        mSpage_2 = null;
                        btn_page_2.Text = "2";
                        mSpage_3 = null;
                        btn_page_3.Text = "3";
                        mSpage_4 = null;
                        btn_page_4.Text = "4";
                        mSpage_5 = null;
                        btn_page_5.Text = "5";
                    }
                    else if (m_NumberProduct > 25 && m_NumberProduct <= 30)
                    {
                        mSpagePre = null;
                        mSpageNext = null;
                        mSpage_1 = null;
                        btn_page_1.Text = "1";
                        mSpage_2 = null;
                        btn_page_2.Text = "2";
                        mSpage_3 = null;
                        btn_page_3.Text = "3";
                        mSpage_4 = null;
                        btn_page_4.Text = "4";
                        mSpage_5 = null;
                        btn_page_5.Text = "5";
                        mSpage_6 = null;
                        btn_page_6.Text = "6";
                    }
                    else if (m_NumberProduct > 30 && m_NumberProduct <= 35)
                    {
                        mSpagePre = null;
                        mSpageNext = null;
                        mSpage_1 = null;
                        btn_page_1.Text = "1";
                        mSpage_2 = null;
                        btn_page_2.Text = "2";
                        mSpage_3 = null;
                        btn_page_3.Text = "3";
                        mSpage_4 = null;
                        btn_page_4.Text = "4";
                        mSpage_5 = null;
                        btn_page_5.Text = "5";
                        mSpage_6 = null;
                        btn_page_6.Text = "6";
                        mSpage_7 = null;
                        btn_page_7.Text = "7";
                    }
                    else if (m_NumberProduct > 35 && m_Current_Page < 5)
                    {
                        mSpagePre = null;
                        mSpageNext = null;
                        mSpage_1 = null;
                        btn_page_1.Text = "1";
                        mSpage_2 = null;
                        btn_page_2.Text = "2";
                        mSpage_3 = null;
                        btn_page_3.Text = "3";
                        mSpage_4 = null;
                        btn_page_4.Text = "4";
                        mSpage_5 = null;
                        btn_page_5.Text = "5";
                        mSpage_6 = null;
                        btn_page_6.Text = "...";
                        btn_page_6.Enabled = false;
                        mSpage_7 = null;
                        btn_page_7.Text = m_NumberProduct.ToString();
                    }
                    else if (m_NumberProduct > 30 && m_Current_Page > (m_NumberProduct - 5))
                    {
                        mSpagePre = null;
                        mSpageNext = null;
                        mSpage_1 = null;
                        btn_page_1.Text = "1";
                        mSpage_2 = null;
                        btn_page_2.Text = "...";
                        btn_page_2.Enabled = false;
                        mSpage_3 = null;
                        btn_page_3.Text = (m_NumberProduct - 4).ToString();
                        mSpage_4 = null;
                        btn_page_4.Text = (m_NumberProduct - 3).ToString();
                        mSpage_5 = null;
                        btn_page_5.Text = (m_NumberProduct - 2).ToString();
                        mSpage_6 = null;
                        btn_page_6.Text = (m_NumberProduct - 1).ToString();
                        mSpage_7 = null;
                        btn_page_7.Text = m_NumberProduct.ToString();
                    }
                    else if (m_NumberProduct > 30 && m_Current_Page < (m_NumberProduct - 5) && m_Current_Page > 5)
                    {
                        mSpagePre = null;
                        mSpageNext = null;
                        mSpage_1 = null;
                        btn_page_1.Text = "1";
                        mSpage_2 = null;
                        btn_page_2.Text = "...";
                        btn_page_2.Enabled = false;
                        mSpage_3 = null;
                        btn_page_3.Text = (m_Current_Page - 1).ToString();
                        mSpage_4 = null;
                        btn_page_4.Text = (m_Current_Page).ToString();
                        mSpage_5 = null;
                        btn_page_5.Text = (m_Current_Page + 1).ToString();
                        mSpage_6 = null;
                        btn_page_6.Text = "...";
                        btn_page_6.Enabled = false;
                        mSpage_7 = null;
                        btn_page_7.Text = m_NumberProduct.ToString();
                    }





                }*/


            }
            catch (Exception ex)
            {
                Response.Write(" Exception " + ex.ToString());

            }
        }

        public void SwitchPageColor(int i)
        {
            switch (i)
            {
                case 1:
                    btn_page_1.ForeColor = Color.FromArgb(59, 110, 140);
                    btn_page_1.Enabled = false;
                    btn_page_2.ForeColor = Color.White;
                    btn_page_2.Enabled = true;
                    btn_page_3.ForeColor = Color.White;
                    btn_page_3.Enabled = true;
                    btn_page_4.ForeColor = Color.White;
                    btn_page_4.Enabled = true;
                    btn_page_5.ForeColor = Color.White;
                    btn_page_5.Enabled = true;
                    btn_page_6.ForeColor = Color.White;
                    btn_page_6.Enabled = true;
                    btn_page_7.ForeColor = Color.White;
                    btn_page_7.Enabled = true;
                    btn_page_next.Enabled = true;
                    btn_page_previous.Enabled = false;
                    break;
                case 2:
                    btn_page_1.ForeColor = Color.White;
                    btn_page_1.Enabled = true;
                    btn_page_2.ForeColor = Color.FromArgb(59, 110, 140);
                    btn_page_2.Enabled = false;
                    btn_page_3.ForeColor = Color.White;
                    btn_page_3.Enabled = true;
                    btn_page_4.ForeColor = Color.White;
                    btn_page_4.Enabled = true;
                    btn_page_5.ForeColor = Color.White;
                    btn_page_5.Enabled = true;
                    btn_page_6.ForeColor = Color.White;
                    btn_page_6.Enabled = true;
                    btn_page_7.ForeColor = Color.White;
                    btn_page_7.Enabled = true;
                    btn_page_next.Enabled = true;
                    btn_page_previous.Enabled = true;
                    break;
                case 3:
                    btn_page_1.ForeColor = Color.White;
                    btn_page_1.Enabled = true;
                    btn_page_2.ForeColor = Color.White;
                    btn_page_2.Enabled = true;
                    btn_page_3.ForeColor = Color.FromArgb(59, 110, 140);
                    btn_page_3.Enabled = false;
                    btn_page_4.ForeColor = Color.White;
                    btn_page_4.Enabled = true;
                    btn_page_5.ForeColor = Color.White;
                    btn_page_5.Enabled = true;
                    btn_page_6.ForeColor = Color.White;
                    btn_page_6.Enabled = true;
                    btn_page_7.ForeColor = Color.White;
                    btn_page_7.Enabled = true;
                    btn_page_next.Enabled = true;
                    btn_page_previous.Enabled = true;
                    break;
                case 4:
                    btn_page_1.ForeColor = Color.White;
                    btn_page_1.Enabled = true;
                    btn_page_2.ForeColor = Color.White;
                    btn_page_2.Enabled = true;
                    btn_page_3.ForeColor = Color.White;
                    btn_page_3.Enabled = true;
                    btn_page_4.ForeColor = Color.FromArgb(59, 110, 140);
                    btn_page_4.Enabled = false;
                    btn_page_5.ForeColor = Color.White;
                    btn_page_5.Enabled = true;
                    btn_page_6.ForeColor = Color.White;
                    btn_page_6.Enabled = true;
                    btn_page_7.ForeColor = Color.White;
                    btn_page_7.Enabled = true;
                    btn_page_next.Enabled = true;
                    btn_page_previous.Enabled = true;
                    break;
                case 5:
                    btn_page_1.ForeColor = Color.White;
                    btn_page_1.Enabled = true;
                    btn_page_2.ForeColor = Color.White;
                    btn_page_2.Enabled = true;
                    btn_page_3.ForeColor = Color.White;
                    btn_page_3.Enabled = true;
                    btn_page_4.ForeColor = Color.White;
                    btn_page_4.Enabled = true;
                    btn_page_5.ForeColor = Color.FromArgb(59, 110, 140);
                    btn_page_5.Enabled = false;
                    btn_page_6.ForeColor = Color.White;
                    btn_page_6.Enabled = true;
                    btn_page_7.ForeColor = Color.White;
                    btn_page_7.Enabled = true;
                    btn_page_next.Enabled = true;
                    btn_page_previous.Enabled = true;
                    break;
                case 6:
                    btn_page_1.ForeColor = Color.White;
                    btn_page_1.Enabled = true;
                    btn_page_2.ForeColor = Color.White;
                    btn_page_2.Enabled = true;
                    btn_page_3.ForeColor = Color.White;
                    btn_page_3.Enabled = true;
                    btn_page_4.ForeColor = Color.White;
                    btn_page_4.Enabled = true;
                    btn_page_5.ForeColor = Color.White;
                    btn_page_5.Enabled = true;
                    btn_page_6.ForeColor = Color.FromArgb(59, 110, 140);
                    btn_page_6.Enabled = false;
                    btn_page_7.ForeColor = Color.White;
                    btn_page_7.Enabled = true;
                    btn_page_next.Enabled = true;
                    btn_page_previous.Enabled = true;
                    break;
                case 7:
                    btn_page_1.ForeColor = Color.White;
                    btn_page_1.Enabled = true;
                    btn_page_2.ForeColor = Color.White;
                    btn_page_2.Enabled = true;
                    btn_page_3.ForeColor = Color.White;
                    btn_page_3.Enabled = true;
                    btn_page_4.ForeColor = Color.White;
                    btn_page_4.Enabled = true;
                    btn_page_5.ForeColor = Color.White;
                    btn_page_5.Enabled = true;
                    btn_page_6.ForeColor = Color.White;
                    btn_page_6.Enabled = true;
                    btn_page_7.ForeColor = Color.FromArgb(59, 110, 140);
                    btn_page_7.Enabled = false;
                    btn_page_next.Enabled = false;
                    btn_page_previous.Enabled = true;
                    break;

            }
        }
    }
}