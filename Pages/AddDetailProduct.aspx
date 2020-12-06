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
    <script src="../Scripts/jquery-3.5.1.min.js"></script>
    <script src="../Scripts/bootstrap-4.5.3-dist/js/bootstrap.bundle.min.js"></script>
    <script src="../Scripts/bootstrap-4.5.3-dist/js/bootstrap.min.js"></script>
    <link href="../Scripts/CSS/navbar.css" rel="stylesheet" />
    <link href="../Scripts/bootstrap-4.5.3-dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Scripts/CSS/UploadForm.css" rel="stylesheet" />
</head>
<body style="background-color: #1b1b1b;">
    <form id="form1" runat="server">
        <div>
            <!-- Header Page -->
            <nav class="navbar navbar-expand navbar-dark" style="background-color: #111111; margin-top: 0px">
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
            <div class="container-fluid pl-5 pr-5">
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
                            <li class="nav-item active">
                                <asp:Button class="btn btn-outline-secondary waves-effect" ID="btn_Product" runat="server" Text="Product" ForeColor="White" OnClientClick="return false;" BorderColor="Red" Font-Bold="True" />
                                <asp:Button class="btn btn-outline-secondary waves-effect" ID="btn_News" runat="server" Text="📰 News" ForeColor="White" Font-Bold="False" />
                            </li>
                        </ul>
                        <div class="nav-item" style="float: right;">
                            <a href="#" style="color: wheat; font-size: 13px">View Page &nbsp;</a>
                            <asp:Button class="btn btn-danger waves-effect" ID="btn_Save" runat="server" Text="✒ Save" ForeColor="White" Font-Bold="False" Font-Size="13px" />
                        </div>

                    </div>
                </nav>

                <!-- Basic Infor -->

                <div class="row rounded box-shadow border border-secondary" style="margin: 0px; padding-top: 0px; background-color: #111111;">
                    <!-- cot 1 -->
                    <div class="col-sm " style="margin-bottom: 20px">
                        <div class="container">
                            <div class="my-3 pt-3 pl-3 pr-3  " style="margin-top: 0px; padding-top: 0px;">
                                <h6 class="border-bottom pb-2 mb-0">
                                    <asp:Label runat="server" Text="Basic Infor" Font-Size="20px" ForeColor="Gold"></asp:Label></h6>

                                <div style="margin-top: 20px;">
                                    <!-- NameProduct -->
                                    <asp:Label runat="server" Text="Name Product" Font-Bold="True" Font-Size="15px" ForeColor="#999999"></asp:Label><br />
                                    <asp:TextBox class="form-control input-sm" ID="txt_NameProduct" runat="server" placeholder="Name" BackColor="#111111" ForeColor="White"></asp:TextBox>
                                </div>
                            </div>

                            <!-- ICON FLATFORM ROW 1-->
                            <div class="row my-3 pb-3 pl-3 pr-3">
                                <div class="col-sm">
                                    <!-- Icon platform 1-->
                                    <asp:Label runat="server" Text="Icon Platform 1 (18x15 px)" Font-Bold="True" Font-Size="15px" ForeColor="#999999"></asp:Label><br />
                                    <asp:FileUpload class="btn btn-secondary btn-sm" ID="upload_IconPlatform_1" runat="server" ForeColor="White" Visible="true" />
                                    <asp:Image CssClass="icon18_15" ID="img_IconPlatform_1" runat="server" ImageUrl="~/Resources/IconProduct.png" />
                                </div>
                                <div class="col-sm">
                                    <!-- Icon platform 2-->
                                    <asp:Label runat="server" Text="Icon Platform 2 (18x15 px)" Font-Bold="True" Font-Size="15px" ForeColor="#999999"></asp:Label><br />
                                    <asp:FileUpload class="btn btn-secondary btn-sm" ID="upload_IconPlatform_2" runat="server" ForeColor="White" Visible="true" />
                                    <asp:Image CssClass="icon18_15" ID="img_IconPlatform_2" runat="server" ImageUrl="~/Resources/IconProduct.png" />

                                </div>
                            </div>
                            <!-- ICON FLATFORM ROW 2-->
                            <div class="row my-3 pb-3 pl-3 pr-3">
                                <div class="col-sm">
                                    <!-- Icon platform 3-->
                                    <asp:Label runat="server" Text="Icon Platform 3 (18x15 px)" Font-Bold="True" Font-Size="15px" ForeColor="#999999"></asp:Label><br />
                                    <asp:FileUpload class="btn btn-secondary btn-sm" ID="upload_IconPlatform_3" runat="server" ForeColor="White" Visible="true" />
                                    <asp:Image CssClass="icon18_15" ID="img_IconPlatform_3" runat="server" ImageUrl="~/Resources/IconProduct.png" />
                                </div>
                                <div class="col-sm">
                                    <!-- Icon platform 4-->
                                    <asp:Label runat="server" Text="Icon Platform 4 (18x15 px)" Font-Bold="True" Font-Size="15px" ForeColor="#999999"></asp:Label><br />
                                    <asp:FileUpload class="btn btn-secondary btn-sm" ID="upload_IconPlatform_4" runat="server" ForeColor="White" Visible="true" />
                                    <asp:Image CssClass="icon18_15" ID="img_IconPlatform_4" runat="server" ImageUrl="~/Resources/IconProduct.png" />
                                </div>
                            </div>
                        </div>

                        <!-- end col 1-->

                    </div>
                    <!-- cot 2 -->
                    <div class="col-sm" style="margin-bottom: 50px; margin-top: 65px;">
                        <div class="container">
                            <div style="margin-top: 20px">
                                <!-- File upload ROW -->
                                <div class="row">
                                    <!-- cot hinh 1-->
                                    <div class="col-sm">
                                        <!-- Name -->
                                        <asp:Label runat="server" Text="Icon Product (560x700 px) or ratio (4/5) " Font-Bold="True" Font-Size="15px" ForeColor="#999999"></asp:Label><br />
                                        <asp:FileUpload class="btn btn-secondary btn-sm" ID="upload_IconProduct" runat="server" ForeColor="White" Visible="true" />
                                        <div style="padding-top: 10px; margin-bottom: 20px;">
                                            <asp:Image CssClass="icon4_5" ID="img_IconProduct" runat="server" ImageUrl="~/Resources/IconProduct.png" />
                                        </div>
                                    </div>
                                    <!-- cot hinh 2-->
                                    <div class="col-sm">
                                        <!-- Name -->
                                        <asp:Label runat="server" Text="Icon Edit Product (150x100 px) or ratio (3/2) " Font-Bold="True" Font-Size="15px" ForeColor="#999999"></asp:Label><br />
                                        <asp:FileUpload class="btn btn-secondary btn-sm" ID="upload_IconEditProduct" runat="server" ForeColor="White" Visible="true" />
                                        <div style="padding-top: 10px; margin-bottom: 20px;">
                                            <asp:Image CssClass="icon3_2" ID="img_IconEditProduct" runat="server" ImageUrl="~/Resources/IconProduct.png" />
                                        </div>

                                    </div>
                                </div>

                                <!-- end col 2-->
                            </div>
                            <!-- End Row-->
                        </div>

                        <!--End Contain-->


                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
