namespace EnergyTeste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CalcularEnergy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ValorTarifa = new System.Windows.Forms.Label();
            this.ValorConta = new System.Windows.Forms.Label();
            this.ConsumoKWH = new System.Windows.Forms.Label();
            this.ConsumoKWH2 = new System.Windows.Forms.TextBox();
            this.ValorTarifa2 = new System.Windows.Forms.TextBox();
            this.ValorConta2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalcularEnergy
            // 
            this.CalcularEnergy.BackColor = System.Drawing.Color.Transparent;
            this.CalcularEnergy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CalcularEnergy.FlatAppearance.BorderSize = 0;
            this.CalcularEnergy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CalcularEnergy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CalcularEnergy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcularEnergy.ForeColor = System.Drawing.Color.Transparent;
            this.CalcularEnergy.Location = new System.Drawing.Point(91, 495);
            this.CalcularEnergy.Name = "CalcularEnergy";
            this.CalcularEnergy.Size = new System.Drawing.Size(254, 57);
            this.CalcularEnergy.TabIndex = 0;
            this.CalcularEnergy.UseVisualStyleBackColor = false;
            this.CalcularEnergy.Click += new System.EventHandler(this.CalcularEnergy_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ValorTarifa
            // 
            this.ValorTarifa.AutoSize = true;
            this.ValorTarifa.BackColor = System.Drawing.Color.Transparent;
            this.ValorTarifa.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTarifa.Location = new System.Drawing.Point(303, 396);
            this.ValorTarifa.Name = "ValorTarifa";
            this.ValorTarifa.Size = new System.Drawing.Size(0, 36);
            this.ValorTarifa.TabIndex = 2;
            // 
            // ValorConta
            // 
            this.ValorConta.AutoSize = true;
            this.ValorConta.BackColor = System.Drawing.Color.Transparent;
            this.ValorConta.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorConta.Location = new System.Drawing.Point(303, 622);
            this.ValorConta.Name = "ValorConta";
            this.ValorConta.Size = new System.Drawing.Size(0, 36);
            this.ValorConta.TabIndex = 3;
            // 
            // ConsumoKWH
            // 
            this.ConsumoKWH.AutoSize = true;
            this.ConsumoKWH.BackColor = System.Drawing.Color.Transparent;
            this.ConsumoKWH.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsumoKWH.Location = new System.Drawing.Point(114, 283);
            this.ConsumoKWH.Name = "ConsumoKWH";
            this.ConsumoKWH.Size = new System.Drawing.Size(0, 36);
            this.ConsumoKWH.TabIndex = 4;
            // 
            // ConsumoKWH2
            // 
            this.ConsumoKWH2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsumoKWH2.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsumoKWH2.ForeColor = System.Drawing.Color.Black;
            this.ConsumoKWH2.Location = new System.Drawing.Point(107, 281);
            this.ConsumoKWH2.MaximumSize = new System.Drawing.Size(203, 36);
            this.ConsumoKWH2.MinimumSize = new System.Drawing.Size(203, 36);
            this.ConsumoKWH2.Name = "ConsumoKWH2";
            this.ConsumoKWH2.Size = new System.Drawing.Size(203, 36);
            this.ConsumoKWH2.TabIndex = 5;
            this.ConsumoKWH2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ValorTarifa2
            // 
            this.ValorTarifa2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ValorTarifa2.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTarifa2.ForeColor = System.Drawing.Color.Black;
            this.ValorTarifa2.Location = new System.Drawing.Point(278, 388);
            this.ValorTarifa2.Name = "ValorTarifa2";
            this.ValorTarifa2.Size = new System.Drawing.Size(203, 48);
            this.ValorTarifa2.TabIndex = 6;
            this.ValorTarifa2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ValorConta2
            // 
            this.ValorConta2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ValorConta2.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorConta2.ForeColor = System.Drawing.Color.Black;
            this.ValorConta2.Location = new System.Drawing.Point(278, 613);
            this.ValorConta2.Name = "ValorConta2";
            this.ValorConta2.Size = new System.Drawing.Size(218, 48);
            this.ValorConta2.TabIndex = 7;
            this.ValorConta2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.ValorConta2);
            this.Controls.Add(this.ValorTarifa2);
            this.Controls.Add(this.ConsumoKWH2);
            this.Controls.Add(this.ConsumoKWH);
            this.Controls.Add(this.ValorConta);
            this.Controls.Add(this.ValorTarifa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcularEnergy);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcularEnergy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ValorTarifa;
        private System.Windows.Forms.Label ValorConta;
        private System.Windows.Forms.Label ConsumoKWH;
        private System.Windows.Forms.TextBox ConsumoKWH2;
        private System.Windows.Forms.TextBox ValorTarifa2;
        private System.Windows.Forms.TextBox ValorConta2;
    }
}

