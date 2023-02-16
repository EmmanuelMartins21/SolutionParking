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
            this.LoginTextBox.Location = new System.Drawing.Point(291, 170);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(214, 23);
            this.LoginTextBox.TabIndex = 1;
            // 
            // SenhaTextBox
            // 
            this.SenhaTextBox.Location = new System.Drawing.Point(291, 247);
            this.SenhaTextBox.Name = "SenhaTextBox";
            this.SenhaTextBox.Size = new System.Drawing.Size(214, 23);
            this.SenhaTextBox.TabIndex = 2;
            // 
            // LoginTxtInsertLabel
            // 
            this.LoginTxtInsertLabel.AutoSize = true;
            this.LoginTxtInsertLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginTxtInsertLabel.Location = new System.Drawing.Point(237, 170);
            this.LoginTxtInsertLabel.Name = "LoginTxtInsertLabel";
            this.LoginTxtInsertLabel.Size = new System.Drawing.Size(48, 20);
            this.LoginTxtInsertLabel.TabIndex = 3;
            this.LoginTxtInsertLabel.Text = "Login";
            // 
            // SenhaLabel
            // 
            this.SenhaLabel.AutoSize = true;
            this.SenhaLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SenhaLabel.Location = new System.Drawing.Point(237, 247);
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
            this.EntrarBtn.Location = new System.Drawing.Point(320, 290);
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
            this.EsqueceuSenhaBtn.Location = new System.Drawing.Point(320, 342);
            this.EsqueceuSenhaBtn.Name = "EsqueceuSenhaBtn";
            this.EsqueceuSenhaBtn.Size = new System.Drawing.Size(154, 35);
            this.EsqueceuSenhaBtn.TabIndex = 6;
            this.EsqueceuSenhaBtn.Text = "Esqueci a Senha";
            this.EsqueceuSenhaBtn.UseVisualStyleBackColor = false;
            this.EsqueceuSenhaBtn.Click += new System.EventHandler(this.EsqueceuSenhaBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
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
    }
}