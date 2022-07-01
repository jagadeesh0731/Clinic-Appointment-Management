<%@ Page Title="" Language="C#" MasterPageFile="~/doctor.Master" AutoEventWireup="true" CodeBehind="DoctorHomePage.aspx.cs" Inherits="clinicmanagement.DoctorHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
    <asp:Label ID="Label2" runat="server" Text="PATIENT LIST" BackColor="#0000CC" Font-Bold="True" Font-Size="X-Large" ForeColor="White"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
   <asp:GridView ID="GridView1" runat="server"
              AutoGenerateColumns="False" CellPadding="6" OnRowCancelingEdit="GridView1_RowCancelingEdit"
 
OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" Width="1231px">  
            <Columns>  
                <asp:TemplateField>  
                    <ItemTemplate>  
                        <asp:Button ID="btn_Edit" runat="server" Text="Select Appointment" CommandName="Edit" />  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:Button ID="btn_Update" runat="server" Text="Issue Appointment" CommandName="Update" />  
                        <asp:Button ID="btn_Cancel" runat="server" Text="Cancel Appointment" CommandName="Cancel"/>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="AppointmentID">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_AppointmentID" runat="server" Text='<%#Eval("AppointmentID") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField> 
                  <asp:TemplateField HeaderText="PatientID">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_PatientID" runat="server" Text='<%#Eval("PatientID") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField> 
                  <asp:TemplateField HeaderText="DoctorID">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_DoctorID" runat="server" Text='<%#Eval("DoctorID") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="Status">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Status" runat="server" Text='<%#Eval("Status") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Status" runat="server" Text='<%#Eval("Status") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                 <asp:TemplateField HeaderText="AllotedTime">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_AllotedTime" runat="server" Text='<%#Eval("AllotedTime") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_AllotedTime" runat="server" Text='<%#Eval("AllotedTime") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
              
            </Columns>  
            <HeaderStyle BackColor="#663300" ForeColor="#ffffff"/>  
            <RowStyle BackColor="#e7ceb6"/>  
        </asp:GridView>
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
