namespace CRUD2
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_MenuMostrar = new Button();
            btn_MenuCrear = new Button();
            label2 = new Label();
            dg_MostrarTodos = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dg_MostrarTodos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_MenuMostrar
            // 
            btn_MenuMostrar.BackColor = Color.PaleVioletRed;
            btn_MenuMostrar.FlatAppearance.BorderColor = Color.LightPink;
            btn_MenuMostrar.FlatAppearance.BorderSize = 3;
            btn_MenuMostrar.FlatStyle = FlatStyle.Flat;
            btn_MenuMostrar.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_MenuMostrar.ForeColor = Color.WhiteSmoke;
            btn_MenuMostrar.Location = new Point(254, 21);
            btn_MenuMostrar.Name = "btn_MenuMostrar";
            btn_MenuMostrar.Size = new Size(102, 39);
            btn_MenuMostrar.TabIndex = 2;
            btn_MenuMostrar.Text = "Mostrar";
            btn_MenuMostrar.UseVisualStyleBackColor = false;
            btn_MenuMostrar.Click += btn_MenuMostrar_Click;
            // 
            // btn_MenuCrear
            // 
            btn_MenuCrear.BackColor = Color.PaleVioletRed;
            btn_MenuCrear.FlatAppearance.BorderColor = Color.LightPink;
            btn_MenuCrear.FlatAppearance.BorderSize = 3;
            btn_MenuCrear.FlatStyle = FlatStyle.Flat;
            btn_MenuCrear.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_MenuCrear.ForeColor = Color.WhiteSmoke;
            btn_MenuCrear.Location = new Point(431, 21);
            btn_MenuCrear.Name = "btn_MenuCrear";
            btn_MenuCrear.Size = new Size(112, 39);
            btn_MenuCrear.TabIndex = 3;
            btn_MenuCrear.Text = "Crear";
            btn_MenuCrear.UseVisualStyleBackColor = false;
            btn_MenuCrear.Click += btn_MenuCrear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(22, 21);
            label2.Name = "label2";
            label2.Size = new Size(151, 23);
            label2.TabIndex = 5;
            label2.Text = "Menú Principal";
            // 
            // dg_MostrarTodos
            // 
            dg_MostrarTodos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_MostrarTodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_MostrarTodos.Location = new Point(22, 113);
            dg_MostrarTodos.Name = "dg_MostrarTodos";
            dg_MostrarTodos.RowTemplate.Height = 25;
            dg_MostrarTodos.Size = new Size(749, 307);
            dg_MostrarTodos.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleVioletRed;
            panel1.Controls.Add(btn_MenuCrear);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_MenuMostrar);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 78);
            panel1.TabIndex = 7;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dg_MostrarTodos);
            ForeColor = Color.Black;
            Name = "FrmPrincipal";
            Text = "Menú inicio";
            ((System.ComponentModel.ISupportInitialize)dg_MostrarTodos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_MenuMostrar;
        private Button btn_MenuCrear;
        private Label label2;
        private DataGridView dg_MostrarTodos;
        private Panel panel1;
    }
}
