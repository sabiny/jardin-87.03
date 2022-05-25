using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;

namespace Jardin_87P1
{
    public partial class frmAdministrador : System.Web.UI.Page
    {
        private Jardin87DataContext jardin = new Jardin87DataContext();

        private IList<Apoderado> ListarApoderado()
        {
            var consulta = from C in jardin.Apoderado
                           select C;

            return consulta.ToList();
        }

        private IList<Estudiantes> ListarEstudiantes()
        {
            var consulta = from C in jardin.Estudiantes
                           select C;

            return consulta.ToList();
        }

        private IList<Docente> ListarDocente()
        {
            var consulta = from C in jardin.Docente
                           select C;

            return consulta.ToList();
        }

        private IList<Salon> ListarSalon()
        {
            var consulta = from C in jardin.Salon
                           select C;

            return consulta.ToList();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Acciones Apoderado
            
            //Acciones Estudiante
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            Apoderado apoderado = new Apoderado();
            apoderado.IdApoderado = txtId.Text.Trim();
            apoderado.Nombre = txtnombre.Text.Trim();
            apoderado.Apellido = txtaapellido.Text.Trim();
            apoderado.Direccion = txtdireccion.Text.Trim();
            apoderado.Telefono = txttelefono.Text.Trim();
            apoderado.DNI = txtdni.Text.Trim();
            apoderado.CorreoElectronico = txtcorreo.Text.Trim();

            jardin.Apoderado.InsertOnSubmit(apoderado);
            try
            {
                jardin.SubmitChanges();
                gvApoderadonew.DataSource = ListarApoderado();
                gvApoderadonew.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        

        protected void Button2_Click(object sender, EventArgs e)
        {
            Apoderado apoderado = jardin.Apoderado.Single(C => C.IdApoderado == txtId.Text.Trim());
            apoderado.Nombre = txtnombre.Text.Trim();
            apoderado.Apellido = txtaapellido.Text.Trim();
            apoderado.Direccion = txtdireccion.Text.Trim();
            apoderado.Telefono = txttelefono.Text.Trim();
            apoderado.DNI = txtdni.Text.Trim();
            apoderado.CorreoElectronico = txtcorreo.Text.Trim();


            try
            {
                jardin.SubmitChanges();
                gvApoderadonew.DataSource = ListarApoderado();
                gvApoderadonew.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                var codigo = (from C in jardin.Apoderado
                              where C.IdApoderado.Contains(txtId.Text.Trim())
                              select C).First();
                jardin.Apoderado.DeleteOnSubmit(codigo);

                jardin.SubmitChanges();
                gvApoderadonew.DataSource = ListarApoderado();
                gvApoderadonew.DataBind();
            }
            catch (Exception ex)
            {

                Response.Write(ex.Message);
            }
        }

       
       
        

        protected void Button5_Click1(object sender, EventArgs e)
        {
            Jardin87DataContext jardin = new Jardin87DataContext();
            var consulta = from P in jardin.Apoderado
                           select P;
            gvApoderadonew.DataSource = consulta;
            gvApoderadonew.DataBind();
            //ocultar campos estudiantes
            btnAgregarEstudiante.Visible = false;
            btnActualizarestudiante.Visible = false;
            btneliminarEstudiante.Visible = false;
            lnlidestudiante.Visible = false;
            lblNombreestudiante.Visible = false;
            lblapellidoestudiante.Visible = false;
            lblDNIestudiante.Visible = false;
            lblEdadEstudiante.Visible = false;
            lblFechanaciestudiante.Visible = false;
            lblIdapoderadoestudiante.Visible = false;
            txtidestudiante.Visible = false;
            txtidnombreestudiante.Visible = false;
            txtapellidoestudiante.Visible = false;
            txtdniestudiante.Visible = false;
            txtedadestudiante.Visible = false;
            txtfechaestudiante.Visible = false;
            txtidapoderadoestudiante.Visible = false;
            gvsalonEstudiante.Visible = false;
            gvEstudiante.Visible = false;

            //ocultar campos salon

            btnagregarsalon.Visible = false;
            btnactualizarsalon.Visible = false;
            lblIdSalon.Visible = false;
            txtIdsalon.Visible = false;
            lblnombresalon.Visible = false;
            txtIdNombresalon.Visible = false;
            
            lblIddocentesalon.Visible = false;
            txtiddocentesalon.Visible = false;
            gvsalon.Visible = false;

            //mostrar campos docente
            lblIdA.Visible = true;
            lblApellidoA.Visible = true;
            lblNombreA.Visible = true;
            lblDireccionA.Visible = true;
            lblTelefonoA.Visible = true;
            lblDNIA.Visible = true;
            lblCorreoA.Visible = true;
            txtId.Visible = true;
            txtaapellido.Visible = true;
            txtnombre.Visible = true;
            txtdireccion.Visible = true;
            txttelefono.Visible = true;
            txtdni.Visible = true;
            txtcorreo.Visible = true;
            btnAgregar.Visible = true;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
            gvApoderadonew.Visible = true;

        }

        protected void btnAccionesEstudiantes_Click(object sender, EventArgs e)
        {
            Jardin87DataContext jardin = new Jardin87DataContext();
            var consulta = from P in jardin.Salon
                           select P;
            gvsalonEstudiante.DataSource = consulta;
            gvsalonEstudiante.DataBind();

            
            var consulta2 = from P in jardin.Estudiantes
                           select P;
            gvEstudiante.DataSource = consulta2;
            gvEstudiante.DataBind();


            var consulta3 = from P in jardin.Apoderado
                           select P;
            gvApoderadonew.DataSource = consulta3;
            gvApoderadonew.DataBind();

            //ocualtar campos de apoderados

            lblIdA.Visible = false;
            lblApellidoA.Visible = false;
            lblNombreA.Visible = false;
            lblDireccionA.Visible = false;
            lblTelefonoA.Visible = false;
            lblDNIA.Visible = false;
            lblCorreoA.Visible = false;
            txtId.Visible = false;
            txtaapellido.Visible = false;
            txtnombre.Visible = false;
            txtdireccion.Visible = false;
            txttelefono.Visible = false;
            txtdni.Visible = false;
            txtcorreo.Visible = false;
            btnAgregar.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            gvApoderadonew.Visible = false;
            GridViewDocente.Visible = false;

            //ocultar campos salon

            btnagregarsalon.Visible = false;
            btnactualizarsalon.Visible = false;
            lblIdSalon.Visible = false;
            txtIdsalon.Visible = false;
            lblnombresalon.Visible = false;
            txtIdNombresalon.Visible = false;
            
            lblIddocentesalon.Visible = false;
            txtiddocentesalon.Visible = false;
            gvsalon.Visible = false;


            //mostrar campos estudiante
            btnAgregarEstudiante.Visible = true;
            btnActualizarestudiante.Visible = true;
            btneliminarEstudiante.Visible=true;
            lnlidestudiante.Visible = true;
            lblNombreestudiante.Visible = true;
            lblapellidoestudiante.Visible = true;
            lblDNIestudiante.Visible= true;
            lblEdadEstudiante.Visible=true;
            lblFechanaciestudiante.Visible=true;
            lblIdapoderadoestudiante.Visible = true;
            txtidestudiante.Visible = true;
            txtidnombreestudiante.Visible = true;
            txtapellidoestudiante.Visible = true;
            txtdniestudiante.Visible = true;
            txtedadestudiante.Visible = true;
            txtfechaestudiante.Visible = true;
            txtidapoderadoestudiante.Visible = true;
            txtidsalonestudiante.Visible = true;
            gvEstudiante.Visible = true;
            gvApoderadonew.Visible = true;
            gvsalonEstudiante.Visible = true;
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnrevisarsalones_Click(object sender, EventArgs e)
        {
            Jardin87DataContext jardin = new Jardin87DataContext();
            var consulta = from P in jardin.Salon
                           select P;
            gvsalon.DataSource = consulta;
            gvsalon.DataBind();

            //ocultar datos apoderados
            lblIdA.Visible = false;
            lblApellidoA.Visible = false;
            lblNombreA.Visible = false;
            lblDireccionA.Visible = false;
            lblTelefonoA.Visible = false;
            lblDNIA.Visible = false;
            lblCorreoA.Visible = false;
            txtId.Visible = false;
            txtaapellido.Visible = false;
            txtnombre.Visible = false;
            txtdireccion.Visible = false;
            txttelefono.Visible = false;
            txtdni.Visible = false;
            txtcorreo.Visible = false;
            btnAgregar.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            gvApoderadonew.Visible = false;

            //ocultar campos estudiantes
            btnAgregarEstudiante.Visible = false;
            btnActualizarestudiante.Visible = false;
            btneliminarEstudiante.Visible = false;
            lnlidestudiante.Visible = false;
            lblNombreestudiante.Visible = false;
            lblapellidoestudiante.Visible = false;
            lblDNIestudiante.Visible = false;
            lblEdadEstudiante.Visible = false;
            lblFechanaciestudiante.Visible = false;
            lblIdapoderadoestudiante.Visible = false;
            txtidestudiante.Visible = false;
            txtidnombreestudiante.Visible = false;
            txtapellidoestudiante.Visible = false;
            txtdniestudiante.Visible = false;
            txtedadestudiante.Visible = false;
            txtfechaestudiante.Visible = false;
            txtidapoderadoestudiante.Visible = false;
            txtidsalonestudiante.Visible = false;
            lblIdsalonestudiante.Visible = false;
            gvEstudiante.Visible = false;
            gvApoderadonew.Visible = false;
            gvsalonEstudiante.Visible = false;

            //ocultar campos docentes
            GridViewDocente.Visible = false;
            btnAgregardocente.Visible = false;
            btnActualizardocente.Visible = false;
            btneliminardocente.Visible = false;
            lblIddocente.Visible = false;
            lblNombredocente.Visible = false;
            lblApellidoDocente.Visible = false;
            lblCorreoDocente.Visible = false;
            lblDirecciondocente.Visible = false;
            lblUsuarioDocente.Visible = false;
            lblContraseniadocente.Visible = false;
            txtiddocente.Visible = false;
            txtnombredocente.Visible = false;
            txtapellidodocente.Visible = false;
            txtcorreodocente.Visible = false;
            txtdirecciondocente.Visible = false;
            txtusuariodocente.Visible = false;
            txtcontraseniadocente.Visible = false;

            //mostrar campos 

            btnagregarsalon.Visible = true;
            btnactualizarsalon.Visible = true;
            lblIdSalon.Visible = true;
            txtIdsalon.Visible = true;
            lblnombresalon.Visible = true;
            txtIdNombresalon.Visible = true;
            
            lblIddocentesalon.Visible = true;
            txtiddocentesalon.Visible=true;
            gvsalon.Visible = true;
            GridViewDocente.Visible=true;
        }

        protected void btnActualizarestudiante_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante = jardin.Estudiantes.Single(C => C.IdEstudiante == txtidestudiante.Text.Trim());
            estudiante.Nombre = txtidnombreestudiante.Text.Trim();
            estudiante.Apellido = txtapellidoestudiante.Text.Trim();
            estudiante.DNI = txtdniestudiante.Text.Trim();
            estudiante.Edad = txtedadestudiante.Text.Trim();
            estudiante.Fecha_nacimiento = Convert.ToDateTime(txtfechaestudiante.Text.Trim());
            estudiante.IdApoderado = txtidapoderadoestudiante.Text.Trim();
            estudiante.IdDocente = txtidsalonestudiante.Text.Trim();


            try
            {
                jardin.SubmitChanges();
                gvEstudiante.DataSource = ListarEstudiantes();
                gvEstudiante.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnrevisardocentes_Click(object sender, EventArgs e)
        {
            Jardin87DataContext jardin = new Jardin87DataContext();
            var consulta = from P in jardin.Docente
                           select P;
            GridViewDocente.DataSource = consulta;
            GridViewDocente.DataBind();

            //ocultar datos apoderados
            lblIdA.Visible = false;
            lblApellidoA.Visible = false;
            lblNombreA.Visible = false;
            lblDireccionA.Visible = false;
            lblTelefonoA.Visible = false;
            lblDNIA.Visible = false;
            lblCorreoA.Visible = false;
            txtId.Visible = false;
            txtaapellido.Visible = false;
            txtnombre.Visible = false;
            txtdireccion.Visible = false;
            txttelefono.Visible = false;
            txtdni.Visible = false;
            txtcorreo.Visible = false;
            btnAgregar.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            gvApoderadonew.Visible = false;

            //ocultar campos estudiantes
            btnAgregarEstudiante.Visible = false;
            btnActualizarestudiante.Visible = false;
            btneliminarEstudiante.Visible = false;
            lnlidestudiante.Visible = false;
            lblNombreestudiante.Visible = false;
            lblapellidoestudiante.Visible = false;
            lblDNIestudiante.Visible = false;
            lblEdadEstudiante.Visible = false;
            lblFechanaciestudiante.Visible = false;
            lblIdapoderadoestudiante.Visible = false;
            txtidestudiante.Visible = false;
            txtidnombreestudiante.Visible = false;
            txtapellidoestudiante.Visible = false;
            txtdniestudiante.Visible = false;
            txtedadestudiante.Visible = false;
            txtfechaestudiante.Visible = false;
            txtidapoderadoestudiante.Visible = false;
            txtidsalonestudiante.Visible = false;
            lblIdsalonestudiante.Visible=false;
            gvEstudiante.Visible = false;
            gvApoderadonew.Visible = false;
            gvsalonEstudiante.Visible = false;

            //ocultar campos salon

            btnagregarsalon.Visible = false;
            btnactualizarsalon.Visible = false;
            lblIdSalon.Visible = false;
            txtIdsalon.Visible = false;
            lblnombresalon.Visible = false;
            txtIdNombresalon.Visible = false;
            
            lblIddocentesalon.Visible = false;
            txtiddocentesalon.Visible = false;
            gvsalon.Visible = false;

            //mostrar campos docentes
            GridViewDocente.Visible = true;
            btnAgregardocente.Visible = true;
            btnActualizardocente.Visible = true;
            btneliminardocente.Visible = true;
            lblIddocente.Visible = true;
            lblNombredocente.Visible =true;
            lblApellidoDocente.Visible = true;
            lblCorreoDocente.Visible=true;
            lblDirecciondocente.Visible = true;
            lblUsuarioDocente.Visible = true;
            lblContraseniadocente.Visible = true;
            txtiddocente.Visible = true;
            txtnombredocente.Visible=true;
            txtapellidodocente.Visible=true;
            txtcorreodocente.Visible = true;
            txtdirecciondocente.Visible = true;
            txtusuariodocente.Visible=true;
            txtcontraseniadocente.Visible = true;

        }

        protected void gvApoderadonew_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            
            Estudiantes estudiante = new Estudiantes();
            estudiante.IdEstudiante = txtidestudiante.Text.Trim();
            estudiante.Nombre = txtidnombreestudiante.Text.Trim();
            estudiante.Apellido = txtapellidoestudiante.Text.Trim();
            estudiante.DNI = txtdniestudiante.Text.Trim();
            estudiante.Edad = txtedadestudiante.Text.Trim();
            estudiante.Fecha_nacimiento = Convert.ToDateTime(txtfechaestudiante.Text.Trim());
            estudiante.IdApoderado = txtidapoderadoestudiante.Text.Trim();
            estudiante.IdDocente = txtidsalonestudiante.Text.Trim();

            jardin.Estudiantes.InsertOnSubmit(estudiante);
            try
            {
                jardin.SubmitChanges();
                gvEstudiante.DataSource = ListarEstudiantes();
                gvEstudiante.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btneliminarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                var codigo = (from C in jardin.Estudiantes
                              where C.IdEstudiante.Contains(txtidestudiante.Text.Trim())
                              select C).First();
                jardin.Estudiantes.DeleteOnSubmit(codigo);

                jardin.SubmitChanges();
                gvEstudiante.DataSource = ListarEstudiantes();
                gvEstudiante.DataBind();
            }
            catch (Exception ex)
            {

                Response.Write(ex.Message);
            }
        }

        protected void btnAgregardocente_Click(object sender, EventArgs e)
        {
            Docente docente = new Docente();
            docente.IdDocente = txtiddocente.Text.Trim();
            docente.Nombre = txtnombredocente.Text.Trim();
            docente.Apellido = txtapellidodocente.Text.Trim();
            docente.CorreoElectronico = txtcorreo.Text.Trim();
            docente.Direccion = txtdirecciondocente.Text.Trim();
            docente.Usuario = txtusuariodocente.Text.Trim();
            docente.Contrasenia = txtcontraseniadocente.Text.Trim();
            

            jardin.Docente.InsertOnSubmit(docente);
            try
            {
                jardin.SubmitChanges();
                GridViewDocente.DataSource = ListarDocente();
                GridViewDocente.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnActualizardocente_Click(object sender, EventArgs e)
        {
            Docente docente = jardin.Docente.Single(C => C.IdDocente == txtiddocente.Text.Trim());
            docente.IdDocente = txtiddocente.Text.Trim();
            docente.Nombre = txtnombredocente.Text.Trim();
            docente.Apellido = txtapellidodocente.Text.Trim();
            docente.CorreoElectronico = txtcorreo.Text.Trim();
            docente.Direccion = txtdirecciondocente.Text.Trim();
            docente.Usuario = txtusuariodocente.Text.Trim();
            docente.Contrasenia = txtcontraseniadocente.Text.Trim();


            try
            {
                jardin.SubmitChanges();
                GridViewDocente.DataSource = ListarDocente();
                GridViewDocente.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnagregarsalon_Click(object sender, EventArgs e)
        {
            Salon salon = new Salon();
            salon.IdSalon = txtIdsalon.Text.Trim();
            salon.NombreSalon = txtIdNombresalon.Text.Trim();
            salon.IdDocente = txtiddocentesalon.Text.Trim();
         
            jardin.Salon.InsertOnSubmit(salon);
            try
            {
                jardin.SubmitChanges();
                gvsalon.DataSource = ListarSalon();
                gvsalon.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnactualizarsalon_Click(object sender, EventArgs e)
        {
            Salon salon = jardin.Salon.Single(C => C.IdSalon == txtIdsalon.Text.Trim());
            salon.NombreSalon = txtIdNombresalon.Text.Trim();
            salon.IdDocente = txtiddocentesalon.Text.Trim();

            try
            {
                jardin.SubmitChanges();
                gvsalon.DataSource = ListarSalon();
                gvsalon.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}




