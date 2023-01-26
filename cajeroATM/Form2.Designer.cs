namespace cajeroATM
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.Button();
            this.cambioClaveBTN = new System.Windows.Forms.Button();
            this.retirarBTN = new System.Windows.Forms.Button();
            this.depositarBTN = new System.Windows.Forms.Button();
            this.saldoBTN = new System.Windows.Forms.Button();
            this.otroValorRetirar1 = new cajeroATM.otroValorRetirar();
            this.otroValorDepositar1 = new cajeroATM.otroValorDepositar();
            this.cambioClave1 = new cajeroATM.cambioClave();
            this.retirar1 = new cajeroATM.retirar();
            this.depositar1 = new cajeroATM.depositar();
            this.consultarSaldo1 = new cajeroATM.consultarSaldo();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Salir);
            this.panel1.Controls.Add(this.cambioClaveBTN);
            this.panel1.Controls.Add(this.retirarBTN);
            this.panel1.Controls.Add(this.depositarBTN);
            this.panel1.Controls.Add(this.saldoBTN);
            this.panel1.Location = new System.Drawing.Point(-5, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 460);
            this.panel1.TabIndex = 4;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Salir.Location = new System.Drawing.Point(17, 348);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(200, 49);
            this.Salir.TabIndex = 9;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // cambioClaveBTN
            // 
            this.cambioClaveBTN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cambioClaveBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambioClaveBTN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cambioClaveBTN.Location = new System.Drawing.Point(17, 276);
            this.cambioClaveBTN.Name = "cambioClaveBTN";
            this.cambioClaveBTN.Size = new System.Drawing.Size(200, 49);
            this.cambioClaveBTN.TabIndex = 8;
            this.cambioClaveBTN.Text = "Cambio Clave";
            this.cambioClaveBTN.UseVisualStyleBackColor = false;
            this.cambioClaveBTN.Click += new System.EventHandler(this.cambioClaveBTN_Click);
            // 
            // retirarBTN
            // 
            this.retirarBTN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.retirarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retirarBTN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.retirarBTN.Location = new System.Drawing.Point(17, 205);
            this.retirarBTN.Name = "retirarBTN";
            this.retirarBTN.Size = new System.Drawing.Size(200, 49);
            this.retirarBTN.TabIndex = 7;
            this.retirarBTN.Text = "Retirar";
            this.retirarBTN.UseVisualStyleBackColor = false;
            this.retirarBTN.Click += new System.EventHandler(this.retirarBTN_Click);
            // 
            // depositarBTN
            // 
            this.depositarBTN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.depositarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositarBTN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.depositarBTN.Location = new System.Drawing.Point(17, 134);
            this.depositarBTN.Name = "depositarBTN";
            this.depositarBTN.Size = new System.Drawing.Size(200, 49);
            this.depositarBTN.TabIndex = 6;
            this.depositarBTN.Text = "Depositar";
            this.depositarBTN.UseVisualStyleBackColor = false;
            this.depositarBTN.Click += new System.EventHandler(this.depositarBTN_Click);
            // 
            // saldoBTN
            // 
            this.saldoBTN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saldoBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoBTN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.saldoBTN.Location = new System.Drawing.Point(17, 66);
            this.saldoBTN.Name = "saldoBTN";
            this.saldoBTN.Size = new System.Drawing.Size(200, 49);
            this.saldoBTN.TabIndex = 5;
            this.saldoBTN.Text = "Saldo";
            this.saldoBTN.UseVisualStyleBackColor = false;
            this.saldoBTN.Click += new System.EventHandler(this.saldoBTN_Click);
            // 
            // otroValorRetirar1
            // 
            this.otroValorRetirar1.Location = new System.Drawing.Point(218, -1);
            this.otroValorRetirar1.Name = "otroValorRetirar1";
            this.otroValorRetirar1.Size = new System.Drawing.Size(585, 455);
            this.otroValorRetirar1.TabIndex = 10;
            this.otroValorRetirar1.Load += new System.EventHandler(this.otroValorRetirar1_Load);
            // 
            // otroValorDepositar1
            // 
            this.otroValorDepositar1.Location = new System.Drawing.Point(218, 4);
            this.otroValorDepositar1.Name = "otroValorDepositar1";
            this.otroValorDepositar1.Size = new System.Drawing.Size(638, 443);
            this.otroValorDepositar1.TabIndex = 9;
            // 
            // cambioClave1
            // 
            this.cambioClave1.Location = new System.Drawing.Point(218, -1);
            this.cambioClave1.Name = "cambioClave1";
            this.cambioClave1.Size = new System.Drawing.Size(605, 451);
            this.cambioClave1.TabIndex = 8;
            // 
            // retirar1
            // 
            this.retirar1.Location = new System.Drawing.Point(218, 4);
            this.retirar1.Name = "retirar1";
            this.retirar1.Size = new System.Drawing.Size(629, 440);
            this.retirar1.TabIndex = 7;
            // 
            // depositar1
            // 
            this.depositar1.Location = new System.Drawing.Point(218, 4);
            this.depositar1.Name = "depositar1";
            this.depositar1.Size = new System.Drawing.Size(627, 449);
            this.depositar1.TabIndex = 6;
            // 
            // consultarSaldo1
            // 
            this.consultarSaldo1.Location = new System.Drawing.Point(218, 32);
            this.consultarSaldo1.Name = "consultarSaldo1";
            this.consultarSaldo1.Size = new System.Drawing.Size(620, 406);
            this.consultarSaldo1.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.otroValorRetirar1);
            this.Controls.Add(this.otroValorDepositar1);
            this.Controls.Add(this.cambioClave1);
            this.Controls.Add(this.retirar1);
            this.Controls.Add(this.depositar1);
            this.Controls.Add(this.consultarSaldo1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button cambioClaveBTN;
        private System.Windows.Forms.Button retirarBTN;
        private System.Windows.Forms.Button depositarBTN;
        private System.Windows.Forms.Button saldoBTN;
        private consultarSaldo consultarSaldo1;
        private depositar depositar1;
        private retirar retirar1;
        private cambioClave cambioClave1;
        private otroValorDepositar otroValorDepositar1;
        private otroValorRetirar otroValorRetirar1;
    }
}