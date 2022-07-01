<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexpatient.aspx.cs" Inherits="clinicmanagement.indexpatient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<meta name="viewport" content="width=device-width, initial-scale=1" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content=" Master  Login Form Widget Tab Form,Login Forms,Sign up Forms,Registration Forms,News letter Forms,Elements"/>
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
<link href="//fonts.googleapis.com/css?family=Cormorant+SC:300,400,500,600,700" rel="stylesheet" />
<link href="//fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 546px;
            left: 870px;
            z-index: 1;
            width: 104px;
        }
        .auto-style2 {
            position: absolute;
            top: 546px;
            left: 565px;
            z-index: 1;
            width: 150px;
        }
    </style>
</head>

<body>
	<div class="padding-all">
		<div class="header">
			<h1>Patient Login Form</h1>
		</div>

		<div class="design-w3l">
			<div class="mail-form-agile">
				<form id="form1" runat="server">

					<input type="text" name="name" id="username" runat="server" placeholder="User Name" required=""/>
					<input type="password"  name="password" id="password" runat="server" class="padding" placeholder="Password" required=""/>
                    <button  id="logbtn" style="font-size:larger; background-color: #CCCCFF;" runat="server" onserverclick="logbtn_ServerClick">Submit</button>
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style1" ForeColor="White" NavigateUrl="~/PatientRegistration.aspx">New User?</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink2" runat="server" CssClass="auto-style2" ForeColor="White" NavigateUrl="~/patientforgotpassword.aspx">Forgot Password?</asp:HyperLink>
                </form>
			</div>
		  <div class="clear"> </div>
		</div>
		
		<div class="footer">
	<p>  
            <asp:Label ID="Label1" runat="server"></asp:Label>
            </p>
		</div>
	</div>
    </body>
</html>
