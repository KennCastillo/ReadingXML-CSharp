using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReadingXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReadXmlButton_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "E:/ejemplos/ReadingXML/ReadingXML/authors.xml";

            AuthorsDataSet.ReadXml(rutaArchivo);

            dataGridView1.DataSource = AuthorsDataSet;
            dataGridView1.DataMember = "Authors";
        }

        private void ShowSchemaButton_Click(object sender, EventArgs e)
        {
            StringWriter swXML = new StringWriter();
            AuthorsDataSet.WriteXmlSchema(swXML);
            textBox1.Text = swXML.ToString();
        }
    }
}
