<%@ Page Title="" Language="C#" MasterPageFile="~/clinicmanagement.Master" AutoEventWireup="true" CodeBehind="PatientAppointmentDetail.aspx.cs" Inherits="clinicmanagement.PatientAppointmentDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style5 {
        position: absolute;
        top: 404px;
        left: 646px;
        z-index: 1;
    }
    .auto-style6 {
        height: 11px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label2" runat="server" Text="APPOINTMENT LIST" CssClass="auto-style5" Font-Bold="True" Font-Size="X-Large"></asp:Label>
</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound"  OnRowDeleting="GridView1_RowDeleting"  Width="1219px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            
             <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
              <Columns>  

                <asp:TemplateField>  
                    <ItemTemplate>  
                        <asp:Button ID="btn_Edit" runat="server" Text="Cancel Appointment" CommandName="Delete"  width="155px"/>  
                    </ItemTemplate>  
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
                        <asp:Label ID="lbl_Status" runat="server" Text='<%#Eval("Status") %>' ></asp:Label>  
                    </ItemTemplate>  
                    
                </asp:TemplateField>  
                 <asp:TemplateField HeaderText="AllotedTime">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_AllotedTime" runat="server" Text='<%#Eval("AllotedTime") %>'></asp:Label>  
                    </ItemTemplate>  
                     
                </asp:TemplateField>  
              
            </Columns>  
            <HeaderStyle BackColor="#663300" ForeColor="#ffffff"/>  
            <RowStyle BackColor="#e7ceb6"/>  
        </asp:GridView>
</p>
    <p>
    <br />
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
<p class="auto-style6">
</p>
</asp:Content>
