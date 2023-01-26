namespace cajeroATM
{
    partial class cambioClave
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cambiarClaveBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nuevaClaveTXT = new System.Windows.Forms.TextBox();
            this.confirmarClaveTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(190, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nueva Clave";
            // 
            // cambiarClaveBTN
            // 
            this.cambiarClaveBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cambiarClaveBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiarClaveBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cambiarClaveBTN.Location = new System.Drawing.Point(210, 334);
            this.cambiarClaveBTN.Name = "cambiarClaveBTN";
            this.cambiarClaveBTN.Size = new System.Drawing.Size(166, 45);
            this.cambiarClaveBTN.TabIndex = 12;
            this.cambiarClaveBTN.Text = "Cambiar";
            this.cambiarClaveBTN.UseVisualStyleBackColor = false;
            this.cambiarClaveBTN.Click += new System.EventHandler(this.cambiarClaveBTN_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(98, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Confirmar Nueva Clave";
            // 
            // nuevaClaveTXT
            // 
            this.nuevaClaveTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaClaveTXT.Location = new System.Drawing.Point(189, 166);
            this.nuevaClaveTXT.Name = "nuevaClaveTXT";
            this.nuevaClaveTXT.Size = new System.Drawing.Size(214, 35);
            this.nuevaClaveTXT.TabIndex = 16;
            // 
            // confirmarClaveTXT
            // 
            this.confirmarClaveTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarClaveTXT.Location = new System.Drawing.Point(189, 271);
            this.confirmarClaveTXT.Name = "confirmarClaveTXT";
            this.confirmarClaveTXT.Size = new System.Drawing.Size(214, 35);
            this.confirmarClaveTXT.TabIndex = 17;
            // 
            // cambioClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.confirmarClaveTXT);
            this.Controls.Add(this.nuevaClaveTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cambiarClaveBTN);
            this.Name = "cambioClave";
            this.Size = new System.Drawing.Size(605, 451);
            this.Load += new System.EventHandler(this.cambioClave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cambiarClaveBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nuevaClaveTXT;
        private System.Windows.Forms.TextBox confirmarClaveTXT;
    }
}
