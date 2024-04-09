using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Actividades_JM_Server
{
    public partial class Pantalla_Principal : Form
    {
        string XMLDataBase = Application.StartupPath + "\\DBJMActividades.xml"; // String que obtiene la ruta en la que guardara el archivo XML
        public Pantalla_Principal() // Indica que componentes se iniciaran 
        {
            InitializeComponent();
            Timer_Tamaño.Enabled = true;
            Timer_Tamaño.Start();
        }
        private void Pantalla_Principal_Load(object sender, EventArgs e) // Indica que se realizara al cargarse el el Form principal
        {
            if (System.IO.File.Exists(XMLDataBase)) dataSet1.ReadXml(XMLDataBase); // Indica que si existe el archivo "XMLDataBase" lo lea en caso contrario no hacer nada
        }


        #region Crea notificación

        public void Notificacion()  //Crear la notificacion (NotifyIcon)
        {
            Notificacion_Inicio.Text = "Tareas del Servidor Jeronimo Moreno y Asociados SC"; // Texto sobre el icono en la barra de tareas
            Notificacion_Inicio.BalloonTipTitle = "Recuerda realizar estas tareas";          // Titulo de la notificacion
            Notificacion_Inicio.BalloonTipText = "Monitoreo y Mantenimiento del Servidor";   // Texto de la notificacion
            Notificacion_Inicio.BalloonTipIcon = ToolTipIcon.Info;

            Notificacion_Inicio.Visible = true;

            Notificacion_Inicio.ShowBalloonTip(2000); //Duracion del mensaje en la pantalla (se usan milisegundos) 2000 = 2segundos
        }

        private void Notificacion_Inicio_Click(object sender, EventArgs e) //Evento al hace click en el icono de la barra de tareas de windows
        {
            if (this.WindowState == FormWindowState.Normal)     //Si el estado del Form es normal
            {
                this.WindowState = FormWindowState.Minimized;   //Minimizar el Form
            }
            else                                                //Si el estado del Form es minimizado
            {
                this.WindowState = FormWindowState.Normal;      //Abre el Form a tamaño normal
            }
        }

        private void Notificacion_Inicio_BalloonTipClicked(object sender, EventArgs e) //Evento al hacer click en el globo de notificacion
        {
            //Process.Start("");
            WindowState = FormWindowState.Normal;   //Abre el Form a tamaño normal
        }

        #endregion

        #region Inicializa Notificaion
        
        private void Tamaño_Tick(object sender, EventArgs e)    //Monitoria el tamaño del Form
        {
            if (WindowState == FormWindowState.Minimized)       //Si el estado del Form es minimizado
            {
                Timer_Notificacion.Enabled = true;              //Activa el Timer_Notificacion
                Timer_Notificacion.Start();                     //Inicia el Timer_Notificacion
            }
            else                                                //Si el estado del Form es normal
            {
                Timer_Notificacion.Stop();                      //Detiene el Timer_Notificacion
            }
        }
        private void Timer_Notificacion_Tick(object sender, EventArgs e) //Timer para iniciar las Notificaciones
        {
            Notificacion(); //Inicializa el metdodo Notificacion 
        }

        #endregion

        #region Funcionamiento de los botones

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;    //Asinga el estado de la ventana como minimizado
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 180)  //Si el panel azul "MenuVertical" tiene un ancho de 180px
            {
                MenuVertical.Width = 70;                //Cambia el ancho del panel "MenuVertival" a 70px
                Datos.Location = new Point(22, 43);     //Cambia la posicion del datagridview "Datos" 
                Datos.Size = new Size(587, 361);        //Cambia el tamaño del datagridview "Datos"
                grb_actividades.Dock = DockStyle.Fill;  //Modifica el groupbox "grb_actividades" para que rellene el espacio
            }
            else                            //En caso de que el panel azul "MenuVertical" tenga otro tamaño
            {
                MenuVertical.Width = 180;               //Cambia el ancho del panel "MenuVertival" a 180px
                Agrega_Actividad.Visible = false;       //Wsconde el panel 
                Datos.Location = new Point(17, 43);     //Cambia la posicion del datagridview "Datos"
                Datos.Size = new Size(487, 361);
            }

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            actividadBindingSource.AddNew();
            MenuVertical.Width = 70;
            Agrega_Actividad.Visible = true;
            Datos.Location = new Point(5, 43);
            Datos.Size = new Size(390, 361);
            grb_actividades.Dock = DockStyle.Fill;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            actividadBindingSource.EndEdit();
            dataSet1.WriteXml(XMLDataBase);
            MessageBox.Show("Los datos se guardaron correctamente");
            Datos.Refresh();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar esta Actividad?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Validate();
                actividadBindingSource.RemoveCurrent();
                dataSet1.WriteXml(XMLDataBase);
                MessageBox.Show("Datos eliminados correctamente");
                Datos.Refresh();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            MenuVertical.Width = 70;
            Agrega_Actividad.Visible = true;
            Datos.Location = new Point(5, 43);
            Datos.Size = new Size(390, 361);
            grb_actividades.Dock = DockStyle.Fill;
        }


        #endregion

        private void timer1_Tick_1(object sender, EventArgs e)  //Timer para iniciar una accion
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");  //Asigna al label "lblhora" la hora actual con formato hh:mm:ss
            lblFecha.Text = DateTime.Now.ToLongDateString();    //Asigna al label "lblfecha" la fecha del dispositivo
        }
        
        #region Movimiento a la barra det titulo
        
        // Codigo para dar movimiento en la pantalla

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // Codigo para dar movimiento en la pantalla


        // evento MouseDown de la herramienta(s) que tendra movimiento
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e) 
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)  
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // evento MouseDown de la herramienta(s) que tendra movimiento


        #endregion
    }
}
