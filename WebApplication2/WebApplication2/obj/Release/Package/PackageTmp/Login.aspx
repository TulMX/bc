<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="WebApplication2.Login" %>

<!DOCTYPE html>
<link rel="stylesheet" href="Content/bootstrap.min.css" />
<%--<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.min.js" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.slim.min.js" />
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.2/css/all.css" />--%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
    <div class="row">
      <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
        <div class="card card-signin my-5">
          <div class="card-body">
            <h5 class="card-title text-center">Ingreso al Sistema</h5>
                
              <div class="form-label-group">
                <input runat="server" type="text" id="inputEmail" class="form-control" placeholder="Email address" required autofocus/>
                <label for="inputEmail">Email address</label>
              </div>

              <div class="form-label-group">
                <input runat="server" type="password" id="inputPassword" class="form-control" placeholder="Password" required/>
                <label for="inputPassword">Password</label>
              </div>

              <div class="custom-control custom-checkbox mb-3">
                <input type="checkbox" class="custom-control-input" id="customCheck1"/>
                <label class="custom-control-label" for="customCheck1">Remember password<//label>
              </div>
              <asp:Button runat="server" ID="b1" class="btn btn-lg btn-primary btn-block text-uppercase" type="submit"  OnClick="click" Text="Sign In"></asp:Button>
              <hr class="my-4"/>
              <button class="btn btn-lg btn-google btn-block text-uppercase" onclick="click()" type="submit"><i class="fab fa-google mr-2"></i> Sign in with Google</button>
              <button class="btn btn-lg btn-facebook btn-block text-uppercase" onclick="click()" type="submit"><i class="fab fa-facebook-f mr-2"></i> Sign in with Facebook</button>
          </div>
        </div>
      </div>
    </div>
   </div>
    </form>
</body>
</html>
