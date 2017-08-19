using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ControlActivos
{
    public partial class Usuarios : Page
    {

        UsuariosMant obj = new UsuariosMant();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b_modificar_Click(object sender, EventArgs e)
        {
            obj.codigo = Convert.ToInt32(txt_cedu.Text);
            obj.contra = txt_pass.Text;
            obj.nombre = txt_usua.Text;
            obj.tipUsua = Convert.ToInt32(txt_rol.Text);

            Label1.Text = obj.actualizarActivos(Label1.Text).ToString(); 

        }
    }
}