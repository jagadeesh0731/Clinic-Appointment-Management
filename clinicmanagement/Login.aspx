
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="clinicmanagement.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <style type="text/css">
       
         .auto-style1 {
             background: url(images1/home.jpg);
             height: 749px;
             width: 1592px;
         }
         .auto-style2 {
             position: absolute;
             top: 134px;
             left: 626px;
             z-index: 1;
             width: 190px;
             height: 208px;
         }
         .auto-style3 {
             position: absolute;
             top: 371px;
             left: 668px;
             z-index: 1;
             width: 119px;
             height: 38px;
         }
         .auto-style4 {
             position: absolute;
             top: 439px;
             left: 642px;
             z-index: 1;
             height: 200px;
             width: 171px;
         }
         .auto-style5 {
             position: absolute;
             top: 673px;
             left: 673px;
             z-index: 1;
             width: 112px;
             height: 39px;
             right: 757px;
         }
    </style>
    <title></title>
</head>
<body style="height: 752px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Image ID="Image1" runat="server" CssClass="auto-style2" ImageUrl="~/images1/doctor-stethoscope-clipart-1.jpg" />
            <asp:Button ID="Button1" runat="server" CssClass="auto-style3" OnClick="Button1_Click" Text="DOCTOR" />
            <asp:Image ID="Image2" runat="server" CssClass="auto-style4" ImageUrl="~/images1/Pills_PNG_Clipart-359.png" />
            <asp:Button ID="Button2" runat="server" CssClass="auto-style5" OnClick="Button2_Click" Text="PATIENT" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#0066FF" Text="CLINIC MANAGEMENT SYSTEM"></asp:Label>
        </div>
    </form>
</body>
</html>
