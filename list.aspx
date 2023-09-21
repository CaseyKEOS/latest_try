<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="XamppTry.View.list" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" typeof="reset">
        
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Save" />
        <asp:Button ID="Button5" runat="server" type="reset" Text="Clear" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Delete" />
        
        <asp:GridView ID="tblcontact" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridViewSelected1">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle ForeColor="#333333" BackColor="#FFFBD6" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>

        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Search" />
        <p>

        <asp:DropDownList ID="dropdown" runat="server" OnSelectedIndexChanged="dropdown_SelectedIndexChanged">
        </asp:DropDownList>
            <asp:Button ID="ViewAll" runat="server" OnClick="ViewAll_Click" Text="View All" />
            <asp:Button ID="Button1" runat="server" Text="Submit" />
            <asp:GridView ID="tbluser" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle ForeColor="#333333" BackColor="#FFFBD6" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
        </p>
    </form>
</body>
</html>
