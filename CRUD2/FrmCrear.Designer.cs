namespace CRUD2
{
    partial class FrmCrear
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
            txt_Nombre = new TextBox();
            txt_Puesto = new TextBox();
            txt_Salario = new TextBox();
            btn_CrearUsuario = new Button();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.BorderStyle = BorderStyle.FixedSingle;
            txt_Nombre.Location = new Point(45, 33);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.PlaceholderText = "Nombre";
            txt_Nombre.Size = new Size(169, 23);
            txt_Nombre.TabIndex = 0;
            // 
            // txt_Puesto
            // 
            txt_Puesto.Location = new Point(45, 74);
            txt_Puesto.Name = "txt_Puesto";
            txt_Puesto.PlaceholderText = "Puesto";
            txt_Puesto.Size = new Size(169, 23);
            txt_Puesto.TabIndex = 1;
            // 
            // txt_Salario
            // 
            txt_Salario.Location = new Point(45, 120);
            txt_Salario.Name = "txt_Salario";
            txt_Salario.PlaceholderText = "Salario";
            txt_Salario.Size = new Size(169, 23);
            txt_Salario.TabIndex = 2;
            // 
            // btn_CrearUsuario
            // 
            btn_CrearUsuario.BackColor = Color.PaleVioletRed;
            btn_CrearUsuario.FlatStyle = FlatStyle.Flat;
            btn_CrearUsuario.ForeColor = Color.WhiteSmoke;
            btn_CrearUsuario.Location = new Point(45, 168);
            btn_CrearUsuario.Name = "btn_CrearUsuario";
            btn_CrearUsuario.Size = new Size(169, 23);
            btn_CrearUsuario.TabIndex = 3;
            btn_CrearUsuario.Text = "Aceptar";
            btn_CrearUsuario.UseVisualStyleBackColor = false;
            btn_CrearUsuario.Click += btn_CrearUsuario_Click;
            // 
            // FrmCrear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(252, 258);
            Controls.Add(btn_CrearUsuario);
            Controls.Add(txt_Salario);
            Controls.Add(txt_Puesto);
            Controls.Add(txt_Nombre);
            Name = "FrmCrear";
            Text = "FrmCrear";
            Load += FrmCrear_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Nombre;
        private TextBox txt_Puesto;
        private TextBox txt_Salario;
        private Button btn_CrearUsuario;
    }
}