namespace DwarfHeightmap
{
    partial class Visualiser
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
            this.visualisedPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.visualisedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // visualisedPictureBox
            // 
            this.visualisedPictureBox.Location = new System.Drawing.Point(12, 12);
            this.visualisedPictureBox.Name = "visualisedPictureBox";
            this.visualisedPictureBox.Size = new System.Drawing.Size(512, 512);
            this.visualisedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.visualisedPictureBox.TabIndex = 0;
            this.visualisedPictureBox.TabStop = false;
            // 
            // Visualiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 537);
            this.Controls.Add(this.visualisedPictureBox);
            this.Name = "Visualiser";
            this.Text = "Visualiser";
            ((System.ComponentModel.ISupportInitialize)(this.visualisedPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox visualisedPictureBox;
    }
}