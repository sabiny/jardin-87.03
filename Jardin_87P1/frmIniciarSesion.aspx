<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmIniciarSesion.aspx.cs" Inherits="Jardin_87P1.frmIniciarSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>Seleccione rol</asp:ListItem>
        <asp:ListItem>Docente</asp:ListItem>
        <asp:ListItem>Administrador</asp:ListItem>
    </asp:DropDownList>
</p>
<p>
    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
</p>
<p>
    <asp:TextBox ID="txtcontraseña" runat="server" TextMode="Password"></asp:TextBox>
</p>

<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Iniciar Sesion" />
</p>
    <!-- Modal -->
<div id="myModal" class="modal fade" role="dialog">
  <div class="modal-dialog">

    <!-- Modal content-->
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal">&times;</button>
        <h4 class="modal-title">ATENCIÓN</h4>
      </div>
      <div class="modal-body">
          <center>
              <asp:Label runat ="server" ID ="LB"></asp:Label>
          </center>
      </div>
         <center>
               <p>Si tiene algun problema comuniquese con 999999999</p>
          </center>

      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
      </div>
    </div>

  </div>
</div>

    <script type ="text/javascript">
        function openModal() {
            $('#myModal').modal('show');
        }


    </script>


</asp:Content>

