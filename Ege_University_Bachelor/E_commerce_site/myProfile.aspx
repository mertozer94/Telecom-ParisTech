<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="myProfile.aspx.cs" Inherits="myProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
 
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display.">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="True" SortExpression="ProductID" />
            <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
            <asp:BoundField DataField="ProductDescription" HeaderText="ProductDescription" SortExpression="ProductDescription" />
            <asp:BoundField DataField="SupplierID" HeaderText="SupplierID" SortExpression="SupplierID" />
            <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" SortExpression="CategoryID" />
            <asp:BoundField DataField="QuantityPerUnit" HeaderText="QuantityPerUnit" SortExpression="QuantityPerUnit" />
            <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
            <asp:BoundField DataField="MSRP" HeaderText="MSRP" SortExpression="MSRP" />
            <asp:BoundField DataField="UnitsInStock" HeaderText="UnitsInStock" SortExpression="UnitsInStock" />
            <asp:CheckBoxField DataField="ProductAvailable" HeaderText="ProductAvailable" SortExpression="ProductAvailable" />
            <asp:BoundField DataField="Picture" HeaderText="Picture" SortExpression="Picture" />
            <asp:BoundField DataField="Ranking" HeaderText="Ranking" SortExpression="Ranking" />
            <asp:BoundField DataField="Note" HeaderText="Note" SortExpression="Note" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:eczaneConnectionString %>" DeleteCommand="DELETE FROM [Product] WHERE [ProductID] = @ProductID" InsertCommand="INSERT INTO [Product] ([ProductID], [ProductName], [ProductDescription], [SupplierID], [CategoryID], [QuantityPerUnit], [UnitPrice], [MSRP], [UnitsInStock], [ProductAvailable], [Picture], [Ranking], [Note]) VALUES (@ProductID, @ProductName, @ProductDescription, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @MSRP, @UnitsInStock, @ProductAvailable, @Picture, @Ranking, @Note)" ProviderName="<%$ ConnectionStrings:eczaneConnectionString.ProviderName %>" SelectCommand="SELECT [ProductID], [ProductName], [ProductDescription], [SupplierID], [CategoryID], [QuantityPerUnit], [UnitPrice], [MSRP], [UnitsInStock], [ProductAvailable], [Picture], [Ranking], [Note] FROM [Product]" UpdateCommand="UPDATE [Product] SET [ProductName] = @ProductName, [ProductDescription] = @ProductDescription, [SupplierID] = @SupplierID, [CategoryID] = @CategoryID, [QuantityPerUnit] = @QuantityPerUnit, [UnitPrice] = @UnitPrice, [MSRP] = @MSRP, [UnitsInStock] = @UnitsInStock, [ProductAvailable] = @ProductAvailable, [Picture] = @Picture, [Ranking] = @Ranking, [Note] = @Note WHERE [ProductID] = @ProductID">
        <DeleteParameters>
            <asp:Parameter Name="ProductID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ProductID" Type="Int32" />
            <asp:Parameter Name="ProductName" Type="String" />
            <asp:Parameter Name="ProductDescription" Type="String" />
            <asp:Parameter Name="SupplierID" Type="Int32" />
            <asp:Parameter Name="CategoryID" Type="Int32" />
            <asp:Parameter Name="QuantityPerUnit" Type="Int32" />
            <asp:Parameter Name="UnitPrice" Type="Decimal" />
            <asp:Parameter Name="MSRP" Type="Decimal" />
            <asp:Parameter Name="UnitsInStock" Type="Int16" />
            <asp:Parameter Name="ProductAvailable" Type="Boolean" />
            <asp:Parameter Name="Picture" Type="String" />
            <asp:Parameter Name="Ranking" Type="Int32" />
            <asp:Parameter Name="Note" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="ProductName" Type="String" />
            <asp:Parameter Name="ProductDescription" Type="String" />
            <asp:Parameter Name="SupplierID" Type="Int32" />
            <asp:Parameter Name="CategoryID" Type="Int32" />
            <asp:Parameter Name="QuantityPerUnit" Type="Int32" />
            <asp:Parameter Name="UnitPrice" Type="Decimal" />
            <asp:Parameter Name="MSRP" Type="Decimal" />
            <asp:Parameter Name="UnitsInStock" Type="Int16" />
            <asp:Parameter Name="ProductAvailable" Type="Boolean" />
            <asp:Parameter Name="Picture" Type="String" />
            <asp:Parameter Name="Ranking" Type="Int32" />
            <asp:Parameter Name="Note" Type="String" />
            <asp:Parameter Name="ProductID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>



    <asp:Label ID="Label1" runat="server" Text="Urunun id, isim,aciklama,miktar,fiyat ozelliklerini giriniz."></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>



    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>



    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Onay" />



</asp:Content>

