<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="casa_PPC.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gastos del hogar</title>
    
</head>
<body>
    <form id="form1" runat="server">
        <h1>Telecomunicaciones</h1>
        <table class="table table-hover">
                <tr>
      <th scope="row">1</th>
      <td>Numero de factura</td>
      <td>
          <asp:TextBox ID="txtNumFacTelec" runat="server"></asp:TextBox>
                    </td>
      <td>
          
          <asp:Button ID="btnConsultarT" runat="server" Text="Consultar por fecha" OnClick="btnConsultarT_Click" />
          
      </td>
    </tr>
    <tr>
      <th scope="row">2</th>
      <td>Valor television</td>
      <td>
          <asp:TextBox ID="txtvalorTelevision" runat="server"></asp:TextBox>
        </td>
      <td>
          <asp:Button ID="btnGuardarT" runat="server" Text="Guardar" OnClick="btnGuardarT_Click" />
        </td>
    </tr>
    <tr>
      <th scope="row">3</th>
      <td>Valor internet</td>
      <td>
          <asp:TextBox ID="txtvalorInternet" runat="server"></asp:TextBox>
        </td>
      <td>
          <asp:Button ID="btnEliminarT" runat="server" Text="Eliminar" OnClick="btnEliminarT_Click" />
        </td>
    </tr>
    <tr>
      <th scope="row">4</th>
      <td>Valor telefono</td>
      <td>
          <asp:TextBox ID="txtvalorTelefono" runat="server"></asp:TextBox>
        </td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <th scope="row">5</th>
      <td>Fecha</td>
      <td>
          <asp:TextBox ID="txtFechaTelecomunicaciones" runat="server"></asp:TextBox>
        </td>
      <td>
          &nbsp;</td>
    </tr>

    <tr>
      <th scope="row">6</th>
      <td>Valor total:</td>
      <td>
          <asp:Label ID="lblValorTotalT" runat="server"></asp:Label>
        </td>
      <td>
          <asp:Button ID="btnLimpiarT" runat="server" Text="Limpiar" OnClick="btnLimpiarT_Click" />
        </td>
    </tr>

    <tr>
      <th scope="row"></th>
      <td>&nbsp;</td>
      <td>
          <asp:Label ID="lblrespuestaT" runat="server"></asp:Label>
        </td>
      <td>&nbsp;</td>
    </tr>


        </table>

        <br />  <br />  <br />

        <h1>Servicios</h1>
        <table class="table table-hover">
                <tr>
      <th scope="row">1</th>
      <td>Numero de factura</td>
      <td>
          <asp:TextBox ID="txtNumFacturaServicios" runat="server"></asp:TextBox>
                    </td>
      <td>
          
          <asp:Button ID="btnConsultarS" runat="server" Text="Consultar por fecha" OnClick="btnConsultarS_Click" />
          
      </td>
    </tr>
    <tr>
      <th scope="row">2</th>
      <td>Valor agua</td>
      <td>
          <asp:TextBox ID="txtValorAgua" runat="server"></asp:TextBox>
        </td>
      <td>
          <asp:Button ID="btnGuardarS" runat="server" Text="Guardar" OnClick="btnGuardarS_Click" />
        </td>
    </tr>
    <tr>
      <th scope="row">3</th>
      <td>Valor gas</td>
      <td>
          <asp:TextBox ID="txtValorGas" runat="server"></asp:TextBox>
        </td>
      <td>
          <asp:Button ID="btnEliminarS" runat="server" Text="Eliminar" OnClick="btnEliminarS_Click" />
        </td>
    </tr>
    <tr>
      <th scope="row">4</th>
      <td>Valor luz</td>
      <td>
          <asp:TextBox ID="txtValorLuz" runat="server"></asp:TextBox>
        </td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <th scope="row">5</th>
      <td>Fecha</td>
      <td>
          <asp:TextBox ID="txtFechaServicios" runat="server"></asp:TextBox>
        </td>
      <td>
          &nbsp;</td>
    </tr>

    <tr>
      <th scope="row">6</th>
      <td>Valor total:</td>
      <td>
          <asp:Label ID="lblValorTotalS" runat="server"></asp:Label>
        </td>
      <td>
          <asp:Button ID="limpiarS" runat="server" Text="Limpiar" OnClick="limpiarS_Click" />
        </td>
    </tr>

            <tr>
      <th scope="row"></th>
      <td>&nbsp;</td>
      <td>
          <asp:Label ID="lblrespuestaS" runat="server"></asp:Label>
        </td>
      <td>&nbsp;</td>
    </tr>

        </table>

        <br />  <br />  <br />

        <h1>Mercado</h1>
        <table class="table table-hover">
                <tr>
      <th scope="row">1</th>
      <td>Numero de factura</td>
      <td>
          <asp:TextBox ID="txtNumFacturaMercado" runat="server"></asp:TextBox>
                    </td>
      <td>
          
          <asp:Button ID="btnConsultarM" runat="server" Text="Consultar por fecha" OnClick="btnConsultarM_Click" />
          
      </td>
    </tr>
    <tr>
      <th scope="row">2</th>
      <td>Valor mercado</td>
      <td>
          <asp:TextBox ID="txtValorMercado" runat="server"></asp:TextBox>
        </td>
      <td>
          <asp:Button ID="btnGuardarM" runat="server" Text="Guardar" OnClick="btnGuardarM_Click" />
        </td>
    </tr>
    <tr>
      <th scope="row">3</th>
      <td>Fecha</td>
      <td>
          <asp:TextBox ID="txtFechaM" runat="server"></asp:TextBox>
        </td>
      <td>
          <asp:Button ID="btnEliminarM" runat="server" OnClick="btnEliminarM_Click" Text="Eliminar" />
        </td>
    </tr>
    <tr>
      <th scope="row">4</th>
      <td>Valor total:</td>
      <td>
          <asp:Label ID="lblValorTotalM" runat="server"></asp:Label>
        </td>
      <td>&nbsp;</td>
    </tr>
       
    <tr>
      <th scope="row"></th>
      <td>&nbsp;</td>
      <td>
          &nbsp;
          <asp:Label ID="lblrespuestaM" runat="server"></asp:Label>
        </td>
      <td>
          <asp:Button ID="btnLimpiarM" runat="server" OnClick="btnLimpiarM_Click" Text="Limpiar" />
        </td>
    </tr>

        </table>
    </form>
</body>
</html>
