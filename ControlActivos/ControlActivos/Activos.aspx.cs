﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data.SqlClient;
using System.Data;

namespace ControlActivos
{
    public partial class Activos : Page
    {
        ActivosMant obj = new ActivosMant();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b_agregar_Click(object sender, EventArgs e)
        {
            obj.codigo = Convert.ToInt32(txt_codigo.Text);
            obj.modelo = txt_modelo.Text;
            obj.marca = txt_marca.Text;
            obj.so = txt_so.Text;
            obj.region = txt_region.Text;
            obj.oficina = txt_oficina.Text;
            obj.usuario = txt_usuario.Text;
            obj.fechaven = Convert.ToDateTime(txt_fechavencer.Text);
            obj.fecha = Convert.ToDateTime(txt_fecha.Text);
            obj.garantia = Convert.ToInt32(txt_garantia.Text);

            Label1.Text=obj.insertarActivos(Label1.Text).ToString();
     
            
        }

        protected void b_modificar_Click(object sender, EventArgs e)
        {
            obj.codigo = Convert.ToInt32(txt_codigo.Text);
            obj.modelo = txt_modelo.Text;
            obj.marca = txt_marca.Text;
            obj.so = txt_so.Text;
            obj.region = txt_region.Text;
            obj.oficina = txt_oficina.Text;
            obj.usuario = txt_usuario.Text;
            obj.fechaven = Convert.ToDateTime(txt_fechavencer.Text);
            obj.fecha = Convert.ToDateTime(txt_fecha.Text);
            obj.garantia = Convert.ToInt32(txt_garantia.Text);

            Label1.Text = obj.modificarActivos(Label1.Text).ToString();
        }
    }
}