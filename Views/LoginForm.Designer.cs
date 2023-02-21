namespace SolutionParking
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.SenhaTextBox = new System.Windows.Forms.TextBox();
            this.LoginTxtInsertLabel = new System.Windows.Forms.Label();
            this.SenhaLabel = new System.Windows.Forms.Label();
            this.EntrarBtn = new System.Windows.Forms.Button();
            this.EsqueceuSenhaBtn = new System.Windows.Forms.Button();
            this.SalvarBtn = new System.Windows.Forms.Button();
            this.NovaSenhaLabel = new System.Windows.Forms.Label();
            this.NovaSenhaTextBox = new System.Windows.Forms.TextBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.PadraoLabel = new System.Windows.Forms.Label();
            this.PadraoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(295, 127);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(214, 23);
            this.LoginTextBox.TabIndex = 1;
            // 
            // SenhaTextBox
            // 
            this.SenhaTextBox.Location = new System.Drawing.Point(295, 174);
            this.SenhaTextBox.Name = "SenhaTextBox";
            this.SenhaTextBox.Size = new System.Drawing.Size(214, 23);
            this.SenhaTextBox.TabIndex = 2;
            // 
            // LoginTxtInsertLabel
            // 
            this.LoginTxtInsertLabel.AutoSize = true;
            this.LoginTxtInsertLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginTxtInsertLabel.Location = new System.Drawing.Point(241, 127);
            this.LoginTxtInsertLabel.Name = "LoginTxtInsertLabel";
            this.LoginTxtInsertLabel.Size = new System.Drawing.Size(48, 20);
            this.LoginTxtInsertLabel.TabIndex = 3;
            this.LoginTxtInsertLabel.Text = "Login";
            // 
            // SenhaLabel
            // 
            this.SenhaLabel.AutoSize = true;
            this.SenhaLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SenhaLabel.Location = new System.Drawing.Point(241, 174);
            this.SenhaLabel.Name = "SenhaLabel";
            this.SenhaLabel.Size = new System.Drawing.Size(51, 20);
            this.SenhaLabel.TabIndex = 4;
            this.SenhaLabel.Text = "Senha";
            // 
            // EntrarBtn
            // 
            this.EntrarBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.EntrarBtn.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntrarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EntrarBtn.Location = new System.Drawing.Point(325, 290);
            this.EntrarBtn.Name = "EntrarBtn";
            this.EntrarBtn.Size = new System.Drawing.Size(154, 35);
            this.EntrarBtn.TabIndex = 5;
            this.EntrarBtn.Text = "Entrar";
            this.EntrarBtn.UseVisualStyleBackColor = false;
            this.EntrarBtn.Click += new System.EventHandler(this.EntrarBtn_Click);
            // 
            // EsqueceuSenhaBtn
            // 
            this.EsqueceuSenhaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.EsqueceuSenhaBtn.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EsqueceuSenhaBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EsqueceuSenhaBtn.Location = new System.Drawing.Point(325, 342);
            this.EsqueceuSenhaBtn.Name = "EsqueceuSenhaBtn";
            this.EsqueceuSenhaBtn.Size = new System.Drawing.Size(154, 35);
            this.EsqueceuSenhaBtn.TabIndex = 6;
            this.EsqueceuSenhaBtn.Text = "Esqueci a Senha";
            this.EsqueceuSenhaBtn.UseVisualStyleBackColor = false;
            this.EsqueceuSenhaBtn.Click += new System.EventHandler(this.EsqueceuSenhaBtn_Click);
            // 
            // SalvarBtn
            // 
            this.SalvarBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.SalvarBtn.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalvarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SalvarBtn.Location = new System.Drawing.Point(324, 246);
            this.SalvarBtn.Name = "SalvarBtn";
            this.SalvarBtn.Size = new System.Drawing.Size(154, 35);
            this.SalvarBtn.TabIndex = 15;
            this.SalvarBtn.Text = "Salvar";
            this.SalvarBtn.UseVisualStyleBackColor = false;
            this.SalvarBtn.Visible = false;
            this.SalvarBtn.Click += new System.EventHandler(this.SalvarBtn_Click);
            // 
            // NovaSenhaLabel
            // 
            this.NovaSenhaLabel.AutoSize = true;
            this.NovaSenhaLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NovaSenhaLabel.Location = new System.Drawing.Point(197, 206);
            this.NovaSenhaLabel.Name = "NovaSenhaLabel";
            this.NovaSenhaLabel.Size = new System.Drawing.Size(92, 20);
            this.NovaSenhaLabel.TabIndex = 14;
            this.NovaSenhaLabel.Text = "Nova Senha";
            this.NovaSenhaLabel.Visible = false;
            // 
            // NovaSenhaTextBox
            // 
            this.NovaSenhaTextBox.Location = new System.Drawing.Point(295, 203);
            this.NovaSenhaTextBox.Name = "NovaSenhaTextBox";
            this.NovaSenhaTextBox.Size = new System.Drawing.Size(214, 23);
            this.NovaSenhaTextBox.TabIndex = 13;
            this.NovaSenhaTextBox.Visible = false;
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.CancelarBtn.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelarBtn.Location = new System.Drawing.Point(325, 301);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(154, 35);
            this.CancelarBtn.TabIndex = 36;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = false;
            this.CancelarBtn.Visible = false;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // PadraoLabel
            // 
            this.PadraoLabel.AutoSize = true;
            this.PadraoLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PadraoLabel.Location = new System.Drawing.Point(197, 174);
            this.PadraoLabel.Name = "PadraoLabel";
            this.PadraoLabel.Size = new System.Drawing.Size(58, 20);
            this.PadraoLabel.TabIndex = 38;
            this.PadraoLabel.Text = "Padrão";
            this.PadraoLabel.Visible = false;
            // 
            // PadraoTextBox
            // 
            this.PadraoTextBox.Location = new System.Drawing.Point(295, 171);
            this.PadraoTextBox.Name = "PadraoTextBox";
            this.PadraoTextBox.Size = new System.Drawing.Size(209, 23);
            this.PadraoTextBox.TabIndex = 37;
            this.PadraoTextBox.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.PadraoLabel);
            this.Controls.Add(this.PadraoTextBox);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.SalvarBtn);
            this.Controls.Add(this.NovaSenhaLabel);
            this.Controls.Add(this.NovaSenhaTextBox);
            this.Controls.Add(this.EsqueceuSenhaBtn);
            this.Controls.Add(this.EntrarBtn);
            this.Controls.Add(this.SenhaLabel);
            this.Controls.Add(this.LoginTxtInsertLabel);
            this.Controls.Add(this.SenhaTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solution Parking";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Label label1;
        private TextBox LoginTextBox;
        private TextBox SenhaTextBox;
        private Label LoginTxtInsertLabel;
        private Label SenhaLabel;
        private Button EntrarBtn;
        private Button EsqueceuSenhaBtn;
        private Button SalvarBtn;
        private Label NovaSenhaLabel;
        private TextBox NovaSenhaTextBox;
        private Button CancelarBtn;
        private Label PadraoLabel;
        private TextBox PadraoTextBox;
    }
}