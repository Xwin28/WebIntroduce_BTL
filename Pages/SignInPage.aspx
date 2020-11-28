<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignInPage.aspx.cs" Inherits="WebIntroduce_BTL.Pages.SignInPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Sign In</title>

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
    <script src="../Scripts/jquery-3.4.1.slim.js"></script>
    <link href="../Scripts/bootstrap-4.5.3-dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Scripts/CSS/signin.css" rel="stylesheet" />
</head>
<body class="text-center">
    
    <form id="form1" class="form-signin" runat="server">
        <div>
        <img class="mb-4" src="../Resources/IconSignIn.png" alt="" width="72" height="72" />
        <h1 class="h3 mb-3 font-weight-normal">Please Login</h1>


    <label for="inputEmail" class="sr-only">User Name or Email address</label>
    <input type="text" id="txt_Email" runat="server"  class="form-control" placeholder="User Name or Email address" required="required"/>

    <label for="inputPassword" class="sr-only">Password</label>
    <input type="password" id="txt_Password" runat="server" class="form-control" placeholder="Password" required="required"/>
      

            
            <div class="alert alert-danger" role="alert"<%=_WrongUser %>  >
        Invalid email address or password! </div>
  
    <div class="checkbox mb-3">
    <label>
        <asp:CheckBox ID="Check_Remember" runat="server" Text="&nbsp  Remember me" Font-Size="12pt"  />
        
    </label>
  </div>
<asp:Button class="btn btn-lg btn-primary btn-block" ID="btn_Login" runat="server" Text="Log In" OnClick="btn_Login_Click" />

  <p class="mt-5 mb-3 text-muted">&copy; 2017-2020</p>

        </div>
    </form>
</body>
</html>