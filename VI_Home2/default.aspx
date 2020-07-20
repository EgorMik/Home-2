<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="VI_Home2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <fieldset style ="width:220px;">
    <legend></legend>   
        <asp:Label ID="SiteVisited" runat="server" Text=""
            style="color: #FFFFFF; background-color: #3366FF"></asp:Label><br />
      
       <a href="default2.aspx">Перейти на вторую страницу</a>
<%--        <asp:Button ID="btnClearSesson" runat="server" Text="Clear Session"
            onclick="btnClearSesson_Click" />--%>
        </fieldset>
        </div>

    </form>
</body>
</html>
