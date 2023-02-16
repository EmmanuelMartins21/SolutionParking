namespace SolutionParking.Views
{
    partial class EsqueceuSenhaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsqueceuSenhaForm));
            this.SalvarBtn = new System.Windows.Forms.Button();
            this.SenhaLabel = new System.Windows.Forms.Label();
            this.LoginTxtInsertLabel = new System.Windows.Forms.Label();
            this.SenhaTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PadraoTextBox = new System.Windows.Forms.TextBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalvarBtn
            // 
            this.SalvarBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.SalvarBtn.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalvarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SalvarBtn.Location = new System.Drawing.Point(321, 290);
            this.SalvarBtn.Name = "SalvarBtn";
            this.SalvarBtn.Size = new System.Drawing.Size(154, 35);
            this.SalvarBtn.TabIndex = 12;
            this.SalvarBtn.Text = "Salvar";
            this.SalvarBtn.UseVisualStyleBackColor = false;
            this.SalvarBtn.Click += new System.EventHandler(this.SalvarBtn_Click);
            // 
            // SenhaLabel
            // 
            this.SenhaLabel.AutoSize = true;
            this.SenhaLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SenhaLabel.Location = new System.Drawing.Point(194, 250);
            this.SenhaLabel.Name = "SenhaLabel";
            this.SenhaLabel.Size = new System.Drawing.Size(92, 20);
            this.SenhaLabel.TabIndex = 11;
            this.SenhaLabel.Text = "Nova Senha";
            // 
            // LoginTxtInsertLabel
            // 
            this.LoginTxtInsertLabel.AutoSize = true;
            this.LoginTxtInsertLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginTxtInsertLabel.Location = new System.Drawing.Point(194, 173);
            this.LoginTxtInsertLabel.Name = "LoginTxtInsertLabel";
            this.LoginTxtInsertLabel.Size = new System.Drawing.Size(48, 20);
            this.LoginTxtInsertLabel.TabIndex = 10;
            this.LoginTxtInsertLabel.Text = "Login";
            // 
            // SenhaTextBox
            // 
            this.SenhaTextBox.Location = new System.Drawing.Point(292, 247);
            this.SenhaTextBox.Name = "SenhaTextBox";
            this.SenhaTextBox.Size = new System.Drawing.Size(214, 23);
            this.SenhaTextBox.TabIndex = 9;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(292, 170);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(214, 23);
            this.LoginTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 90);
            this.label1.TabIndex = 7;
            this.label1.Text = "Esqueci Minha Senha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(194, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Padrão";
            // 
            // PadraoTextBox
            // 
            this.PadraoTextBox.Location = new System.Drawing.Point(292, 208);
            this.PadraoTextBox.Name = "PadraoTextBox";
            this.PadraoTextBox.Size = new System.Drawing.Size(209, 23);
            this.PadraoTextBox.TabIndex = 14;
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.CancelarBtn.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelarBtn.Location = new System.Drawing.Point(321, 346);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(154, 35);
            this.CancelarBtn.TabIndex = 35;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = false;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // EsqueceuSenhaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PadraoTextBox);
            this.Controls.Add(this.SalvarBtn);
            this.Controls.Add(this.SenhaLabel);
            this.Controls.Add(this.LoginTxtInsertLabel);
            this.Controls.Add(this.SenhaTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EsqueceuSenhaForm";
            this.Text = "EsqueceuSenhaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button SalvarBtn;
        private Label SenhaLabel;
        private Label LoginTxtInsertLabel;
        private TextBox SenhaTextBox;
        private TextBox LoginTextBox;
        private Label label1;
        private Label label2;
        private TextBox PadraoTextBox;
        private Button CancelarBtn;
    }
}