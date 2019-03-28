<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            init: <asp:Label runat="server" ID="alkuTxt" />
            <br />
            eka: <asp:TextBox runat="server" ID="tbEka" />
            <br />
            eka (base64Encoded): <asp:Label runat="server" ID="alkuTxtEnkoodattu" ForeColor="Red" />
            <br />
            eka (base64Decoded): <asp:Label runat="server" ID="alkuTxtDekoodattu" ForeColor="Green" />
        
        </div>
    </form>
</body>
</html>
