using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Actividades_JM_Server
{
    public partial class Form2 : Form
    {
        
        string XMLPreuba = Application.StartupPath + "\\pruba.xml";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(XMLPreuba)) dataSet1.ReadXml(XMLPreuba);
            
        }

        private void actividadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            actividadBindingSource.EndEdit();
            dataSet1.WriteXml(XMLPreuba);
            MessageBox.Show("Los datos se guardaron correctamente");
            actividadDataGridView.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar esta Actividad?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Validate();
                actividadBindingSource.RemoveCurrent();
                dataSet1.WriteXml(XMLPreuba);
                MessageBox.Show("Datos eliminados correctamente");
                actividadDataGridView.Refresh();
            }
        }
    }
}
