namespace PerAreaVolVaughn
{
    partial class PerAreaVolfrm
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
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnPerimeter = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.mnuExit = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(521, 121);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(25, 13);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "???";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(521, 221);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(25, 13);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "???";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(521, 318);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(25, 13);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "???";
            // 
            // btnPerimeter
            // 
            this.btnPerimeter.Location = new System.Drawing.Point(65, 84);
            this.btnPerimeter.Name = "btnPerimeter";
            this.btnPerimeter.Size = new System.Drawing.Size(316, 87);
            this.btnPerimeter.TabIndex = 3;
            this.btnPerimeter.Text = "Calculate the perimeter of a rectangle with length 7cm and width 5cm";
            this.btnPerimeter.UseVisualStyleBackColor = true;
            this.btnPerimeter.Click += new System.EventHandler(this.BtnPerimeter_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(65, 190);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(316, 75);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Calculate the area of a circle with a radius of 8km\r\n";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.BtnArea_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.Location = new System.Drawing.Point(65, 283);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(316, 82);
            this.btnVolume.TabIndex = 5;
            this.btnVolume.Text = "Calculate the volume of a sphere with a radius of 10m\r\n";
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.BtnVolume_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mnuExit.Location = new System.Drawing.Point(0, 0);
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(800, 24);
            this.mnuExit.TabIndex = 6;
            this.mnuExit.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // PerAreaVolfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPerimeter);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.mnuExit);
            this.MainMenuStrip = this.mnuExit;
            this.Name = "PerAreaVolfrm";
            this.Text = "Perimeter, Area, Volume";
            this.mnuExit.ResumeLayout(false);
            this.mnuExit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnPerimeter;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.MenuStrip mnuExit;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

