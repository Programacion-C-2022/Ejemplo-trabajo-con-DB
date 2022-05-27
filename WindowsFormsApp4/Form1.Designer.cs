namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.TextBoxApellido = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BotonInsertar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BotonModificar = new System.Windows.Forms.Button();
            this.Listar = new System.Windows.Forms.Button();
            this.Grillita = new System.Windows.Forms.DataGridView();
            this.BotonEnumerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grillita)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(117, 8);
            this.TextBoxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(68, 20);
            this.TextBoxID.TabIndex = 0;
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(117, 29);
            this.TextBoxNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(68, 20);
            this.TextBoxNombre.TabIndex = 1;
            // 
            // TextBoxApellido
            // 
            this.TextBoxApellido.Location = new System.Drawing.Point(117, 49);
            this.TextBoxApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxApellido.Name = "TextBoxApellido";
            this.TextBoxApellido.Size = new System.Drawing.Size(68, 20);
            this.TextBoxApellido.TabIndex = 2;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(117, 70);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(68, 20);
            this.TextBoxEmail.TabIndex = 3;
            // 
            // TextBoxTelefono
            // 
            this.TextBoxTelefono.Location = new System.Drawing.Point(117, 91);
            this.TextBoxTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxTelefono.Name = "TextBoxTelefono";
            this.TextBoxTelefono.Size = new System.Drawing.Size(68, 20);
            this.TextBoxTelefono.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefono";
            // 
            // BotonInsertar
            // 
            this.BotonInsertar.Location = new System.Drawing.Point(117, 112);
            this.BotonInsertar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonInsertar.Name = "BotonInsertar";
            this.BotonInsertar.Size = new System.Drawing.Size(67, 25);
            this.BotonInsertar.TabIndex = 11;
            this.BotonInsertar.Text = "Insertar";
            this.BotonInsertar.UseVisualStyleBackColor = true;
            this.BotonInsertar.Click += new System.EventHandler(this.BotonInsertar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 22);
            this.button1.TabIndex = 12;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BotonModificar
            // 
            this.BotonModificar.Location = new System.Drawing.Point(117, 166);
            this.BotonModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.Size = new System.Drawing.Size(67, 22);
            this.BotonModificar.TabIndex = 13;
            this.BotonModificar.Text = "Modificar";
            this.BotonModificar.UseVisualStyleBackColor = true;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // Listar
            // 
            this.Listar.Location = new System.Drawing.Point(117, 193);
            this.Listar.Name = "Listar";
            this.Listar.Size = new System.Drawing.Size(68, 23);
            this.Listar.TabIndex = 14;
            this.Listar.Text = "Listar";
            this.Listar.UseVisualStyleBackColor = true;
            this.Listar.Click += new System.EventHandler(this.Listar_Click);
            // 
            // Grillita
            // 
            this.Grillita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grillita.Location = new System.Drawing.Point(224, 8);
            this.Grillita.Name = "Grillita";
            this.Grillita.Size = new System.Drawing.Size(324, 208);
            this.Grillita.TabIndex = 15;
            // 
            // BotonEnumerar
            // 
            this.BotonEnumerar.Location = new System.Drawing.Point(117, 223);
            this.BotonEnumerar.Name = "BotonEnumerar";
            this.BotonEnumerar.Size = new System.Drawing.Size(67, 23);
            this.BotonEnumerar.TabIndex = 16;
            this.BotonEnumerar.Text = "Enumerar";
            this.BotonEnumerar.UseVisualStyleBackColor = true;
            this.BotonEnumerar.Click += new System.EventHandler(this.BotonEnumerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 282);
            this.Controls.Add(this.BotonEnumerar);
            this.Controls.Add(this.Grillita);
            this.Controls.Add(this.Listar);
            this.Controls.Add(this.BotonModificar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BotonInsertar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxTelefono);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxApellido);
            this.Controls.Add(this.TextBoxNombre);
            this.Controls.Add(this.TextBoxID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Grillita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.TextBox TextBoxApellido;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BotonInsertar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BotonModificar;
        private System.Windows.Forms.Button Listar;
        private System.Windows.Forms.DataGridView Grillita;
        private System.Windows.Forms.Button BotonEnumerar;
    }
}

