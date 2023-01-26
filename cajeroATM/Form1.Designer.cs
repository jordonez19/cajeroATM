namespace cajeroATM
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
            this.ingresarBTN = new System.Windows.Forms.Button();
            this.celularTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.claveTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ingresarBTN
            // 
            this.ingresarBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ingresarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ingresarBTN.Location = new System.Drawing.Point(307, 343);
            this.ingresarBTN.Name = "ingresarBTN";
            this.ingresarBTN.Size = new System.Drawing.Size(196, 53);
            this.ingresarBTN.TabIndex = 1;
            this.ingresarBTN.Text = "Ingresar";
            this.ingresarBTN.UseVisualStyleBackColor = false;
            this.ingresarBTN.Click += new System.EventHandler(this.ingresarBTN_Click);
            // 
            // celularTXT
            // 
            this.celularTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celularTXT.Location = new System.Drawing.Point(390, 156);
            this.celularTXT.Name = "celularTXT";
            this.celularTXT.Size = new System.Drawing.Size(214, 35);
            this.celularTXT.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(127, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numero celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(178, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 39);
            this.label3.TabIndex = 14;
            this.label3.Text = "Numero Pin:";
            // 
            // claveTXT
            // 
            this.claveTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claveTXT.Location = new System.Drawing.Point(390, 256);
            this.claveTXT.Name = "claveTXT";
            this.claveTXT.Size = new System.Drawing.Size(214, 35);
            this.claveTXT.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(281, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 54);
            this.label2.TabIndex = 15;
            this.label2.Text = "ATM - UDC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.claveTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.celularTXT);
            this.Controls.Add(this.ingresarBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ingresarBTN;
        private System.Windows.Forms.TextBox celularTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox claveTXT;
        private System.Windows.Forms.Label label2;
    }
}

