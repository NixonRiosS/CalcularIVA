namespace Taller1_CalcularelIVAdeunProducto
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
            this.txt_valorp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_valoriva = new System.Windows.Forms.Label();
            this.lbl_valorfinal = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular IVA de un Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el valor del producto:";
            // 
            // txt_valorp
            // 
            this.txt_valorp.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorp.Location = new System.Drawing.Point(376, 101);
            this.txt_valorp.Name = "txt_valorp";
            this.txt_valorp.Size = new System.Drawing.Size(157, 39);
            this.txt_valorp.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor IVA:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor Final:";
            this.label4.Visible = false;
            // 
            // lbl_valoriva
            // 
            this.lbl_valoriva.AutoSize = true;
            this.lbl_valoriva.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valoriva.Location = new System.Drawing.Point(153, 243);
            this.lbl_valoriva.Name = "lbl_valoriva";
            this.lbl_valoriva.Size = new System.Drawing.Size(82, 31);
            this.lbl_valoriva.TabIndex = 5;
            this.lbl_valoriva.Text = "label5";
            this.lbl_valoriva.Visible = false;
            // 
            // lbl_valorfinal
            // 
            this.lbl_valorfinal.AutoSize = true;
            this.lbl_valorfinal.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorfinal.Location = new System.Drawing.Point(153, 342);
            this.lbl_valorfinal.Name = "lbl_valorfinal";
            this.lbl_valorfinal.Size = new System.Drawing.Size(82, 31);
            this.lbl_valorfinal.TabIndex = 6;
            this.lbl_valorfinal.Text = "label6";
            this.lbl_valorfinal.Visible = false;
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(561, 181);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(134, 70);
            this.btn_calcular.TabIndex = 7;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(561, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 70);
            this.button1.TabIndex = 8;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(705, 382);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(59, 37);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "Exit";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Señor(a) Usuario, el IVA es del 19%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_valorfinal);
            this.Controls.Add(this.lbl_valoriva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_valorp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_valorp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_valoriva;
        private System.Windows.Forms.Label lbl_valorfinal;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label5;
    }
}

