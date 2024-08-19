<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP2.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingrese nombre del producto:&nbsp;&nbsp;
            <asp:TextBox ID="txtProducto1" runat="server"></asp:TextBox>
&nbsp;&nbsp; Cantidad:&nbsp;&nbsp;
            <asp:TextBox ID="txtCantidad1" runat="server"></asp:TextBox>
            <br />
            <br />
            Ingrese nombre del producto:&nbsp;
            <asp:TextBox ID="txtProducto2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Cantidad:&nbsp;&nbsp;
            <asp:TextBox ID="txtCantidad2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generar Tabla" />
            <br />
        </div>
        <asp:Label ID="lblTabla" runat="server"></asp:Label>
    </form>
</body>
</html>
