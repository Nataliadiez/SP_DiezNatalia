namespace CRUD2
{
    partial class FrmMostrar
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
            btn_Modificar = new Button();
            btn_Eliminar = new Button();
            dg_MostrarElementos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg_MostrarElementos).BeginInit();
            SuspendLayout();
            // 
            // btn_Modificar
            // 
            btn_Modificar.BackColor = Color.PaleVioletRed;
            btn_Modificar.FlatStyle = FlatStyle.Flat;
            btn_Modificar.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Modificar.ForeColor = Color.WhiteSmoke;
            btn_Modificar.Location = new Point(77, 298);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(114, 41);
            btn_Modificar.TabIndex = 1;
            btn_Modificar.Text = "Modificar";
            btn_Modificar.UseVisualStyleBackColor = false;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = Color.PaleVioletRed;
            btn_Eliminar.FlatStyle = FlatStyle.Flat;
            btn_Eliminar.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Eliminar.ForeColor = Color.WhiteSmoke;
            btn_Eliminar.Location = new Point(305, 298);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(114, 41);
            btn_Eliminar.TabIndex = 2;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // dg_MostrarElementos
            // 
            dg_MostrarElementos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_MostrarElementos.Location = new Point(36, 25);
            dg_MostrarElementos.Name = "dg_MostrarElementos";
            dg_MostrarElementos.RowTemplate.Height = 25;
            dg_MostrarElementos.Size = new Size(454, 245);
            dg_MostrarElementos.TabIndex = 3;
            dg_MostrarElementos.SelectionChanged += dg_MostrarElementos_SelectionChanged;
            // 
            // FrmMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(529, 405);
            Controls.Add(dg_MostrarElementos);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Modificar);
            ForeColor = Color.Black;
            Name = "FrmMostrar";
            Text = "Menú mostrar";
            ((System.ComponentModel.ISupportInitialize)dg_MostrarElementos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_Modificar;
        private Button btn_Eliminar;
        private DataGridView dg_MostrarElementos;
    }
}