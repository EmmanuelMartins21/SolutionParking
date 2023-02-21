namespace SolutionParking.Views
{
    partial class EntradaVeiculoForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaVeiculoForm));
            this.EntradaVeiculoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTxtVagasLabel = new System.Windows.Forms.Label();
            this.PlacaVeiculoTextBox = new System.Windows.Forms.TextBox();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.TipoVeiculoComboBox = new System.Windows.Forms.ComboBox();
            this.EntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.VagaLabel = new System.Windows.Forms.Label();
            this.VagaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EntradaVeiculoButton
            // 
            this.EntradaVeiculoButton.BackColor = System.Drawing.Color.SeaGreen;
            this.EntradaVeiculoButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntradaVeiculoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EntradaVeiculoButton.Location = new System.Drawing.Point(411, 327);
            this.EntradaVeiculoButton.Name = "EntradaVeiculoButton";
            this.EntradaVeiculoButton.Size = new System.Drawing.Size(154, 35);
            this.EntradaVeiculoButton.TabIndex = 16;
            this.EntradaVeiculoButton.Text = "Salvar";
            this.EntradaVeiculoButton.UseVisualStyleBackColor = false;
            this.EntradaVeiculoButton.Click += new System.EventHandler(this.EntradaVeiculoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(254, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo Veiculo";
            // 
            // LoginTxtVagasLabel
            // 
            this.LoginTxtVagasLabel.AutoSize = true;
            this.LoginTxtVagasLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginTxtVagasLabel.Location = new System.Drawing.Point(25, 118);
            this.LoginTxtVagasLabel.Name = "LoginTxtVagasLabel";
            this.LoginTxtVagasLabel.Size = new System.Drawing.Size(45, 20);
            this.LoginTxtVagasLabel.TabIndex = 12;
            this.LoginTxtVagasLabel.Text = "Placa";
            // 
            // PlacaVeiculoTextBox
            // 
            this.PlacaVeiculoTextBox.Location = new System.Drawing.Point(76, 118);
            this.PlacaVeiculoTextBox.Name = "PlacaVeiculoTextBox";
            this.PlacaVeiculoTextBox.Size = new System.Drawing.Size(100, 23);
            this.PlacaVeiculoTextBox.TabIndex = 11;
            // 
            // TituloLabel
            // 
            this.TituloLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.TituloLabel.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TituloLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TituloLabel.Location = new System.Drawing.Point(0, 0);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(800, 90);
            this.TituloLabel.TabIndex = 10;
            this.TituloLabel.Text = "Solution Parking";
            this.TituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TipoVeiculoComboBox
            // 
            this.TipoVeiculoComboBox.FormattingEnabled = true;
            this.TipoVeiculoComboBox.Items.AddRange(new object[] {
            "Carro",
            "Moto",
            "Bicicleta "});
            this.TipoVeiculoComboBox.Location = new System.Drawing.Point(354, 119);
            this.TipoVeiculoComboBox.Name = "TipoVeiculoComboBox";
            this.TipoVeiculoComboBox.Size = new System.Drawing.Size(121, 23);
            this.TipoVeiculoComboBox.TabIndex = 18;
            // 
            // EntradaDateTimePicker
            // 
            this.EntradaDateTimePicker.Location = new System.Drawing.Point(152, 190);
            this.EntradaDateTimePicker.Name = "EntradaDateTimePicker";
            this.EntradaDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.EntradaDateTimePicker.TabIndex = 19;
            // 
            // VagaLabel
            // 
            this.VagaLabel.AutoSize = true;
            this.VagaLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VagaLabel.Location = new System.Drawing.Point(537, 119);
            this.VagaLabel.Name = "VagaLabel";
            this.VagaLabel.Size = new System.Drawing.Size(43, 20);
            this.VagaLabel.TabIndex = 21;
            this.VagaLabel.Text = "Vaga";
            // 
            // VagaTextBox
            // 
            this.VagaTextBox.Location = new System.Drawing.Point(588, 119);
            this.VagaTextBox.Name = "VagaTextBox";
            this.VagaTextBox.Size = new System.Drawing.Size(100, 23);
            this.VagaTextBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Data de entrada";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.CancelarBtn.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelarBtn.Location = new System.Drawing.Point(588, 327);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(154, 35);
            this.CancelarBtn.TabIndex = 23;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = false;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // EntradaVeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VagaLabel);
            this.Controls.Add(this.VagaTextBox);
            this.Controls.Add(this.EntradaDateTimePicker);
            this.Controls.Add(this.TipoVeiculoComboBox);
            this.Controls.Add(this.EntradaVeiculoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginTxtVagasLabel);
            this.Controls.Add(this.PlacaVeiculoTextBox);
            this.Controls.Add(this.TituloLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntradaVeiculoForm";
            this.Text = "EntradaVeiculoForm";
            this.Load += new System.EventHandler(this.EntradaVeiculoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EntradaVeiculoButton;
        private Label label1;
        private Label LoginTxtVagasLabel;
        private TextBox PlacaVeiculoTextBox;
        private Label TituloLabel;
        private ComboBox TipoVeiculoComboBox;
        private DateTimePicker EntradaDateTimePicker;
        private Label VagaLabel;
        private TextBox VagaTextBox;
        private Label label2;
        private Button CancelarBtn;
    }
}