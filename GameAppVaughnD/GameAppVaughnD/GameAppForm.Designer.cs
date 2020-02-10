namespace GameAppVaughnD
{
    partial class frmGameApp
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
            this.lblGame = new System.Windows.Forms.Label();
            this.mnuProgram = new System.Windows.Forms.MenuStrip();
            this.mniProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGameApp = new System.Windows.Forms.Label();
            this.mnuProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.BackColor = System.Drawing.Color.Lime;
            this.lblGame.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.ForeColor = System.Drawing.Color.Black;
            this.lblGame.Location = new System.Drawing.Point(93, 347);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(109, 64);
            this.lblGame.TabIndex = 0;
            this.lblGame.Text = "R6S";
            // 
            // mnuProgram
            // 
            this.mnuProgram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniProgram});
            this.mnuProgram.Location = new System.Drawing.Point(0, 0);
            this.mnuProgram.Name = "mnuProgram";
            this.mnuProgram.Size = new System.Drawing.Size(800, 24);
            this.mnuProgram.TabIndex = 2;
            this.mnuProgram.Text = "menuStrip1";
            // 
            // mniProgram
            // 
            this.mniProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniProgram.Name = "mniProgram";
            this.mniProgram.Size = new System.Drawing.Size(65, 20);
            this.mniProgram.Text = "Program";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(93, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GameAppVaughnD.Properties.Resources.big_lion;
            this.pictureBox2.Location = new System.Drawing.Point(488, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameAppVaughnD.Properties.Resources.The_true_lord;
            this.pictureBox1.Location = new System.Drawing.Point(12, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblGameApp
            // 
            this.lblGameApp.AutoSize = true;
            this.lblGameApp.BackColor = System.Drawing.Color.Aqua;
            this.lblGameApp.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameApp.ForeColor = System.Drawing.Color.Black;
            this.lblGameApp.Location = new System.Drawing.Point(565, 347);
            this.lblGameApp.Name = "lblGameApp";
            this.lblGameApp.Size = new System.Drawing.Size(160, 50);
            this.lblGameApp.TabIndex = 5;
            this.lblGameApp.Text = "Big Lion";
            // 
            // frmGameApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGameApp);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.mnuProgram);
            this.ForeColor = System.Drawing.Color.Red;
            this.MainMenuStrip = this.mnuProgram;
            this.Name = "frmGameApp";
            this.Text = "Game App";
            this.mnuProgram.ResumeLayout(false);
            this.mnuProgram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.MenuStrip mnuProgram;
        private System.Windows.Forms.ToolStripMenuItem mniProgram;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblGameApp;
    }
}

