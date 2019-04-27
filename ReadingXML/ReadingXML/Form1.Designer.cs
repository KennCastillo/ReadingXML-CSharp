namespace ReadingXML
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ReadXmlButton = new System.Windows.Forms.Button();
            this.ShowSchemaButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AuthorsDataSet = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 319);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(474, 339);
            this.textBox1.TabIndex = 0;
            // 
            // ReadXmlButton
            // 
            this.ReadXmlButton.Location = new System.Drawing.Point(12, 50);
            this.ReadXmlButton.Name = "ReadXmlButton";
            this.ReadXmlButton.Size = new System.Drawing.Size(75, 23);
            this.ReadXmlButton.TabIndex = 1;
            this.ReadXmlButton.Text = "Leer XML";
            this.ReadXmlButton.UseVisualStyleBackColor = true;
            this.ReadXmlButton.Click += new System.EventHandler(this.ReadXmlButton_Click);
            // 
            // ShowSchemaButton
            // 
            this.ShowSchemaButton.Location = new System.Drawing.Point(12, 319);
            this.ShowSchemaButton.Name = "ShowSchemaButton";
            this.ShowSchemaButton.Size = new System.Drawing.Size(107, 23);
            this.ShowSchemaButton.TabIndex = 2;
            this.ShowSchemaButton.Text = "Mostrar Esquema";
            this.ShowSchemaButton.UseVisualStyleBackColor = true;
            this.ShowSchemaButton.Click += new System.EventHandler(this.ShowSchemaButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(907, 211);
            this.dataGridView1.TabIndex = 3;
            // 
            // AuthorsDataSet
            // 
            this.AuthorsDataSet.DataSetName = "AuthorsDataSet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 668);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowSchemaButton);
            this.Controls.Add(this.ReadXmlButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ReadXmlButton;
        private System.Windows.Forms.Button ShowSchemaButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataSet AuthorsDataSet;
    }
}

