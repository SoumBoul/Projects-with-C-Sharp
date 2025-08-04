namespace TIC_TAC.TOE_2eme_solution
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTurn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWinner = new System.Windows.Forms.TextBox();
            this.btRestartGame = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn8 = new Guna.UI2.WinForms.Guna2Button();
            this.btn9 = new Guna.UI2.WinForms.Guna2Button();
            this.btn7 = new Guna.UI2.WinForms.Guna2Button();
            this.btn5 = new Guna.UI2.WinForms.Guna2Button();
            this.btn6 = new Guna.UI2.WinForms.Guna2Button();
            this.btn4 = new Guna.UI2.WinForms.Guna2Button();
            this.btn2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn3 = new Guna.UI2.WinForms.Guna2Button();
            this.btn1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(64, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "Turn";
            // 
            // txtTurn
            // 
            this.txtTurn.BackColor = System.Drawing.Color.DarkBlue;
            this.txtTurn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTurn.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurn.ForeColor = System.Drawing.Color.Yellow;
            this.txtTurn.Location = new System.Drawing.Point(55, 164);
            this.txtTurn.Multiline = true;
            this.txtTurn.Name = "txtTurn";
            this.txtTurn.Size = new System.Drawing.Size(236, 65);
            this.txtTurn.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(117, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 50);
            this.label2.TabIndex = 11;
            this.label2.Text = "Winner";
            // 
            // txtWinner
            // 
            this.txtWinner.BackColor = System.Drawing.Color.DarkBlue;
            this.txtWinner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWinner.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinner.ForeColor = System.Drawing.Color.Yellow;
            this.txtWinner.Location = new System.Drawing.Point(55, 312);
            this.txtWinner.Multiline = true;
            this.txtWinner.Name = "txtWinner";
            this.txtWinner.Size = new System.Drawing.Size(250, 67);
            this.txtWinner.TabIndex = 12;
            this.txtWinner.Text = "In Progress";
            // 
            // btRestartGame
            // 
            this.btRestartGame.BackColor = System.Drawing.Color.Black;
            this.btRestartGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btRestartGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btRestartGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btRestartGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btRestartGame.FillColor = System.Drawing.Color.Black;
            this.btRestartGame.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.btRestartGame.ForeColor = System.Drawing.Color.White;
            this.btRestartGame.Location = new System.Drawing.Point(29, 413);
            this.btRestartGame.Name = "btRestartGame";
            this.btRestartGame.Size = new System.Drawing.Size(247, 94);
            this.btRestartGame.TabIndex = 13;
            this.btRestartGame.Text = "Restart Game";
            this.btRestartGame.Click += new System.EventHandler(this.btRestartGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(179, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 54);
            this.label3.TabIndex = 14;
            this.label3.Text = "TIC.TAC.TOE";
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn8.FillColor = System.Drawing.Color.Black;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Image = ((System.Drawing.Image)(resources.GetObject("btn8.Image")));
            this.btn8.ImageSize = new System.Drawing.Size(70, 70);
            this.btn8.Location = new System.Drawing.Point(466, 329);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(104, 101);
            this.btn8.TabIndex = 8;
            this.btn8.Tag = "?";
            this.btn8.Click += new System.EventHandler(this.btn_clik);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn9.FillColor = System.Drawing.Color.Black;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Image = ((System.Drawing.Image)(resources.GetObject("btn9.Image")));
            this.btn9.ImageSize = new System.Drawing.Size(70, 70);
            this.btn9.Location = new System.Drawing.Point(576, 329);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(104, 101);
            this.btn9.TabIndex = 7;
            this.btn9.Tag = "?";
            this.btn9.Click += new System.EventHandler(this.btn_clik);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn7.FillColor = System.Drawing.Color.Black;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Image = ((System.Drawing.Image)(resources.GetObject("btn7.Image")));
            this.btn7.ImageSize = new System.Drawing.Size(70, 70);
            this.btn7.Location = new System.Drawing.Point(356, 329);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(104, 101);
            this.btn7.TabIndex = 6;
            this.btn7.Tag = "?";
            this.btn7.Click += new System.EventHandler(this.btn_clik);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn5.FillColor = System.Drawing.Color.Black;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Image = ((System.Drawing.Image)(resources.GetObject("btn5.Image")));
            this.btn5.ImageSize = new System.Drawing.Size(70, 70);
            this.btn5.Location = new System.Drawing.Point(466, 222);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(104, 101);
            this.btn5.TabIndex = 5;
            this.btn5.Tag = "?";
            this.btn5.Click += new System.EventHandler(this.btn_clik);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn6.FillColor = System.Drawing.Color.Black;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Image = ((System.Drawing.Image)(resources.GetObject("btn6.Image")));
            this.btn6.ImageSize = new System.Drawing.Size(70, 70);
            this.btn6.Location = new System.Drawing.Point(576, 222);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(104, 101);
            this.btn6.TabIndex = 4;
            this.btn6.Tag = "?";
            this.btn6.Click += new System.EventHandler(this.btn_clik);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn4.FillColor = System.Drawing.Color.Black;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Image = ((System.Drawing.Image)(resources.GetObject("btn4.Image")));
            this.btn4.ImageSize = new System.Drawing.Size(70, 70);
            this.btn4.Location = new System.Drawing.Point(356, 222);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(104, 101);
            this.btn4.TabIndex = 3;
            this.btn4.Tag = "?";
            this.btn4.Click += new System.EventHandler(this.btn_clik);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn2.FillColor = System.Drawing.Color.Black;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.ImageSize = new System.Drawing.Size(70, 70);
            this.btn2.Location = new System.Drawing.Point(466, 115);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(104, 101);
            this.btn2.TabIndex = 2;
            this.btn2.Tag = "?";
            this.btn2.Click += new System.EventHandler(this.btn_clik);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn3.FillColor = System.Drawing.Color.Black;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.ImageSize = new System.Drawing.Size(70, 70);
            this.btn3.Location = new System.Drawing.Point(576, 115);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(104, 101);
            this.btn3.TabIndex = 1;
            this.btn3.Tag = "?";
            this.btn3.Click += new System.EventHandler(this.btn_clik);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn1.FillColor = System.Drawing.Color.Black;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.ImageSize = new System.Drawing.Size(70, 70);
            this.btn1.Location = new System.Drawing.Point(356, 115);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(104, 101);
            this.btn1.TabIndex = 0;
            this.btn1.Tag = "?";
            this.btn1.Click += new System.EventHandler(this.btn_clik);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btRestartGame);
            this.Controls.Add(this.txtWinner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn1;
        private Guna.UI2.WinForms.Guna2Button btn3;
        private Guna.UI2.WinForms.Guna2Button btn2;
        private Guna.UI2.WinForms.Guna2Button btn5;
        private Guna.UI2.WinForms.Guna2Button btn6;
        private Guna.UI2.WinForms.Guna2Button btn4;
        private Guna.UI2.WinForms.Guna2Button btn8;
        private Guna.UI2.WinForms.Guna2Button btn9;
        private Guna.UI2.WinForms.Guna2Button btn7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTurn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWinner;
        private Guna.UI2.WinForms.Guna2Button btRestartGame;
        private System.Windows.Forms.Label label3;
    }
}

