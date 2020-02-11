namespace HelloIntVaughn
{
    partial class frmHelloInt
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.grbRadioButtons = new System.Windows.Forms.GroupBox();
            this.radJapanese = new System.Windows.Forms.RadioButton();
            this.radGerman = new System.Windows.Forms.RadioButton();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.grbRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(237, 85);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(297, 55);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            this.lblGreeting.Click += new System.EventHandler(this.LblGreeting_Click);
            // 
            // grbRadioButtons
            // 
            this.grbRadioButtons.Controls.Add(this.radJapanese);
            this.grbRadioButtons.Controls.Add(this.radGerman);
            this.grbRadioButtons.Controls.Add(this.radFrench);
            this.grbRadioButtons.Controls.Add(this.radEnglish);
            this.grbRadioButtons.Location = new System.Drawing.Point(53, 273);
            this.grbRadioButtons.Name = "grbRadioButtons";
            this.grbRadioButtons.Size = new System.Drawing.Size(711, 136);
            this.grbRadioButtons.TabIndex = 1;
            this.grbRadioButtons.TabStop = false;
            this.grbRadioButtons.Text = "Language";
            this.grbRadioButtons.Enter += new System.EventHandler(this.GrbRadioButtons_Enter);
            // 
            // radJapanese
            // 
            this.radJapanese.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.radJapanese.AutoSize = true;
            this.radJapanese.Location = new System.Drawing.Point(522, 68);
            this.radJapanese.Name = "radJapanese";
            this.radJapanese.Size = new System.Drawing.Size(71, 17);
            this.radJapanese.TabIndex = 3;
            this.radJapanese.TabStop = true;
            this.radJapanese.Text = "Japanese";
            this.radJapanese.UseVisualStyleBackColor = true;
            this.radJapanese.CheckedChanged += new System.EventHandler(this.RadJapanese_CheckedChanged);
            // 
            // radGerman
            // 
            this.radGerman.AutoSize = true;
            this.radGerman.Location = new System.Drawing.Point(341, 68);
            this.radGerman.Name = "radGerman";
            this.radGerman.Size = new System.Drawing.Size(71, 17);
            this.radGerman.TabIndex = 2;
            this.radGerman.TabStop = true;
            this.radGerman.Text = "Deutsche";
            this.radGerman.UseVisualStyleBackColor = true;
            this.radGerman.CheckedChanged += new System.EventHandler(this.RadGerman_CheckedChanged);
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.Location = new System.Drawing.Point(194, 68);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(65, 17);
            this.radFrench.TabIndex = 1;
            this.radFrench.TabStop = true;
            this.radFrench.Text = "Francais";
            this.radFrench.UseVisualStyleBackColor = true;
            this.radFrench.CheckedChanged += new System.EventHandler(this.RadFrench_CheckedChanged);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(42, 68);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(59, 17);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.RadEnglish_CheckedChanged);
            // 
            // frmHelloInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbRadioButtons);
            this.Controls.Add(this.lblGreeting);
            this.Name = "frmHelloInt";
            this.Text = "Hello World International By: Vaughn";
            this.Load += new System.EventHandler(this.FrmHelloInt_Load);
            this.grbRadioButtons.ResumeLayout(false);
            this.grbRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.GroupBox grbRadioButtons;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radGerman;
        private System.Windows.Forms.RadioButton radFrench;
        private System.Windows.Forms.RadioButton radJapanese;
    }
}

