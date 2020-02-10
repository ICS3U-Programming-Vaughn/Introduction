namespace HelloWorldVaughn
{
    partial class FrmHelloWorld
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
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.picMuse = new System.Windows.Forms.PictureBox();
            this.lblSignature = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMuse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.BackColor = System.Drawing.SystemColors.Control;
            this.lblHelloWorld.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.Location = new System.Drawing.Point(43, 48);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(168, 29);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello, World!";
            // 
            // picMuse
            // 
            this.picMuse.Image = global::HelloWorldVaughn.Properties.Resources.Muse_Header_1_696x442;
            this.picMuse.Location = new System.Drawing.Point(321, 48);
            this.picMuse.Name = "picMuse";
            this.picMuse.Size = new System.Drawing.Size(270, 206);
            this.picMuse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMuse.TabIndex = 1;
            this.picMuse.TabStop = false;
            this.picMuse.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.BackColor = System.Drawing.Color.White;
            this.lblSignature.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignature.Location = new System.Drawing.Point(43, 118);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(175, 29);
            this.lblSignature.TabIndex = 2;
            this.lblSignature.Text = "By:Vaughn D.";
            // 
            // FrmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(755, 482);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.picMuse);
            this.Controls.Add(this.lblHelloWorld);
            this.Name = "FrmHelloWorld";
            this.Text = "Hello World! by: Vaughn D.";
            ((System.ComponentModel.ISupportInitialize)(this.picMuse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.PictureBox picMuse;
        private System.Windows.Forms.Label lblSignature;
    }
}

