using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Mikrotik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnConexion.Enabled = false;
            btnFichas.Enabled = false;
            btnAyuda.Enabled = false;
            MenuVertical.Width = 37;
            //lblMensaje.Text="Bienvenido: "+Conectar.mensaje;
            cmboxTiempo.Items.Add("01:00:00");
            cmboxTiempo.Items.Add("02:00:00");
            cmboxTiempo.Items.Add("03:00:00");
            cmboxTiempo.Items.Add("05:00:00");
            cmboxTiempo.Items.Add("12:00:00");
            cmboxTiempo.Items.Add("24:00:00");
            cmboxTiempo.Items.Add("72:00:00");
            cmboxTiempo.Items.Add("168:00:00");
            cmboxTiempo.Items.Add("360:00:00");
            cmboxTiempo.Items.Add("696:00:00");
            cmboxTipo.Items.Add("conPausa");
            cmboxTipo.Items.Add("sinPausa");
            txtBUsuario.Enabled = false;
            txtBIP.Enabled = false;
            txtBPuerto.Enabled = false;
            txtBContraseña.isPassword = true;
            mydatagrid.Columns.Add("usuario", "Usuario");
            mydatagrid.Columns.Add("contraseña", "Contraseña");
            mydatagrid.Columns.Add("tipo", "Tipo");
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSlide_Click(object sender, EventArgs e)
        {

            if (MenuVertical.Width == 37)
            {
                MenuVertical.Width = 145;
                btnConexion.Enabled = true;
                btnFichas.Enabled = true;
                btnAyuda.Enabled = true;
            }
            else
            {
                MenuVertical.Width = 37;
                btnConexion.Enabled = false;
                btnFichas.Enabled = false;
                btnAyuda.Enabled = false;
            }
        }

        private void iconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }
        private void btnConexion_Click(object sender, EventArgs e)
        {
            //AbrirFormInPanel(new Conectar());
        }

        private void btnFichas_Click(object sender, EventArgs e)
        {
            //AbrirFormInPanel(new Fichas());
        }
        private void btnBConectar_Click(object sender, EventArgs e)
        {
            string ip = txtBIP.Text;
            string usuario = txtBUsuario.Text;
            string contraseña = txtBContraseña.Text;
            int puerto = Convert.ToInt16(txtBPuerto.Text);

            MK mikrotik = new MK(ip, puerto);

            if (!mikrotik.Login(usuario, contraseña))
            {
                lblMensaje.Text = "no hubo conexión";
                mikrotik.Close();
                return;

            }
            string[] arreglo = new string[2];
            int i = 0;
            mikrotik.Send("/system/identity/getall");
            mikrotik.Send(".tag=sss", true);
            foreach (string h in mikrotik.Read())
            {
                //obtengo los valores en un arreglo
                arreglo[i] = h;
                i++;
            }
            // imprimo el mensaje en la posición 0
            //lblBienvenido.Text = arreglo[0];
            lblMensaje.Text = "Bienvenido: " + arreglo[0].Remove(0, 17);

        }

        private void btnBGenerar_Click(object sender, EventArgs e)
        {

            //Obtengo los valores 
            string ip = txtBIP.Text;
            string usuario = txtBUsuario.Text;
            int puerto = Convert.ToInt16(txtBPuerto.Text);
            string contraseña = txtBContraseña.Text;
            // información para la ficha
            int Cantidad = Convert.ToInt16(txtBCantidad.Text);
            string prefijo = txtBPrefijo.Text;
            //leer el dato seleccionado en combobox

            string perfil = cmboxTipo.Text;
            string segundos = cmboxTiempo.Text;
            // generación de fichas por medio del mes y prefijo


            //obtener el mes actual en español
            DateTime moment = new DateTime(
                               1999, 1, 13, 3, 57, 32, 11);
            int month = moment.Month;
            string mes = "";
            if (month == 1)
            {
                mes = "ene";
            }
            else if (month == 2)
            {
                mes = "feb";
            }
            else if (month == 3)
            {
                mes = "mar";
            }
            else if (month == 4)
            {
                mes = "abril";
            }
            else if (month == 5)
            {
                mes = "may";
            }
            else if (month == 6)
            {
                mes = "jun";
            }
            else if (month == 7)
            {
                mes = "jul";
            }
            else if (month == 8)
            {
                mes = "ago";
            }
            else if (month == 9)
            {
                mes = "sep";
            }
            else if (month == 10)
            {
                mes = "oct";
            }
            else if (month == 11)
            {
                mes = "nov";
            }
            else if (month == 12)
            {
                mes = "dic";
            }

            string comentario = mes;
            Random ran = new Random();
            int numero2 = ran.Next(0, 10000);
            lblBienvenido.Text = "Cantidad de fichas:" + Convert.ToString(Cantidad);
            //generacion de usuarios mediante el ciclo foor
            //declaración de arreglos
            string[] usuarios = new string[Cantidad];
            string[] contraseñas = new string[Cantidad];
            //      
            for (int i = 0; i < Cantidad; i++)
            {
                MK mikrotik = new MK(ip, puerto);
                if (mikrotik.Login(usuario, contraseña))
                {
                    int numero = ran.Next(12000, 99999);
                    int contra = numero;
                    int password = contra;
                    //generacion de usuarios ejemplo prefijo/mes/numero
                    string nombre = prefijo + mes + numero2;
                    mikrotik.Send("/ip/hotspot/user/add");
                    mikrotik.Send("=name=" + nombre);
                    mikrotik.Send("=password=" + password);
                    mikrotik.Send("=profile=" + perfil);
                    mikrotik.Send("=limit-uptime=" + segundos, true);
                    mikrotik.Read();
                    string o = Convert.ToString(password);
                    usuarios[i] = nombre;
                    contraseñas[i] = o;
                }
                numero2 = numero2 + 1;
            }
            DataTable table1 = new DataTable("usuarios");
            table1.Columns.Add("nombre");
            table1.Columns.Add("contraseña");
            table1.Columns.Add("tipo");
            for (int z = 0; z < Cantidad; z++)
            {
                mydatagrid.Rows.Add(usuarios[z] ,contraseñas[z],prefijo);
                table1.Rows.Add(usuarios[z],contraseñas[z],prefijo);
            }
            //DataSet1 set = new DataSet1();
            //set.Tables.Add(table1);
            //lblDataset.Text = Convert.ToString(set.GetXml());
            string cErr = "";
            try
            {
                Reporte rpt = new Reporte();
                int dato = Convert.ToInt16(txtBCantidad.Text);
                DataSet1 dts = new DataSet1();
                DataRow fila;
                for (int t=0;t<dato;t++)
                {
                    fila = dts.Tables[0].NewRow();
                    fila["nombre"] = usuarios[t].ToString();
                    fila["contraseña"] = contraseñas[t].ToString();
                    fila["tipo"] = prefijo.ToString();
                    dts.Tables[0].Rows.Add(fila);
                }
                cErr = rpt.imprimirReport(dts);
                lblDataset.Text = cErr;
            }
            catch(Exception ex)
            {
               
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            //referenciamos el primero objeto
            // existente en el objeto 
            DataTable dt = ds.Tables[0];
            // empezamos el control DataGridView
            mydatagrid.DataSource = dt;
            // otro metodo
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable("usuarios");
            table1.Columns.Add("nombre");
            table1.Columns.Add("contraseña");
            table1.Columns.Add("tipo");
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string ip = txtBIP.Text;
            string usuario = txtBUsuario.Text;
            string contraseña = txtBContraseña.Text;
            int puerto = Convert.ToInt16(txtBPuerto.Text);
            // consultar el nombre de los perfiles que estan en mikrotik
            MK mikrotik = new MK(ip, puerto);

            if (!mikrotik.Login(usuario, contraseña))
            {
                lblMensaje.Text = "no hubo conexión";
                mikrotik.Close();
                return;

            }
            string[] arreglo = new string[4];
            int i = 0;
            mikrotik.Send("/ip/hotspot/user/profile/print",true);
            //mikrotik.Send(".print=sss", true);

            foreach (var h in mikrotik.Read())
            {
                //obtengo los valores en un arreglo
                if (h != "!done")
                {
                    arreglo[i] = h.Split('=').ToString();
                    i++;
                }
            }
            // imprimo el mensaje en la posición 0
            //lblBienvenido.Text = arreglo[0];
            txtInformacion.Text =  arreglo[1];

        }
    }
}

