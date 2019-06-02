namespace SlicerProto
{
    partial class ColorPicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panColor = new System.Windows.Forms.Panel();
            this.butColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // panColor
            // 
            this.panColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panColor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panColor.Location = new System.Drawing.Point(0, 0);
            this.panColor.Name = "panColor";
            this.panColor.Size = new System.Drawing.Size(118, 28);
            this.panColor.TabIndex = 0;
            this.panColor.Click += new System.EventHandler(this.butColor_Click);
            // 
            // butColor
            // 
            this.butColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.butColor.Location = new System.Drawing.Point(118, 0);
            this.butColor.Name = "butColor";
            this.butColor.Size = new System.Drawing.Size(32, 28);
            this.butColor.TabIndex = 1;
            this.butColor.Text = "...";
            this.butColor.UseVisualStyleBackColor = true;
            this.butColor.Click += new System.EventHandler(this.butColor_Click);
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panColor);
            this.Controls.Add(this.butColor);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ColorPicker";
            this.Size = new System.Drawing.Size(150, 28);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panColor;
        private System.Windows.Forms.Button butColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
