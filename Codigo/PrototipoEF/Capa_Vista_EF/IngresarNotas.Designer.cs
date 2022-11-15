
namespace Capa_Vista_EF
{
    partial class IngresarNotas
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
            this.txtTerceraNota = new System.Windows.Forms.TextBox();
            this.txtIDAlumnos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrimeraNota = new System.Windows.Forms.TextBox();
            this.txtIDMaestros = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSegundaNota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTerceraNota
            // 
            this.txtTerceraNota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerceraNota.Location = new System.Drawing.Point(749, 356);
            this.txtTerceraNota.Name = "txtTerceraNota";
            this.txtTerceraNota.Size = new System.Drawing.Size(52, 27);
            this.txtTerceraNota.TabIndex = 55;
            this.txtTerceraNota.Tag = "tercera_nota";
            // 
            // txtIDAlumnos
            // 
            this.txtIDAlumnos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDAlumnos.Location = new System.Drawing.Point(353, 266);
            this.txtIDAlumnos.Name = "txtIDAlumnos";
            this.txtIDAlumnos.Size = new System.Drawing.Size(163, 27);
            this.txtIDAlumnos.TabIndex = 54;
            this.txtIDAlumnos.Tag = "codigo_asig_alumnos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Codigo Asignación Alumnos";
            // 
            // txtPrimeraNota
            // 
            this.txtPrimeraNota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeraNota.Location = new System.Drawing.Point(206, 359);
            this.txtPrimeraNota.Name = "txtPrimeraNota";
            this.txtPrimeraNota.Size = new System.Drawing.Size(66, 27);
            this.txtPrimeraNota.TabIndex = 50;
            this.txtPrimeraNota.Tag = "primera_nota";
            // 
            // txtIDMaestros
            // 
            this.txtIDMaestros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMaestros.Location = new System.Drawing.Point(353, 313);
            this.txtIDMaestros.Name = "txtIDMaestros";
            this.txtIDMaestros.Size = new System.Drawing.Size(163, 27);
            this.txtIDMaestros.TabIndex = 49;
            this.txtIDMaestros.Tag = "codigo_asig_maestros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Código Asignación Maestros:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(180, 223);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(96, 27);
            this.txtID.TabIndex = 47;
            this.txtID.Tag = "codigo_notas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(809, 261);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.Tag = "notas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(303, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Segunda Parcial";
            // 
            // txtSegundaNota
            // 
            this.txtSegundaNota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundaNota.Location = new System.Drawing.Point(492, 356);
            this.txtSegundaNota.Name = "txtSegundaNota";
            this.txtSegundaNota.Size = new System.Drawing.Size(63, 27);
            this.txtSegundaNota.TabIndex = 43;
            this.txtSegundaNota.Tag = "segunda_nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(595, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Examen Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Primer Parcial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Código: ";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(44, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(771, 187);
            this.navegador1.TabIndex = 29;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Ayuda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IngresarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 691);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTerceraNota);
            this.Controls.Add(this.txtIDAlumnos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrimeraNota);
            this.Controls.Add(this.txtIDMaestros);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSegundaNota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Name = "IngresarNotas";
            this.Text = "IngresarNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txtTerceraNota;
        private System.Windows.Forms.TextBox txtIDAlumnos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrimeraNota;
        private System.Windows.Forms.TextBox txtIDMaestros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSegundaNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}