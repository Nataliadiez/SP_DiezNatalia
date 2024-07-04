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
            ((System.ComponentModel.ISupportInitialize)dg_MostrarTodos).BeginInit();
            SuspendLayout();
            // 
            // btn_MenuMostrar
            // 
            btn_MenuMostrar.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_MenuMostrar.ForeColor = Color.Black;
            btn_MenuMostrar.Location = new Point(248, 12);
            btn_MenuMostrar.Name = "btn_MenuMostrar";
            btn_MenuMostrar.Size = new Size(102, 39);
            btn_MenuMostrar.TabIndex = 2;
            btn_MenuMostrar.Text = "Mostrar";
            btn_MenuMostrar.UseVisualStyleBackColor = true;
            btn_MenuMostrar.Click += btn_MenuMostrar_Click;
            // 
            // btn_MenuCrear
            // 
            btn_MenuCrear.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_MenuCrear.ForeColor = Color.Black;
            btn_MenuCrear.Location = new Point(404, 12);
            btn_MenuCrear.Name = "btn_MenuCrear";
            btn_MenuCrear.Size = new Size(102, 39);
            btn_MenuCrear.TabIndex = 3;
            btn_MenuCrear.Text = "Crear";
            btn_MenuCrear.UseVisualStyleBackColor = true;
            btn_MenuCrear.Click += btn_MenuCrear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(28, 20);
            label2.Name = "label2";
            label2.Size = new Size(151, 23);
            label2.TabIndex = 5;
            label2.Text = "Menú Principal";
            // 
            // dg_MostrarTodos
            // 
            dg_MostrarTodos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_MostrarTodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_MostrarTodos.Location = new Point(20, 103);
            dg_MostrarTodos.Name = "dg_MostrarTodos";
            dg_MostrarTodos.RowTemplate.Height = 25;
            dg_MostrarTodos.Size = new Size(749, 307);
            dg_MostrarTodos.TabIndex = 6;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dg_MostrarTodos);
            Controls.Add(label2);
            Controls.Add(btn_MenuCrear);
            Controls.Add(btn_MenuMostrar);
            ForeColor = Color.Black;
            Name = "FrmPrincipal";
            Text = "Menú inicio";
            ((System.ComponentModel.ISupportInitialize)dg_MostrarTodos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_MenuMostrar;
        private Button btn_MenuCrear;
        private Label label2;
        private DataGridView dg_MostrarTodos;
    }
}
