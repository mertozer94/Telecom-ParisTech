<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" />
    <div style="display: flex;
  justify-content: center;">
        <asp:UpdatePanel runat="server" id="UpdatePanel" updatemode="Conditional">
            <ContentTemplate>
                 <asp:Label ID="Label2" runat="server" Text="Cevirmek istediginiz euro miktarini giriniz."></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                
                
                <asp:Button runat="server" id="UpdateButton1" onclick="UpdateButton_Click" text="Update" />               
                <br />
                <asp:Label runat="server" id="DateTimeLabel1" />
                <asp:Label ID="Label1" runat="server"></asp:Label>

                 <br />

                 <br />

            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    
    
    



   
        




        </asp:Content>

        
