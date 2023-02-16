namespace SolutionParking.Views
{
    partial class SaidaVeiculoForm
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
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EntradaVeiculoButton1 = new System.Windows.Forms.Button();
            this.LoginTxtVagasLabel = new System.Windows.Forms.Label();
            this.PlacaVeiculoTextBox = new System.Windows.Forms.TextBox();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.PlacaRetornoLabel = new System.Windows.Forms.Label();
            this.PlacaRetornoTextBox = new System.Windows.Forms.TextBox();
            this.TipoVeiculoLabel = new System.Windows.Forms.Label();
            this.TVeiculoRetornoTextBox = new System.Windows.Forms.TextBox();
            this.PesquisarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.CancelarBtn.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelarBtn.Location = new System.Drawing.Point(588, 326);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(154, 35);
            this.CancelarBtn.TabIndex = 34;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = false;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(367, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Data de entrada";
            // 
            // EntradaDateTimePicker
            // 
            this.EntradaDateTimePicker.Location = new System.Drawing.Point(494, 117);
            this.EntradaDateTimePicker.Name = "EntradaDateTimePicker";
            this.EntradaDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.EntradaDateTimePicker.TabIndex = 30;
            // 
            // EntradaVeiculoButton1
            // 
            this.EntradaVeiculoButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.EntradaVeiculoButton1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntradaVeiculoButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EntradaVeiculoButton1.Location = new System.Drawing.Point(411, 326);
            this.EntradaVeiculoButton1.Name = "EntradaVeiculoButton1";
            this.EntradaVeiculoButton1.Size = new System.Drawing.Size(154, 35);
            this.EntradaVeiculoButton1.TabIndex = 28;
            this.EntradaVeiculoButton1.Text = "Salvar";
            this.EntradaVeiculoButton1.UseVisualStyleBackColor = false;
            // 
            // LoginTxtVagasLabel
            // 
            this.LoginTxtVagasLabel.AutoSize = true;
            this.LoginTxtVagasLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginTxtVagasLabel.Location = new System.Drawing.Point(25, 117);
            this.LoginTxtVagasLabel.Name = "LoginTxtVagasLabel";
            this.LoginTxtVagasLabel.Size = new System.Drawing.Size(45, 20);
            this.LoginTxtVagasLabel.TabIndex = 26;
            this.LoginTxtVagasLabel.Text = "Placa";
            // 
            // PlacaVeiculoTextBox
            // 
            this.PlacaVeiculoTextBox.Location = new System.Drawing.Point(76, 117);
            this.PlacaVeiculoTextBox.Name = "PlacaVeiculoTextBox";
            this.PlacaVeiculoTextBox.Size = new System.Drawing.Size(100, 23);
            this.PlacaVeiculoTextBox.TabIndex = 25;
            // 
            // TituloLabel
            // 
            this.TituloLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.TituloLabel.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TituloLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TituloLabel.Location = new System.Drawing.Point(0, 0);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(800, 90);
            this.TituloLabel.TabIndex = 24;
            this.TituloLabel.Text = "Solution Parking";
            this.TituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlacaRetornoLabel
            // 
            this.PlacaRetornoLabel.AutoSize = true;
            this.PlacaRetornoLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlacaRetornoLabel.Location = new System.Drawing.Point(27, 220);
            this.PlacaRetornoLabel.Name = "PlacaRetornoLabel";
            this.PlacaRetornoLabel.Size = new System.Drawing.Size(45, 20);
            this.PlacaRetornoLabel.TabIndex = 36;
            this.PlacaRetornoLabel.Text = "Placa";
            this.PlacaRetornoLabel.Visible = false;
            // 
            // PlacaRetornoTextBox
            // 
            this.PlacaRetornoTextBox.Location = new System.Drawing.Point(78, 220);
            this.PlacaRetornoTextBox.Name = "PlacaRetornoTextBox";
            this.PlacaRetornoTextBox.Size = new System.Drawing.Size(100, 23);
            this.PlacaRetornoTextBox.TabIndex = 35;
            this.PlacaRetornoTextBox.Visible = false;
            // 
            // TipoVeiculoLabel
            // 
            this.TipoVeiculoLabel.AutoSize = true;
            this.TipoVeiculoLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TipoVeiculoLabel.Location = new System.Drawing.Point(267, 221);
            this.TipoVeiculoLabel.Name = "TipoVeiculoLabel";
            this.TipoVeiculoLabel.Size = new System.Drawing.Size(94, 20);
            this.TipoVeiculoLabel.TabIndex = 38;
            this.TipoVeiculoLabel.Text = "Tipo Veiculo";
            this.TipoVeiculoLabel.Visible = false;
            // 
            // TVeiculoRetornoTextBox
            // 
            this.TVeiculoRetornoTextBox.Location = new System.Drawing.Point(367, 220);
            this.TVeiculoRetornoTextBox.Name = "TVeiculoRetornoTextBox";
            this.TVeiculoRetornoTextBox.Size = new System.Drawing.Size(100, 23);
            this.TVeiculoRetornoTextBox.TabIndex = 37;
            this.TVeiculoRetornoTextBox.Visible = false;
            // 
            // PesquisarButton
            // 
            this.PesquisarButton.BackColor = System.Drawing.Color.SeaGreen;
            this.PesquisarButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PesquisarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PesquisarButton.Location = new System.Drawing.Point(200, 114);
            this.PesquisarButton.Name = "PesquisarButton";
            this.PesquisarButton.Size = new System.Drawing.Size(104, 28);
            this.PesquisarButton.TabIndex = 39;
            this.PesquisarButton.Text = "Pesquisar";
            this.PesquisarButton.UseVisualStyleBackColor = false;
            this.PesquisarButton.Click += new System.EventHandler(this.PesquisarButton_Click);
            // 
            // SaidaVeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.PesquisarButton);
            this.Controls.Add(this.TipoVeiculoLabel);
            this.Controls.Add(this.TVeiculoRetornoTextBox);
            this.Controls.Add(this.PlacaRetornoLabel);
            this.Controls.Add(this.PlacaRetornoTextBox);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EntradaDateTimePicker);
            this.Controls.Add(this.EntradaVeiculoButton1);
            this.Controls.Add(this.LoginTxtVagasLabel);
            this.Controls.Add(this.PlacaVeiculoTextBox);
            this.Controls.Add(this.TituloLabel);
            this.Name = "SaidaVeiculoForm";
            this.Text = "SaidaVeiculoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CancelarBtn;
        private Label label2;
        private DateTimePicker EntradaDateTimePicker;
        private Button EntradaVeiculoButton1;
        private Label LoginTxtVagasLabel;
        private TextBox PlacaVeiculoTextBox;
        private Label TituloLabel;
        private Label PlacaRetornoLabel;
        private TextBox PlacaRetornoTextBox;
        private Label TipoVeiculoLabel;
        private TextBox TVeiculoRetornoTextBox;
        private Button PesquisarButton;
    }
}