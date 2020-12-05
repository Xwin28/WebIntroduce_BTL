<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDetailProduct.aspx.cs" Inherits="WebIntroduce_BTL.Pages.AddDetailProduct" %>

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
</head>
<body style="background-color: #1b1b1b;">
    <form id="form1" runat="server">
        <div>
            <!-- Header Page -->
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
                    <asp:Label Style="width: auto; margin-right: 10px;" ID="lbl_User" runat="server" Text="😶 Admin" Font-Bold="True" Font-Size="15px" ForeColor="Silver"></asp:Label>
                </div>
            </nav>
            <!-- Contain -->
            <div class="container">
                <nav class="navbar navbar-expand navbar-light border border-secondary rounded" style="background-color: #1b1b1b; margin-bottom: 0px;">
                    <div class="collapse navbar-collapse">
                        <ul class="navbar-nav mr-auto">
                            <li class="nav-item active">
                                <a class="navbar-brand" style="font-size: 20px; color: white; margin-right: 0px" href="#">Creator Dashboard</a>
                                <asp:Label runat="server" Text="&#187; Add Detail Product" ForeColor="White" Font-Size="15px"></asp:Label>
                            </li>
                        </ul>
                    </div>
                </nav>

                <nav class="navbar navbar-expand navbar-light border border-secondary rounded" style="background-color: #111111; margin-bottom: 0px;">
                    <div class="collapse navbar-collapse" id="navbarsExample09">
                        <ul class="navbar-nav mr-auto">
                            <li class="nav-item active" style="float: left;">
                                <asp:Button class="btn btn-outline-secondary waves-effect" ID="btn_Product" runat="server" Text="Product" ForeColor="White" OnClientClick="return false;" BorderColor="Red" Font-Bold="True" />
                                <asp:Button class="btn btn-outline-secondary waves-effect" ID="btn_News" runat="server" Text="📰 News" ForeColor="White" Font-Bold="False" />
                            </li>
                            <li class="nav-item" style="float: right;">
                                <a href="#" style="color: wheat">View Page</a>
                                <asp:Button class="btn btn-danger waves-effect" ID="btn_Save" runat="server" Text="✒ Save" ForeColor="White" Font-Bold="False" />
                            </li>
                        </ul>
                    </div>
                </nav>

                <!-- Basic Infor -->
                <div class="my-3 p-3 rounded box-shadow border border-secondary" style="margin-top: 0px; padding-top: 0px; background-color: #111111;">
                    <h6 class="border-bottom pb-2 mb-0">
                        <asp:Label runat="server" Text="Basic Infor" Font-Size="20px" ForeColor="White"></asp:Label></h6>

                    <div style="margin-top: 20px"><!-- NameProduct -->
                    <asp:Label runat="server"  Text="Name Product" Font-Bold="True" Font-Size="15px" ForeColor="#999999"></asp:Label><br />
                    <asp:TextBox class="form-control input-sm" ID="txt_NameProduct" runat="server" placeholder="Name" BackColor="#111111" ></asp:TextBox>
                    </div>

                    <div style="margin-top: 20px"><!-- Main Icon -->

                    </div>

                    <div style="margin-top: 20px"><!-- Small Icon 1 -->

                    </div>

                    <div style="margin-top: 20px"><!-- Small Icon 2 -->

                    </div>

                    <div style="margin-top: 20px"><!-- Small Icon 3 -->

                    </div>

                </div>


                <!--End Contain-->
            </div>

        </div>
    </form>
</body>
</html>
