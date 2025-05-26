namespace MercadoDescontoBaixaRenda
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.grid_usuarios = new DataViewLib.usercontrol.datagrid.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_beneficios_semana = new DataViewLib.usercontrol.datagrid.DataGridView();
            this.radioBoxField1 = new DataViewLib.usercontrol.field.selection.RadioBoxField();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 61);
            this.panel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CURSOS PROFISSIONALIZANTES";
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(12, 328);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(234, 32);
            this.btn_editar.TabIndex = 39;
            this.btn_editar.Text = "Editar Usuarios";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // grid_usuarios
            // 
            this.grid_usuarios.AutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grid_usuarios.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grid_usuarios.Location = new System.Drawing.Point(11, 105);
            this.grid_usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.grid_usuarios.Name = "grid_usuarios";
            this.grid_usuarios.Size = new System.Drawing.Size(235, 209);
            this.grid_usuarios.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Lista de usuários";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(367, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Cursos do usuario na semana";
            // 
            // grid_beneficios_semana
            // 
            this.grid_beneficios_semana.AutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grid_beneficios_semana.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grid_beneficios_semana.Location = new System.Drawing.Point(366, 105);
            this.grid_beneficios_semana.Margin = new System.Windows.Forms.Padding(2);
            this.grid_beneficios_semana.Name = "grid_beneficios_semana";
            this.grid_beneficios_semana.Size = new System.Drawing.Size(235, 209);
            this.grid_beneficios_semana.TabIndex = 43;
            // 
            // radioBoxField1
            // 
            this.radioBoxField1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.radioBoxField1.ElementColorOff = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.radioBoxField1.ElementColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.radioBoxField1.ElementEditBarVisible = false;
            this.radioBoxField1.ElementText = "Semana";
            this.radioBoxField1.ElementTextColor = System.Drawing.Color.White;
            this.radioBoxField1.ElementTextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBoxField1.ElementTitle = "Escolher semana";
            this.radioBoxField1.ElementTitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBoxField1.ElementTitleTextColor = System.Drawing.Color.White;
            this.radioBoxField1.Location = new System.Drawing.Point(366, 328);
            this.radioBoxField1.Name = "radioBoxField1";
            this.radioBoxField1.Size = new System.Drawing.Size(235, 58);
            this.radioBoxField1.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(617, 398);
            this.Controls.Add(this.radioBoxField1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grid_beneficios_semana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grid_usuarios);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Mercado Vander";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_editar;
        private DataViewLib.usercontrol.datagrid.DataGridView grid_usuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DataViewLib.usercontrol.datagrid.DataGridView grid_beneficios_semana;
        private DataViewLib.usercontrol.field.selection.RadioBoxField radioBoxField1;
    }
}

