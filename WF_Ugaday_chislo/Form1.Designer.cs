namespace WF_Ugaday_chislo
{
    partial class Form1
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
            this.tbUserVar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChislo = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.btbCheck = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btbNewGame = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUserVar
            // 
            this.tbUserVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserVar.Location = new System.Drawing.Point(143, 167);
            this.tbUserVar.Name = "tbUserVar";
            this.tbUserVar.Size = new System.Drawing.Size(90, 26);
            this.tbUserVar.TabIndex = 0;
            this.tbUserVar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваш вариант:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(42, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Угадай число!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Компьютер загадал число от 1 до 100.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChislo
            // 
            this.lblChislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChislo.ForeColor = System.Drawing.Color.Purple;
            this.lblChislo.Location = new System.Drawing.Point(42, 16);
            this.lblChislo.Name = "lblChislo";
            this.lblChislo.Size = new System.Drawing.Size(100, 44);
            this.lblChislo.TabIndex = 4;
            this.lblChislo.Text = "???";
            this.lblChislo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTip
            // 
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTip.ForeColor = System.Drawing.Color.Purple;
            this.lblTip.Location = new System.Drawing.Point(29, 16);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(256, 29);
            this.lblTip.TabIndex = 5;
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btbCheck
            // 
            this.btbCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btbCheck.ForeColor = System.Drawing.Color.Navy;
            this.btbCheck.Location = new System.Drawing.Point(239, 166);
            this.btbCheck.Name = "btbCheck";
            this.btbCheck.Size = new System.Drawing.Size(103, 27);
            this.btbCheck.TabIndex = 6;
            this.btbCheck.Text = "Проверить";
            this.btbCheck.UseVisualStyleBackColor = true;
            this.btbCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTip);
            this.groupBox1.Location = new System.Drawing.Point(16, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 53);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblChislo);
            this.groupBox2.Location = new System.Drawing.Point(91, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 66);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btbNewGame
            // 
            this.btbNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btbNewGame.ForeColor = System.Drawing.Color.Navy;
            this.btbNewGame.Location = new System.Drawing.Point(61, 253);
            this.btbNewGame.Name = "btbNewGame";
            this.btbNewGame.Size = new System.Drawing.Size(222, 44);
            this.btbNewGame.TabIndex = 9;
            this.btbNewGame.Text = "Новая игра";
            this.btbNewGame.UseVisualStyleBackColor = true;
            this.btbNewGame.Click += new System.EventHandler(this.btbNewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 309);
            this.Controls.Add(this.btbNewGame);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btbCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserVar);
            this.Name = "Form1";
            this.Text = "Игра";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChislo;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox tbUserVar;
        private System.Windows.Forms.Button btbCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btbNewGame;
    }
}

