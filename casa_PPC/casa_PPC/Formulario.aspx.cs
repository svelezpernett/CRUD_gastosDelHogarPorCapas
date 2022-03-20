using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaNegocios;
using System.Data;

namespace casa_PPC
{
    public partial class Formulario : System.Web.UI.Page
    {
        CEtelecomunicaciones oetelecom = new CEtelecomunicaciones();
        CNtelecomunicaciones ontelecom = new CNtelecomunicaciones();

        CEservicios oeservicios = new CEservicios();
        CNservicios onservicios = new CNservicios();

        CEmercado oemercado = new CEmercado();
        CNmercado onmercado = new CNmercado();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //BTN MERCADO

        protected void btnConsultarM_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            oemercado.Fecha = Convert.ToDateTime(txtFechaM.Text);

            ds = onmercado.consultar(oemercado);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblrespuestaM.Text = "No se encontraron registros";
            }
            else
            {
                txtNumFacturaMercado.Text = ds.Tables[0].Rows[0]["Num_facturaM"].ToString();

                txtValorMercado.Text = ds.Tables[0].Rows[0]["Valor_mercado"].ToString();

                lblValorTotalM.Text = txtValorMercado.Text;

                lblrespuestaM.Text = "";


            }
        }


        protected void btnGuardarM_Click(object sender, EventArgs e)
        {
            oemercado.Num_facturaM = Convert.ToInt32(txtNumFacturaMercado.Text);
            oemercado.Valor_mercado = Convert.ToInt32(txtValorMercado.Text);
            oemercado.Fecha = Convert.ToDateTime(txtFechaM.Text);

            if (onmercado.guardar(oemercado))
            {
                lblrespuestaM.Text = "Guardado correctamente";
                lblValorTotalM.Text = txtValorMercado.Text;
            }
            else
            {
                lblrespuestaM.Text = "No se pudo guardar";
            }
        }


        protected void btnEliminarM_Click(object sender, EventArgs e)
        {
            oemercado.Num_facturaM = Convert.ToInt32(txtNumFacturaMercado.Text);

            if (onmercado.eliminar(oemercado))
            {
                lblrespuestaM.Text = "Eliminado correctamente";
                txtNumFacturaMercado.Text = "";
                txtValorMercado.Text = "";
                txtFechaM.Text = "";
                lblValorTotalM.Text = "";
            }
            else
            {
                lblrespuestaM.Text = "No se pudo eliminar";
            }
        }

        protected void btnLimpiarM_Click(object sender, EventArgs e)
        {
            txtNumFacturaMercado.Text = "";
            txtValorMercado.Text = "";
            txtFechaM.Text = "";
            lblValorTotalM.Text = "";
        }


        //BTN TELECOMUNICACIONES


        protected void btnConsultarT_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            oetelecom.Fecha = Convert.ToDateTime(txtFechaTelecomunicaciones.Text);

            ds = ontelecom.consultar(oetelecom);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblrespuestaM.Text = "No se encontraron registros";
            }
            else
            {

                txtNumFacTelec.Text = ds.Tables[0].Rows[0]["Num_facturaT"].ToString();

                txtvalorTelevision.Text = ds.Tables[0].Rows[0]["Valor_tv"].ToString();

                txtvalorInternet.Text = ds.Tables[0].Rows[0]["Valor_int"].ToString();

                txtvalorTelefono.Text = ds.Tables[0].Rows[0]["Valor_tel"].ToString();



                lblrespuestaM.Text = "";

                int vtv = Convert.ToInt32(txtvalorTelevision.Text);
                int vi = Convert.ToInt32(txtvalorInternet.Text);
                int vt = Convert.ToInt32(txtvalorTelefono.Text);
                int vtotal;

                vtotal = vtv + vi + vt;
                lblValorTotalT.Text = System.Convert.ToString(vtotal);


            }


        }


        protected void btnGuardarT_Click(object sender, EventArgs e)
        {
            oetelecom.Num_facturaT = Convert.ToInt32(txtNumFacTelec.Text);
            oetelecom.Valor_tv = Convert.ToInt32(txtvalorTelevision.Text);
            oetelecom.Valor_int = Convert.ToInt32(txtvalorInternet.Text);
            oetelecom.Valor_tel = Convert.ToInt32(txtvalorTelefono.Text);
            oetelecom.Fecha = Convert.ToDateTime(txtFechaTelecomunicaciones.Text);

            if (ontelecom.guardar(oetelecom))
            {
                lblrespuestaT.Text = "Guardado correctamente";

                int vtv = Convert.ToInt32(txtvalorTelevision.Text);
                int vi = Convert.ToInt32(txtvalorInternet.Text);
                int vt = Convert.ToInt32(txtvalorTelefono.Text);
                int vtotal;

                vtotal = vtv + vi + vt;
                lblValorTotalT.Text = System.Convert.ToString(vtotal);
            }
            else
            {
                lblrespuestaT.Text = "No se pudo guardar";
            }
        }



        protected void btnEliminarT_Click(object sender, EventArgs e)
        {
            oetelecom.Num_facturaT = Convert.ToInt32(txtNumFacTelec.Text);

            if (ontelecom.eliminar(oetelecom))
            {
                lblrespuestaT.Text = "Se elimino correctamente";
                txtNumFacTelec.Text = "";
                txtvalorTelevision.Text = "";
                txtvalorInternet.Text = "";
                txtvalorTelefono.Text = "";
                txtFechaTelecomunicaciones.Text = "";
                lblValorTotalT.Text = "";

            }
            else
            {
                lblrespuestaT.Text = "No se pudo eliminar";
            }
        }




        protected void btnLimpiarT_Click(object sender, EventArgs e)
        {
            txtNumFacTelec.Text = "";
            txtvalorTelevision.Text = "";
            txtvalorInternet.Text = "";
            txtvalorTelefono.Text = "";
            txtFechaTelecomunicaciones.Text = "";
            lblValorTotalT.Text = "";
            lblrespuestaT.Text = "";
        }



        //BTN SERVICIOS

        protected void btnConsultarS_Click(object sender, EventArgs e)
        {
            oeservicios.Fecha = Convert.ToDateTime(txtFechaServicios.Text);
            DataSet ds = new DataSet();
            ds = onservicios.consultar(oeservicios);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblrespuestaS.Text = "No se encontraron registros";
            }
            else
            {
                txtNumFacturaServicios.Text = ds.Tables[0].Rows[0]["Num_facturaS"].ToString();
                txtValorAgua.Text = ds.Tables[0].Rows[0]["Valor_agua"].ToString();
                txtValorGas.Text = ds.Tables[0].Rows[0]["Valor_gas"].ToString();
                txtValorLuz.Text = ds.Tables[0].Rows[0]["Valor_luz"].ToString();
                txtFechaServicios.Text = ds.Tables[0].Rows[0]["Fecha"].ToString();

                int va, vg, vl, vtotal;

                va = Convert.ToInt32(txtValorAgua.Text);
                vg = Convert.ToInt32(txtValorGas.Text);
                vl = Convert.ToInt32(txtValorLuz.Text);

                vtotal = va + vg + vl;
                lblValorTotalS.Text = System.Convert.ToString(vtotal);


            }
        }

        protected void btnGuardarS_Click(object sender, EventArgs e)
        {
            oeservicios.Num_facturaS = Convert.ToInt32(txtNumFacturaServicios.Text);
            oeservicios.Valor_agua = Convert.ToInt32(txtValorAgua.Text);
            oeservicios.Valor_gas = Convert.ToInt32(txtValorGas.Text);
            oeservicios.Valor_luz = Convert.ToInt32(txtValorLuz.Text);
            oeservicios.Fecha = Convert.ToDateTime(txtFechaServicios.Text);

            if(onservicios.guardar(oeservicios))
            {
                lblrespuestaS.Text = "Se guardo correctamente";

                int va, vg, vl, vtotal;

                va = Convert.ToInt32(txtValorAgua.Text);
                vg = Convert.ToInt32(txtValorGas.Text);
                vl = Convert.ToInt32(txtValorLuz.Text);

                vtotal = va + vg + vl;
                lblValorTotalS.Text = System.Convert.ToString(vtotal);

            }
            else
            {
                lblrespuestaS.Text = "No se pudo guardar";
            }

        }

        protected void btnEliminarS_Click(object sender, EventArgs e)
        {
            oeservicios.Num_facturaS = Convert.ToInt32(txtNumFacturaServicios.Text);

            if(onservicios.eliminar(oeservicios))
            {
                lblrespuestaS.Text = "Se elimino correctamente";

                txtNumFacturaServicios.Text = "";
                txtValorAgua.Text = "";
                txtValorGas.Text = "";
                txtValorLuz.Text = "";
                txtFechaServicios.Text = "";
                lblValorTotalS.Text = "";

            }
            else
            {
                lblrespuestaS.Text = "No se pudo eliminar";
            }
        }

        protected void limpiarS_Click(object sender, EventArgs e)
        {
            txtNumFacturaServicios.Text = "";
            txtValorAgua.Text = "";
            txtValorGas.Text = "";
            txtValorLuz.Text = "";
            txtFechaServicios.Text = "";
            lblValorTotalS.Text = "";
            lblrespuestaS.Text = "";

        }
    }

}