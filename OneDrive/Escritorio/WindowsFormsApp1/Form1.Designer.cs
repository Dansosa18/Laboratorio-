namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cargar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.COMPANIA = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.TextBox();
            this.FECHA = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GENERACION = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GENERACION)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Byron Rene Pastor Flores 0905-23-7312";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Victor Daniel Sosa Lopez 0905-23-8230";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 319);
            this.dataGridView1.TabIndex = 2;
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(527, 34);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(75, 23);
            this.cargar.TabIndex = 3;
            this.cargar.Text = "cargar";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(527, 66);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(261, 20);
            this.ID.TabIndex = 4;
            // 
            // COMPANIA
            // 
            this.COMPANIA.Location = new System.Drawing.Point(527, 126);
            this.COMPANIA.Name = "COMPANIA";
            this.COMPANIA.Size = new System.Drawing.Size(261, 20);
            this.COMPANIA.TabIndex = 5;
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(527, 96);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(261, 20);
            this.NAME.TabIndex = 6;
            this.NAME.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // FECHA
            // 
            this.FECHA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FECHA.Location = new System.Drawing.Point(527, 156);
            this.FECHA.Name = "FECHA";
            this.FECHA.Size = new System.Drawing.Size(261, 20);
            this.FECHA.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "insertar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(623, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "borrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // GENERACION
            // 
            this.GENERACION.Location = new System.Drawing.Point(527, 186);
            this.GENERACION.Name = "GENERACION";
            this.GENERACION.Size = new System.Drawing.Size(261, 20);
            this.GENERACION.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GENERACION);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FECHA);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.COMPANIA);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GENERACION)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox COMPANIA;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.DateTimePicker FECHA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown GENERACION;
    }
}

