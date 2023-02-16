namespace SolutionParking.Views
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.TituloLabel = new System.Windows.Forms.Label();
            this.NumeroVagasTextBox = new System.Windows.Forms.TextBox();
            this.LoginTxtVagasLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaidaVeiculoBtn = new System.Windows.Forms.Button();
            this.EntradaVeiculoButton1 = new System.Windows.Forms.Button();
            this.VeiculosEstacionadosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TituloLabel
            // 
            this.TituloLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.TituloLabel.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TituloLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TituloLabel.Location = new System.Drawing.Point(-12, 0);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(800, 90);
            this.TituloLabel.TabIndex = 1;
            this.TituloLabel.Text = "Solution Parking";
            this.TituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumeroVagasTextBox
            // 
            this.NumeroVagasTextBox.Enabled = false;
            this.NumeroVagasTextBox.Location = new System.Drawing.Point(112, 119);
            this.NumeroVagasTextBox.Name = "NumeroVagasTextBox";
            this.NumeroVagasTextBox.Size = new System.Drawing.Size(100, 23);
            this.NumeroVagasTextBox.TabIndex = 2;
            // 
            // LoginTxtVagasLabel
            // 
            this.LoginTxtVagasLabel.AutoSize = true;
            this.LoginTxtVagasLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginTxtVagasLabel.Location = new System.Drawing.Point(12, 119);
            this.LoginTxtVagasLabel.Name = "LoginTxtVagasLabel";
            this.LoginTxtVagasLabel.Size = new System.Drawing.Size(94, 20);
            this.LoginTxtVagasLabel.TabIndex = 4;
            this.LoginTxtVagasLabel.Text = "Nº de Vagas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(400, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ultima Entrada";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(520, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            // 
            // SaidaVeiculoBtn
            // 
            this.SaidaVeiculoBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.SaidaVeiculoBtn.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaidaVeiculoBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaidaVeiculoBtn.Location = new System.Drawing.Point(307, 286);
            this.SaidaVeiculoBtn.Name = "SaidaVeiculoBtn";
            this.SaidaVeiculoBtn.Size = new System.Drawing.Size(154, 35);
            this.SaidaVeiculoBtn.TabIndex = 7;
            this.SaidaVeiculoBtn.Text = "Saida Veiculo";
            this.SaidaVeiculoBtn.UseVisualStyleBackColor = false;
            this.SaidaVeiculoBtn.Click += new System.EventHandler(this.SaidaVeiculoBtn_Click);
            // 
            // EntradaVeiculoButton1
            // 
            this.EntradaVeiculoButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.EntradaVeiculoButton1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntradaVeiculoButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EntradaVeiculoButton1.Location = new System.Drawing.Point(58, 286);
            this.EntradaVeiculoButton1.Name = "EntradaVeiculoButton1";
            this.EntradaVeiculoButton1.Size = new System.Drawing.Size(154, 35);
            this.EntradaVeiculoButton1.TabIndex = 8;
            this.EntradaVeiculoButton1.Text = "Entrada Veiculo";
            this.EntradaVeiculoButton1.UseVisualStyleBackColor = false;
            this.EntradaVeiculoButton1.Click += new System.EventHandler(this.EntradaVeiculoButton1_Click);
            // 
            // VeiculosEstacionadosButton
            // 
            this.VeiculosEstacionadosButton.BackColor = System.Drawing.Color.SeaGreen;
            this.VeiculosEstacionadosButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VeiculosEstacionadosButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VeiculosEstacionadosButton.Location = new System.Drawing.Point(535, 286);
            this.VeiculosEstacionadosButton.Name = "VeiculosEstacionadosButton";
            this.VeiculosEstacionadosButton.Size = new System.Drawing.Size(160, 35);
            this.VeiculosEstacionadosButton.TabIndex = 9;
            this.VeiculosEstacionadosButton.Text = "Veiculos Estacionados";
            this.VeiculosEstacionadosButton.UseVisualStyleBackColor = false;
            this.VeiculosEstacionadosButton.Click += new System.EventHandler(this.VeiculosEstacionadosButton_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.VeiculosEstacionadosButton);
            this.Controls.Add(this.EntradaVeiculoButton1);
            this.Controls.Add(this.SaidaVeiculoBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LoginTxtVagasLabel);
            this.Controls.Add(this.NumeroVagasTextBox);
            this.Controls.Add(this.TituloLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "S.Parking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TituloLabel;
        private TextBox NumeroVagasTextBox;
        private Label LoginTxtVagasLabel;
        private Label label1;
        private TextBox textBox1;
        private Button SaidaVeiculoBtn;
        private Button EntradaVeiculoButton1;
        private Button VeiculosEstacionadosButton;
    }
}