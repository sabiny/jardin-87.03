<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmAdministrador.aspx.cs" Inherits="Jardin_87P1.frmAdministrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
    <table style="width:100%;">
        <tr>
            <td>Bienvenido
    <asp:LoginName ID="LoginName1" runat="server" />
            </td>
            <td>&nbsp;</td>
            <td>
<asp:LoginStatus ID="LoginStatus1" runat="server" CssClass="pull-right" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
<br />
&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <table style="width:100%;">
        <tr>
            <td style="height: 167px">
                <table style="width:100%;">
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
<asp:Button ID="btnrevisarapoderados" runat="server" OnClick="Button5_Click1" Text="Revisar Apoderados" CssClass="text-center" Width="163px" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td style="height: 167px">
                <table style="width:100%;">
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            
    <asp:Button ID="btnAccionesEstudiantes" runat="server" OnClick="btnAccionesEstudiantes_Click" Text="Revisar Estudiantes" style="margin-left: 0" />
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="btnrevisardocentes" runat="server" Text="Revisar Docentes" OnClick="btnrevisardocentes_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td style="height: 167px">
                <table style="width:100%;">
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="btnrevisarsalones" runat="server" Text="Revisar Salones" OnClick="btnrevisarsalones_Click" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td>
                            
    <asp:Button  ID="btnAgregar" runat="server" OnClick="Button1_Click" Text="Agregar" Visible="False" CssClass="glyphicon-align-center"  />
                            <br />
                            <br />
    <asp:Button ID="btnEliminar" runat="server" OnClick="Button3_Click" Text="Eliminar" Visible="False" />
                            <br />
                            <br />
    <asp:Button ID="btnEditar" runat="server" OnClick="Button2_Click" Text="Actualizar datos" Visible="False" />
                            <br />
                            <br />
                            <br />
                            <asp:Label ID="lblIdA" runat="server" Text="IdApoderado" Visible="False"></asp:Label>
                            <br />
    <asp:TextBox ID="txtId" runat="server" Visible="False"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblNombreA" runat="server" Text="NombreApoderado" Visible="False"></asp:Label>
                            <br />
    <asp:TextBox ID="txtnombre" runat="server" Visible="False"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblApellidoA" runat="server" Text="Apellido Apoderado" Visible="False"></asp:Label>
                            <br />
    <asp:TextBox ID="txtaapellido" runat="server" Visible="False" style="margin-left: 0"></asp:TextBox>
    <br />
                            <asp:Label ID="lblDireccionA" runat="server" Text="Direccion Apoderado" Visible="False"></asp:Label>
                            <br />
    <asp:TextBox ID="txtdireccion" runat="server" Visible="False"></asp:TextBox>
    <br />
                            <asp:Label ID="lblTelefonoA" runat="server" Text="Telefono Apoderado" Visible="False"></asp:Label>
                            <br />
    <asp:TextBox ID="txttelefono" runat="server" Visible="False"></asp:TextBox>
    <br />
                            <asp:Label ID="lblDNIA" runat="server" Text="DNI Apoderado" Visible="False"></asp:Label>
                            <br />
    <asp:TextBox ID="txtdni" runat="server" Visible="False"></asp:TextBox>
    <br />
                            <asp:Label ID="lblCorreoA" runat="server" Text="Correo Electronico" Visible="False"></asp:Label>
                            <br />
    <asp:TextBox ID="txtcorreo" runat="server" Visible="False"></asp:TextBox>
                            <br />
                            <asp:GridView ID="gvApoderadonew" runat="server" OnSelectedIndexChanged="gvApoderadonew_SelectedIndexChanged" Visible="False">
                            </asp:GridView>
                        </td>
                        <td>&nbsp;</td>
                        <td>
    <asp:GridView ID="gvsalonEstudiante" runat="server" style="margin-left: 0px" >
        
        </asp:GridView>
                            <br />
                <asp:Button ID="btnAgregarEstudiante" runat="server" Text="Agregar" Visible="False" Width="110px" OnClick="btnAgregarEstudiante_Click" />
                            <br />
                            <br />
                <asp:Button ID="btnActualizarestudiante" runat="server" Text="Actualizar datos" Visible="False" Width="150px" OnClick="btnActualizarestudiante_Click" />
                            <br />
                            <br />
                <asp:Button ID="btneliminarEstudiante" runat="server" Text="Eliminar Estudiante" Visible="False" Width="159px" OnClick="btneliminarEstudiante_Click" />
                            <br />
                            <br />
                            <asp:Label ID="lnlidestudiante" runat="server" Text="Id Estudiante" Visible="False"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtidestudiante" runat="server" Visible="False"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblNombreestudiante" runat="server" Text="Nombre estudiante" Visible="False"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtidnombreestudiante" runat="server" OnTextChanged="TextBox2_TextChanged" Visible="False"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblapellidoestudiante" runat="server" Text="Apellido Estudiante" Visible="False"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtapellidoestudiante" runat="server" OnTextChanged="TextBox2_TextChanged" Visible="False"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblDNIestudiante" runat="server" Text="DNI estudiante" Visible="False"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtdniestudiante" runat="server" OnTextChanged="TextBox2_TextChanged" style="margin-left: 2" Visible="False"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblEdadEstudiante" runat="server" Text="Edad Estudiante" Visible="False"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtedadestudiante" runat="server" OnTextChanged="TextBox2_TextChanged" Visible="False"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblFechanaciestudiante" runat="server" Text="Fecha de nacimiento" Visible="False"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtfechaestudiante" runat="server" OnTextChanged="TextBox2_TextChanged" Visible="False"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblIdapoderadoestudiante" runat="server" Text="Id Apoderado" Visible="False"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtidapoderadoestudiante" runat="server" OnTextChanged="TextBox2_TextChanged" Visible="False"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblIdsalonestudiante" runat="server" Text="Id Salon" Visible="False"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtidsalonestudiante" runat="server" OnTextChanged="TextBox2_TextChanged" Visible="False"></asp:TextBox>
                            <br />
                            <asp:GridView ID="gvEstudiante" runat="server">
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 20px">&nbsp;</td>
                        <td style="height: 20px"></td>
                        <td style="height: 20px">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td style="height: 20px">&nbsp;</td>
                        <td style="height: 20px">
                            <asp:Button ID="btnAgregardocente" runat="server" Text="Agregar docente" Visible="False" OnClick="btnAgregardocente_Click" />
                            <br />
                            <br />
                            <asp:Button ID="btnActualizardocente" runat="server" Text="Actualizar Docente" Visible="False" OnClick="btnActualizardocente_Click" />
                            <br />
                            <br />
                            <asp:Button ID="btneliminardocente" runat="server" Text="Eliminar Docente" Visible="False" />
                            <br />
                            <br />
                            <asp:Label ID="lblIddocente" runat="server" Text="Id Docente" Visible="False"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtiddocente" runat="server" Visible="False"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblNombredocente" runat="server" Text="Nombre Docente" Visible="False"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtnombredocente" runat="server" Visible="False"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblApellidoDocente" runat="server" Text="Apellido Docente" Visible="False"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtapellidodocente" runat="server" Visible="False"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblCorreoDocente" runat="server" Text="Correo Docente" Visible="False"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtcorreodocente" runat="server" Visible="False"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblDirecciondocente" runat="server" Text="Direccion Docente" Visible="False"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtdirecciondocente" runat="server" Visible="False"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblUsuarioDocente" runat="server" Text="Usuario Docente" Visible="False"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtusuariodocente" runat="server" Visible="False"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblContraseniadocente" runat="server" Text="Contraseña Docente" Visible="False"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtcontraseniadocente" runat="server" Visible="False"></asp:TextBox>
                            <br />
                            <asp:GridView ID="GridViewDocente" runat="server" style="margin-left: 0px">
                            </asp:GridView>
                            <br />
                        </td>
                        <td style="height: 20px"></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td>
                <asp:Button ID="btnagregarsalon" runat="server" Text="Agregar" Visible="False" OnClick="btnagregarsalon_Click" />
                            <br />
                            <br />
                            <br />
                <asp:Button ID="btnactualizarsalon" runat="server" Text="Actualizar datos" Visible="False" Width="150px" OnClick="btnactualizarsalon_Click" />
                            <br />
                            <asp:Label ID="lblIdSalon" runat="server" Text="IdSalon" Visible="False"></asp:Label>
                                        <br />
                            <asp:TextBox ID="txtIdsalon" runat="server" Visible="False"></asp:TextBox>
                                        <br />
                            <asp:Label ID="lblnombresalon" runat="server" Text="Nombre de Salon" Visible="False"></asp:Label>
                                        <br />
                            <asp:TextBox ID="txtIdNombresalon" runat="server" Visible="False"></asp:TextBox>
                                        <br />
                            <asp:Label ID="lblIddocentesalon" runat="server" Text="IdDocente" Visible="False"></asp:Label>
                                    <br />
                            <asp:TextBox ID="txtiddocentesalon" runat="server" Visible="False"></asp:TextBox>
                                    <br />
                            <br />
                            <asp:GridView ID="gvsalon" runat="server">
                            </asp:GridView>
                            <br />
                        </td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <br />
    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------<br />
<br />
</asp:Content>
