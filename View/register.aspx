<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="XamppTry.View.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Modern Business - Start Bootstrap Template</title>
<!-- Favicon-->
<link rel="icon" type="image/x-icon" href="assets/favicon.ico" />
<!-- Bootstrap icons-->
<link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.5.0/font/bootstrap-icons.css" rel="stylesheet" />
<!-- Core theme CSS (includes Bootstrap)-->
<link href="css/styles.css" rel="stylesheet" />
</head>
<body align="center">
     <form id="contactForm" data-sb-form-api-token="API_TOKEN" runat="server">
     <div class="form-floating">
         <asp:TextBox runat="server" class="form-control" id="name" type="text" placeholder="Enter your name..." data-sb-validations="required" ></asp:TextBox>
         <label for="name">Name</label>
     </div>
         <br />
     <div class="form-floating"> 
         <asp:TextBox runat="server" class="form-control" id="password" type="password" placeholder="Enter your Password..." data-sb-validations="required,email" ></asp:TextBox>
         <label for="password">Password</label>
         
     </div>
         <br />
     <div class="form-floating">
         <asp:TextBox runat="server" class="form-control" id="gender" type="text" placeholder="Enter your Gender..." data-sb-validations="required" ></asp:TextBox>
         <label for="gender">Gender</label>
         
     </div>
            <br /> <asp:Button class="btn btn-primary text-uppercase" id="submit" type="submit" Text="Send" runat="server" OnClick="submit_Click"/>
</form>
</body>
</html>
