<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="ClientHrDepartment.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Region Name: <asp:TextBox ID="textregion" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"  />
            <br />
            <br />
            <asp:Label ID="LblMngr" runat="server" ></asp:Label>
            <br />
            <br />
            <asp:Label ID="LblEng" runat="server" ></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="LblAsc" runat="server" ></asp:Label>
            <br />

        </div>
    </form>
</body>
</html>
