namespace ProjetoSoma
{
    partial class frm
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
            this.lblPrimeiroNúmero = new System.Windows.Forms.Label();
            this.txbPrimeiroNumero = new System.Windows.Forms.TextBox();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.ppnSomar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txbSegundoNumero = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ppnMultiplicar = new System.Windows.Forms.Button();
            this.ppnSubtrair = new System.Windows.Forms.Button();
            this.ppnDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeiroNúmero
            // 
            this.lblPrimeiroNúmero.AutoSize = true;
            this.lblPrimeiroNúmero.Location = new System.Drawing.Point(129, 51);
            this.lblPrimeiroNúmero.Name = "lblPrimeiroNúmero";
            this.lblPrimeiroNúmero.Size = new System.Drawing.Size(120, 13);
            this.lblPrimeiroNúmero.TabIndex = 0;
            this.lblPrimeiroNúmero.Text = "Digite o primeiro número";
            // 
            // txbPrimeiroNumero
            // 
            this.txbPrimeiroNumero.Location = new System.Drawing.Point(129, 67);
            this.txbPrimeiroNumero.Name = "txbPrimeiroNumero";
            this.txbPrimeiroNumero.Size = new System.Drawing.Size(185, 20);
            this.txbPrimeiroNumero.TabIndex = 1;
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Location = new System.Drawing.Point(129, 145);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(125, 13);
            this.lblSegundoNumero.TabIndex = 2;
            this.lblSegundoNumero.Text = "Digite o segundo número";
            // 
            // ppnSomar
            // 
            this.ppnSomar.Location = new System.Drawing.Point(132, 222);
            this.ppnSomar.Name = "ppnSomar";
            this.ppnSomar.Size = new System.Drawing.Size(75, 23);
            this.ppnSomar.TabIndex = 4;
            this.ppnSomar.Text = "Somar";
            this.ppnSomar.UseVisualStyleBackColor = true;
            this.ppnSomar.Click += new System.EventHandler(this.ppnSomar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(194, 301);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // txbSegundoNumero
            // 
            this.txbSegundoNumero.Location = new System.Drawing.Point(129, 161);
            this.txbSegundoNumero.Name = "txbSegundoNumero";
            this.txbSegundoNumero.Size = new System.Drawing.Size(185, 20);
            this.txbSegundoNumero.TabIndex = 3;
            // 
            // toolTip
            // 
            this.toolTip.ToolTipTitle = "Clique para somar";
            // 
            // ppnMultiplicar
            // 
            this.ppnMultiplicar.Location = new System.Drawing.Point(132, 260);
            this.ppnMultiplicar.Name = "ppnMultiplicar";
            this.ppnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.ppnMultiplicar.TabIndex = 6;
            this.ppnMultiplicar.Text = "Multiplicar";
            this.ppnMultiplicar.UseVisualStyleBackColor = true;
            this.ppnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // ppnSubtrair
            // 
            this.ppnSubtrair.Location = new System.Drawing.Point(239, 222);
            this.ppnSubtrair.Name = "ppnSubtrair";
            this.ppnSubtrair.Size = new System.Drawing.Size(75, 23);
            this.ppnSubtrair.TabIndex = 7;
            this.ppnSubtrair.Text = "Subtrair";
            this.ppnSubtrair.UseVisualStyleBackColor = true;
            this.ppnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // ppnDividir
            // 
            this.ppnDividir.Location = new System.Drawing.Point(239, 260);
            this.ppnDividir.Name = "ppnDividir";
            this.ppnDividir.Size = new System.Drawing.Size(75, 23);
            this.ppnDividir.TabIndex = 8;
            this.ppnDividir.Text = "Dividir";
            this.ppnDividir.UseVisualStyleBackColor = true;
            this.ppnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(436, 338);
            this.Controls.Add(this.ppnDividir);
            this.Controls.Add(this.ppnSubtrair);
            this.Controls.Add(this.ppnMultiplicar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.ppnSomar);
            this.Controls.Add(this.txbSegundoNumero);
            this.Controls.Add(this.lblSegundoNumero);
            this.Controls.Add(this.txbPrimeiroNumero);
            this.Controls.Add(this.lblPrimeiroNúmero);
            this.Name = "frm";
            this.Text = "Somar dois números";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroNúmero;
        private System.Windows.Forms.TextBox txbPrimeiroNumero;
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.Button ppnSomar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txbSegundoNumero;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button ppnMultiplicar;
        private System.Windows.Forms.Button ppnSubtrair;
        private System.Windows.Forms.Button ppnDividir;
    }
}

