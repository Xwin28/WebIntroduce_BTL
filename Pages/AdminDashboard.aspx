<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="WebIntroduce_BTL.Pages.AdminDashboard" MaintainScrollPositionOnPostback="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }

        @media (min-width: 768px) {
            .bd-placeholder-img-lg {
                font-size: 3.5rem;
            }
        }


        .btn-lightbtn {
            position: fixed;
            top: auto;
            left: auto;
            right: 15px;
            bottom: 15px;
            font-size: 15px;
            opacity: 0.8;
            z-index: 9999;
            cursor: pointer;
        }

            .btn-lightbtn:hover {
                opacity: 1;
            }
    </style>
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <script src="../Scripts/bootstrap-4.5.3-dist/js/bootstrap.min.js"></script>
    <link href="../Scripts/CSS/navbar.css" rel="stylesheet" />
    <link href="../Scripts/bootstrap-4.5.3-dist/css/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript">
        function toTop() {
            window.scrollTo({
                top: 0,
                left: 0,
                behavior: "smooth"
            });
            //alert("Thank you for visiting W3Schools!");
        }

        function btn_Page_1() {
            toTop();
            setTimeout(() => { document.getElementById('btn_page_1').click() }, 200);
        }
        function btn_Page_2() {
            toTop();
            setTimeout(() => { document.getElementById('btn_page_2').click() }, 200);
        }
        function btn_Page_3() {
            toTop();
            setTimeout(() => { document.getElementById('btn_page_3').click() }, 200);
        }
        function btn_Page_4() {
            toTop();
            setTimeout(() => { document.getElementById('btn_page_4').click() }, 200);
        }
        function btn_Page_5() {
            toTop();
            setTimeout(() => { document.getElementById('btn_page_5').click() }, 200);
        }
        function btn_Page_6() {
            toTop();
            setTimeout(() => { document.getElementById('btn_page_6').click() }, 200);
        }
        function btn_Page_7() {
            toTop();
            setTimeout(() => { document.getElementById('btn_page_7').click() }, 200);
        }
        function btn_Page_pre() {
            toTop();
            setTimeout(() => { document.getElementById('btn_page_previous').click() }, 200);
        }
        function btn_Page_next() {
            toTop();
            setTimeout(() => { document.getElementById('btn_page_next').click() }, 200);
        }

    </script>
</head>
<body style="background-color: #1b1b1b;">
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-expand navbar-dark" style="background-color: #111111;">
                <asp:ImageButton ID="img_icon" runat="server" ImageUrl="~/Resources/IconSignIn.png" Width="36" Height="36" />
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExample02" aria-controls="navbarsExample02" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="navbarsExample02">
                    <ul class="navbar-nav mr-auto">
                        <li class="nav-item active">
                            <a class="navbar-brand" style="font-size: 30px" href="#">&nbsp;&nbsp; Home <span class="sr-only">(current)</span></a>
                        </li>
                    </ul>
                </div>
                    <div class="navbar-nav mr-auto" style="float: right">
                        <asp:Label style="width:auto; margin-right:10px;" ID="lbl_User" runat="server" Text="😶 Admin" Font-Bold="True" Font-Size="15px" ForeColor="Silver"></asp:Label>
                    </div>
            </nav>




            <div class="container">
                <nav class="navbar navbar-expand navbar-light border border-secondary rounded" style="background-color: #111111; margin-bottom: 0px;">
                    <div class="collapse navbar-collapse">
                        <ul class="navbar-nav mr-auto">
                            <li class="nav-item active">
                                <a class="navbar-brand" style="font-size: 25px; color: white;">Creator Dashboard<span class="sr-only">(current)</span></a>
                            </li>
                        </ul>
                    </div>
                    <div>
                        <ul class="navbar-nav mr-auto" style="float: right; text-align: center;">
                            <li>
                                <div style="margin-right: 50px;">
                                    <asp:Label ID="lbl_view" runat="server" Text="4" ForeColor="White" Font-Size="15pt" Font-Bold="true"></asp:Label><br />
                                    <asp:Label ID="Label2" runat="server" Text="Views" ForeColor="White" Font-Size="8pt"></asp:Label>
                                </div>
                            </li>
                            <li>
                                <div style="margin-right: 25px;">
                                    <asp:Label ID="lbl_interaction" runat="server" Text="1" ForeColor="White" Font-Size="15pt" Font-Bold="true"></asp:Label><br />
                                    <asp:Label ID="Label4" runat="server" Text="Interact" ForeColor="White" Font-Size="8pt"></asp:Label>
                                </div>
                            </li>
                        </ul>
                    </div>
                </nav>

                <nav class="navbar navbar-expand navbar-light border border-secondary rounded" style="background-color: #1b1b1b; margin-bottom: 0px;">
                    <div class="collapse navbar-collapse" id="navbarsExample09">
                        <ul class="navbar-nav mr-auto">
                            <li class="nav-item active">
                                <asp:Button class="btn btn-outline-secondary waves-effect" ID="btn_Product" runat="server" Text="Product" ForeColor="White" OnClientClick="return false;" BorderColor="Red" Font-Bold="True" />
                                <asp:Button class="btn btn-outline-secondary waves-effect" ID="btn_Analysis" runat="server" Text="Analytics" ForeColor="White" />
                            </li>
                        </ul>
                    </div>
                </nav>

                <nav class="container border border-secondary" style="background-color: #111111; height: auto; margin-bottom: 10px;">
                    <div class="row">
                        <!--. Column Products..-->
                        <div class="col-sm" style="padding-left: 30px; margin-bottom:50px">
                            <p style="margin-top: 10px;">
                                <asp:Label ID="lbl_Title" runat="server" Text="Products Pages" Font-Size="20px" ForeColor="White" Font-Bold="True"></asp:Label>
                                <asp:DropDownList class="btn btn-danger btn-sm dropdown-toggle dropdown-toggle-split" ID="DropSort" runat="server" Style="float: right" Font-Bold="True" Font-Size="15px" AutoPostBack="True" OnSelectedIndexChanged="DropSort_SelectedIndexChanged">
                                    <asp:ListItem>New to Old</asp:ListItem>
                                    <asp:ListItem>Old to New</asp:ListItem>
                                </asp:DropDownList>
                            </p>

                            <div class="media text-muted border border-secondary" <%=m_SProduct_1 %>>
                                <img style="width: 150px; height: 100px;" src="../Resources/instagram_3.jpg" />
                                <div class="media-body" style="margin-top: 15px; margin-right: 10px; margin-left: 5px;">
                                    <asp:Label ID="lbl_ProductName_1" runat="server" Text="Product Name" Font-Bold="True" Font-Size="18px" ForeColor="White" Style="padding-left: 7px"></asp:Label>
                                    <asp:Label Style="float: right; padding-right: 5px; padding-left: 5px;" ID="Label1" runat="server" Text="Draft" BackColor="#c3745f" Font-Bold="True" ForeColor="White" />
                                    <ul class="navbar-nav mr-auto">
                                        <li class="nav-item active" style="background-color: #1b1b1b; padding-left: 7px; margin-top: 20px;">
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Edit_1" runat="server" Text="Edit" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_News_1" runat="server" Text="News" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Analytics_1" runat="server" Text="Analytics" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Deleta_1" runat="server" Text="Delete" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                        </li>
                                    </ul>
                                </div>
                            </div>

                            <div class="media text-muted border border-secondary" <%=m_SProduct_2 %>>
                                <img style="width: 150px; height: 100px;" src="../Resources/instagram_3.jpg" />
                                <div class="media-body" style="margin-top: 15px; margin-right: 10px; margin-left: 5px;">
                                    <asp:Label ID="lbl_ProductName_2" runat="server" Text="Product Name" Font-Bold="True" Font-Size="18px" ForeColor="White" Style="padding-left: 7px"></asp:Label>
                                    <asp:Label Style="float: right; padding-right: 5px; padding-left: 5px;" ID="Label12" runat="server" Text="Draft" BackColor="#c3745f" Font-Bold="True" ForeColor="White" />
                                    <ul class="navbar-nav mr-auto">
                                        <li class="nav-item active" style="background-color: #1b1b1b; padding-left: 7px; margin-top: 20px;">
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Edit_2" runat="server" Text="Edit" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_News_2" runat="server" Text="News" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Analytics_2" runat="server" Text="Analytics" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Deleta_2" runat="server" Text="Delete" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                        </li>
                                    </ul>
                                </div>
                            </div>

                            <div class="media text-muted border border-secondary" <%=m_SProduct_3 %>>
                                <img style="width: 150px; height: 100px;" src="../Resources/instagram_3.jpg" />
                                <div class="media-body" style="margin-top: 15px; margin-right: 10px; margin-left: 5px;">
                                    <asp:Label ID="lbl_ProductName_3" runat="server" Text="Product Name" Font-Bold="True" Font-Size="18px" ForeColor="White" Style="padding-left: 7px"></asp:Label>
                                    <asp:Label Style="float: right; padding-right: 5px; padding-left: 5px;" ID="Label14" runat="server" Text="Draft" BackColor="#c3745f" Font-Bold="True" ForeColor="White" />
                                    <ul class="navbar-nav mr-auto">
                                        <li class="nav-item active" style="background-color: #1b1b1b; padding-left: 7px; margin-top: 20px;">
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Edit_3" runat="server" Text="Edit" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_News_3" runat="server" Text="News" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Analytics_3" runat="server" Text="Analytics" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Deleta_3" runat="server" Text="Delete" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                        </li>
                                    </ul>
                                </div>
                            </div>

                            <div class="media text-muted border border-secondary" <%=m_SProduct_4 %>>
                                <img style="width: 150px; height: 100px;" src="../Resources/instagram_3.jpg" />
                                <div class="media-body" style="margin-top: 15px; margin-right: 10px; margin-left: 5px;">
                                    <asp:Label ID="lbl_ProductName_4" runat="server" Text="Product Name" Font-Bold="True" Font-Size="18px" ForeColor="White" Style="padding-left: 7px"></asp:Label>
                                    <asp:Label Style="float: right; padding-right: 5px; padding-left: 5px;" ID="Label16" runat="server" Text="Draft" BackColor="#c3745f" Font-Bold="True" ForeColor="White" />
                                    <ul class="navbar-nav mr-auto">
                                        <li class="nav-item active" style="background-color: #1b1b1b; padding-left: 7px; margin-top: 20px;">
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Edit_4" runat="server" Text="Edit" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_News_4" runat="server" Text="News" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Analytics_4" runat="server" Text="Analytics" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Deleta_4" runat="server" Text="Delete" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                        </li>
                                    </ul>
                                </div>
                            </div>

                            <div class="media text-muted border border-secondary" <%=m_SProduct_5 %>>
                                <img style="width: 150px; height: 100px;" src="../Resources/instagram_3.jpg" />
                                <div class="media-body" style="margin-top: 15px; margin-right: 10px; margin-left: 5px;">
                                    <asp:Label ID="lbl_ProductName_5" runat="server" Text="Product Name" Font-Bold="True" Font-Size="18px" ForeColor="White" Style="padding-left: 7px"></asp:Label>
                                    <asp:Label Style="float: right; padding-right: 5px; padding-left: 5px;" ID="Label18" runat="server" Text="Draft" BackColor="#c3745f" Font-Bold="True" ForeColor="White" />
                                    <ul class="navbar-nav mr-auto">
                                        <li class="nav-item active" style="background-color: #1b1b1b; padding-left: 7px; margin-top: 20px;">
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Edit_5" runat="server" Text="Edit" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_News_5" runat="server" Text="News" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Analytics_5" runat="server" Text="Analytics" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Deleta_5" runat="server" Text="Delete" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                        </li>
                                    </ul>
                                </div>
                            </div>

                            <!-- to Top Button  -->
                            <button onclick="toTop(); return false" id="backtotop" class="btn btn-lightbtn btn-secondary btn-sm">^</button>

                            <nav aria-label="Search results pages" style="margin-top: 10px;">
                                <asp:Button class="btn " ID="btn_CreateNew" runat="server" Style="float: left" Text="New Product" OnClientClick="return false" BackColor="#FF2449" Font-Bold="True" ForeColor="White" />
                                <ul class="pagination pagination-sms justify-content-end">
                                    <li class="page-item" <%=mSpagePre %>>
                                        <a <%=mDis_pre%> onclick="btn_Page_pre();" href="javascript:void('0');" class="page-link border-0">
                                            <asp:Label ID="lbl_page_pre" runat="server" Text="Previous" ForeColor="White"></asp:Label></a>
                                        <asp:Button CausesValidation="False" class="page-link border-0" Style="background-color: #111111; display: none;" ID="btn_page_previous" runat="server" Text="Previous" ForeColor="White" BorderStyle="None" EnableViewState="False" OnClick="btn_page_previous_Click" />
                                    </li>
                                    <li class="page-item" <%=mSpage_1 %>>
                                        <a <%=mDis_1 %> onclick="btn_Page_1()" href="javascript:void('0');" class="page-link border-0">
                                            <asp:Label ID="lbl_page_1" runat="server" Text="1" ForeColor="White"></asp:Label></a>
                                        <asp:Button class="page-link border-0" Style="background-color: #111111; display: none;" ID="btn_page_1" runat="server" Text="1" ForeColor="White" BorderStyle="None" EnableViewState="False" OnClick="btn_page_1_Click" />
                                    </li>
                                    <li class="page-item" <%=mSpage_2 %>>
                                        <a <%=mDis_2 %> onclick="btn_Page_2()" href="javascript:void('0');" class="page-link border-0">
                                            <asp:Label ID="lbl_page_2" runat="server" Text="..." ForeColor="White"></asp:Label></a>
                                        <asp:Button class="page-link border-0" Style="background-color: #111111; display: none;" ID="btn_page_2" runat="server" Text="..." ForeColor="White" BorderStyle="None" EnableViewState="False" OnClick="btn_page_2_Click" />
                                    </li>
                                    <li class="page-item" <%=mSpage_3 %>>
                                        <a <%=mDis_3 %> onclick="btn_Page_3()" href="javascript:void('0');" class="page-link border-0">
                                            <asp:Label ID="lbl_page_3" runat="server" Text="3" ForeColor="White"></asp:Label></a>
                                        <asp:Button class="page-link border-0" Style="background-color: #111111; display: none;" ID="btn_page_3" runat="server" Text="3" ForeColor="White" BorderStyle="None" EnableViewState="False" OnClick="btn_page_3_Click" />
                                    </li>
                                    <li class="page-item" <%=mSpage_4 %>>
                                        <a <%=mDis_4 %> onclick="btn_Page_4()" href="javascript:void('0');" class="page-link border-0">
                                            <asp:Label ID="lbl_page_4" runat="server" Text="4" ForeColor="White"></asp:Label></a>
                                        <asp:Button class="page-link border-0" Style="background-color: #111111; display: none;" ID="btn_page_4" runat="server" Text="4" ForeColor="White" BorderStyle="None" EnableViewState="False" OnClick="btn_page_4_Click" />
                                    </li>
                                    <li class="page-item" <%=mSpage_5 %>>
                                        <a <%=mDis_5 %> onclick="btn_Page_5()" href="javascript:void('0');" class="page-link border-0">
                                            <asp:Label ID="lbl_page_5" runat="server" Text="5" ForeColor="White"></asp:Label></a>
                                        <asp:Button class="page-link border-0" Style="background-color: #111111; display: none;" ID="btn_page_5" runat="server" Text="5" ForeColor="White" BorderStyle="None" EnableViewState="False" OnClick="btn_page_5_Click" />
                                    </li>
                                    <li class="page-item" <%=mSpage_6 %>>
                                        <a <%=mDis_6 %> onclick="btn_Page_6()" href="javascript:void('0');" class="page-link border-0">
                                            <asp:Label ID="lbl_page_6" runat="server" Text="..." ForeColor="White"></asp:Label></a>
                                        <asp:Button class="page-link border-0" Style="background-color: #111111; display: none;" ID="btn_page_6" runat="server" Text="..." ForeColor="White" BorderStyle="None" EnableViewState="False" OnClick="btn_page_6_Click" />
                                    </li>
                                    <li class="page-item" <%=mSpage_7 %>>
                                        <a <%=mDis_7%> onclick="btn_Page_7()" href="javascript:void('0');" class="page-link border-0">
                                            <asp:Label ID="lbl_page_7" runat="server" Text="7" ForeColor="White"></asp:Label></a>
                                        <asp:Button class="page-link border-0" Style="background-color: #111111; display: none;" ID="btn_page_7" runat="server" Text="7" ForeColor="White" BorderStyle="None" EnableViewState="False" OnClick="btn_page_7_Click" />
                                    </li>
                                    <li class="page-item" <%=mSpageNext %>>
                                        <a <%=mDis_next%> onclick="btn_Page_next()" href="javascript:void('0');" class="page-link border-0">
                                            <asp:Label ID="lbl_page_next" runat="server" Text="Next" ForeColor="White"></asp:Label></a>
                                        <asp:Button class="page-link border-0" Style="background-color: #111111; display: none;" ID="btn_page_next" runat="server" Text="Next" ForeColor="White" BorderStyle="None" EnableViewState="False" OnClick="btn_page_next_Click" />
                                    </li>
                                </ul>
                            </nav>

                        </div>

                        <!-- Column Pages  -->
                        <div class="col-sm" style="padding-right: 30px; margin-bottom:50px">

                            <p style="margin-top: 10px;">
                                <asp:Label ID="Label10" runat="server" Text="Static Pages" Font-Size="20px" ForeColor="White" Font-Bold="True"></asp:Label>
                            </p>

                            <div class="media text-muted border border-secondary" style="margin-top: 20px">
                                <img style="width: 150px; height: 100px;" src="../Resources/instagram_3.jpg" />
                                <div class="media-body" style="margin-top: 15px; margin-right: 10px; margin-left: 5px;">
                                    <asp:Label ID="Label3" runat="server" Text="Home Page" Font-Bold="True" Font-Size="18px" ForeColor="White" Style="padding-left: 7px"></asp:Label>
                                    <asp:Label Style="float: right; padding-right: 5px; padding-left: 5px;" ID="Label5" runat="server" Text="Published" BackColor="#73A14A" Font-Bold="True" ForeColor="White" />
                                    <ul class="navbar-nav mr-auto">
                                        <li class="nav-item active" style="background-color: #1b1b1b; padding-left: 7px; margin-top: 20px;">
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="Button1" runat="server" Text="Edit" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="Button3" runat="server" Text="Analytics" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                        </li>
                                    </ul>
                                </div>
                            </div>

                            <div class="media text-muted border border-secondary" style="margin-top: 20px">
                                <img style="width: 150px; height: 100px;" src="../Resources/106_83.png" />
                                <div class="media-body" style="margin-top: 15px; margin-right: 10px; margin-left: 5px;">
                                    <asp:Label ID="Label6" runat="server" Text="All News Page" Font-Bold="True" Font-Size="18px" ForeColor="White" Style="padding-left: 7px"></asp:Label>
                                    <asp:Label Style="float: right; padding-right: 5px; padding-left: 5px;" ID="Label7" runat="server" Text="Published" BackColor="#73A14A" Font-Bold="True" ForeColor="White" />
                                    <ul class="navbar-nav mr-auto">
                                        <li class="nav-item active" style="background-color: #1b1b1b; padding-left: 7px; margin-top: 20px;">
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="Button5" runat="server" Text="Edit" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="Button7" runat="server" Text="Analytics" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                        </li>
                                    </ul>
                                </div>
                            </div>

                            <div class="media text-muted border border-secondary" style="margin-top: 20px">
                                <img style="width: 150px; height: 100px;" src="../Resources/instagram_3.jpg" />
                                <div class="media-body" style="margin-top: 15px; margin-right: 10px; margin-left: 5px;">
                                    <asp:Label ID="Label8" runat="server" Text="All Products Page" Font-Bold="True" Font-Size="18px" ForeColor="White" Style="padding-left: 7px"></asp:Label>
                                    <asp:Label Style="float: right; padding-right: 5px; padding-left: 5px;" ID="Label9" runat="server" Text="Published" BackColor="#73A14A" Font-Bold="True" ForeColor="White" />
                                    <ul class="navbar-nav mr-auto">
                                        <li class="nav-item active" style="background-color: #1b1b1b; padding-left: 7px; margin-top: 20px;">
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="Button9" runat="server" Text="Edit" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="Button11" runat="server" Text="Analytics" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                        </li>
                                    </ul>
                                </div>
                            </div>

                            <p style="margin-top: 10px;">
                                <asp:Label runat="server" Text="Summary" Font-Size="20px" ForeColor="White" Font-Bold="True"></asp:Label>
                                <a href="SignInPage.aspx" style="font-size: 13px; color:darkgray" rel="follow, index">&nbsp; View more &#8594;</a>
                            </p>
                        </div>


                    </div>
                </nav>




            </div>



            <!-- Copyright -->
            <div class="footer-copyright text-center py-3">
                <asp:Label ID="Label11" runat="server" Text="Copyright &#169; by Xwin28" Font-Size="13" ForeColor="#999999"></asp:Label>
            </div>
            <!-- Copyright -->
        </div>
    </form>
</body>
</html>
