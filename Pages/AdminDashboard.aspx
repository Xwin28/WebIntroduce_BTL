<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="WebIntroduce_BTL.Pages.AdminDashboard" %>

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
    </style>
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <script src="../Scripts/bootstrap-4.5.3-dist/js/bootstrap.min.js"></script>
    <link href="../Scripts/CSS/navbar.css" rel="stylesheet" />
    <link href="../Scripts/bootstrap-4.5.3-dist/css/bootstrap.min.css" rel="stylesheet" />
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
                <div>
                    <ul class="navbar-nav mr-auto" style="float: right">
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="#" id="dropdown03" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">User</a>
                            <div class="dropdown-menu" aria-labelledby="dropdown03">
                                <a class="dropdown-item" href="#">Action</a>
                                <a class="dropdown-item" href="#">Another action</a>
                                <a class="dropdown-item" href="#">Something else here</a>
                            </div>
                        </li>
                    </ul>
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
                                <asp:Button class="btn btn-outline-secondary waves-effect" ID="btn_Product" runat="server" Text="Product" ForeColor="White" OnClientClick="return false;" />
                                <asp:Button class="btn btn-outline-secondary waves-effect" ID="btn_Analysis" runat="server" Text="Analytics" ForeColor="White" />
                            </li>
                        </ul>
                    </div>
                </nav>
                <nav class="container border border-secondary" style="background-color: #111111; height: 800px;">
                    <div class="row">

                        <div class="col-sm" style="padding-left: 30px;">
                            <p style="margin-top: 10px;">
                                <asp:Label ID="lbl_Title" runat="server" Text="Products Pages" Font-Size="20px" ForeColor="White" Font-Bold="True"></asp:Label></p>

                            <div class="media text-muted border border-secondary" style="margin-top: 20px">
                                <img style="width: 150px; height: 100px;" src="../Resources/instagram_3.jpg" />
                                <div class="media-body" style="margin-top: 15px; margin-right: 10px; margin-left: 5px;">
                                    <asp:Label ID="lbl_ProductName_1" runat="server" Text="Product Name" Font-Bold="True" Font-Size="18px" ForeColor="White" Style="padding-left: 7px"></asp:Label>
                                    <asp:Label Style="float: right; padding-right: 5px; padding-left: 5px;" ID="Label1" runat="server" Text="Draft" BackColor="#c3745f" Font-Bold="True" ForeColor="White" />
                                    <ul class="navbar-nav mr-auto">
                                        <li class="nav-item active" style="background-color: #1b1b1b; padding-left: 7px; margin-top: 20px;">
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Edit" runat="server" Text="Edit" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_News" runat="server" Text="News" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Analytics" runat="server" Text="Analytics" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                            <asp:Button Style="padding-left: 2px; padding-right: 2px;" class="btn" ID="btn_Deleta" runat="server" Text="Delete" ForeColor="White" OnClientClick="return false;" Font-Size="13px" Font-Underline="True" />
                                        </li>
                                    </ul>
                                </div>
                            </div>

                        </div>


                        <div class="col-sm" style="padding-right: 30px;">

                            <p style="margin-top: 10px;">
                                <asp:Label ID="Label10" runat="server" Text="Static Pages" Font-Size="20px" ForeColor="White" Font-Bold="True"></asp:Label></p>

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


                        </div>


                    </div>
                </nav>




            </div>

        </div>
    </form>
</body>
</html>
