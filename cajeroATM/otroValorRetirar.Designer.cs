namespace cajeroATM
{
    partial class otroValorRetirar
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.retirarTXT = new System.Windows.Forms.TextBox();
            this.depositarBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(169, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(193, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ingresa el valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(157, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cuanto desea retirar";
            // 
            // retirarTXT
            // 
            this.retirarTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retirarTXT.Location = new System.Drawing.Point(211, 224);
            this.retirarTXT.Name = "retirarTXT";
            this.retirarTXT.Size = new System.Drawing.Size(214, 35);
            this.retirarTXT.TabIndex = 13;
            // 
            // depositarBTN
            // 
            this.depositarBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.depositarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositarBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.depositarBTN.Location = new System.Drawing.Point(235, 282);
            this.depositarBTN.Name = "depositarBTN";
            this.depositarBTN.Size = new System.Drawing.Size(166, 45);
            this.depositarBTN.TabIndex = 12;
            this.depositarBTN.Text = "Retirar";
            this.depositarBTN.UseVisualStyleBackColor = false;
            this.depositarBTN.Click += new System.EventHandler(this.depositarBTN_Click);
            // 
            // otroValorRetirar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retirarTXT);
            this.Controls.Add(this.depositarBTN);
            this.Name = "otroValorRetirar";
            this.Size = new System.Drawing.Size(656, 455);
            this.Load += new System.EventHandler(this.otroValorRetirar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox retirarTXT;
        private System.Windows.Forms.Button depositarBTN;
    }
}
