namespace DwarfHeightmap
{
    partial class Main
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
            this.openHeightmapButton = new System.Windows.Forms.Button();
            this.heightmapFileNameTextbox = new System.Windows.Forms.TextBox();
            this.openWorldgenFile = new System.Windows.Forms.OpenFileDialog();
            this.openHeightmapFile = new System.Windows.Forms.OpenFileDialog();
            this.goButton = new System.Windows.Forms.Button();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.xComboBox = new System.Windows.Forms.ComboBox();
            this.yComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.offsetTextBox = new System.Windows.Forms.TextBox();
            this.ratioTextBox = new System.Windows.Forms.TextBox();
            this.commitButton = new System.Windows.Forms.Button();
            this.TypesListBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openHeightmapButton
            // 
            this.openHeightmapButton.Location = new System.Drawing.Point(160, 79);
            this.openHeightmapButton.Name = "openHeightmapButton";
            this.openHeightmapButton.Size = new System.Drawing.Size(121, 19);
            this.openHeightmapButton.TabIndex = 3;
            this.openHeightmapButton.Text = "Open Heightmap file";
            this.openHeightmapButton.UseVisualStyleBackColor = true;
            this.openHeightmapButton.Click += new System.EventHandler(this.openHeightmapButton_Click);
            // 
            // heightmapFileNameTextbox
            // 
            this.heightmapFileNameTextbox.Location = new System.Drawing.Point(16, 78);
            this.heightmapFileNameTextbox.Name = "heightmapFileNameTextbox";
            this.heightmapFileNameTextbox.Size = new System.Drawing.Size(138, 20);
            this.heightmapFileNameTextbox.TabIndex = 2;
            // 
            // openWorldgenFile
            // 
            this.openWorldgenFile.DefaultExt = "txt";
            this.openWorldgenFile.FileName = "world_gen.txt";
            this.openWorldgenFile.Filter = "*.txt|";
            this.openWorldgenFile.Title = "Open World_Gen.txt";
            // 
            // openHeightmapFile
            // 
            this.openHeightmapFile.DefaultExt = "bmp";
            this.openHeightmapFile.FileName = "heightmap.bmp";
            this.openHeightmapFile.Filter = "*.bmp|";
            this.openHeightmapFile.Title = "Open Heightmap";
            this.openHeightmapFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openHeightmapFile_FileOk);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(15, 204);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(109, 22);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "Process!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Elevation",
            "Rainfall",
            "Temperature",
            "Drainage",
            "Savagery",
            "Volcanicity"});
            this.TypeComboBox.Location = new System.Drawing.Point(16, 104);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(138, 21);
            this.TypeComboBox.TabIndex = 5;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // xComboBox
            // 
            this.xComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xComboBox.FormattingEnabled = true;
            this.xComboBox.Items.AddRange(new object[] {
            "17",
            "33",
            "65",
            "129",
            "257"});
            this.xComboBox.Location = new System.Drawing.Point(16, 131);
            this.xComboBox.Name = "xComboBox";
            this.xComboBox.Size = new System.Drawing.Size(59, 21);
            this.xComboBox.TabIndex = 6;
            // 
            // yComboBox
            // 
            this.yComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yComboBox.FormattingEnabled = true;
            this.yComboBox.Items.AddRange(new object[] {
            "17",
            "33",
            "65",
            "129",
            "257"});
            this.yComboBox.Location = new System.Drawing.Point(92, 131);
            this.yComboBox.Name = "yComboBox";
            this.yComboBox.Size = new System.Drawing.Size(62, 21);
            this.yComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Height Offset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ratio";
            // 
            // offsetTextBox
            // 
            this.offsetTextBox.Location = new System.Drawing.Point(81, 155);
            this.offsetTextBox.Name = "offsetTextBox";
            this.offsetTextBox.Size = new System.Drawing.Size(73, 20);
            this.offsetTextBox.TabIndex = 11;
            this.offsetTextBox.Text = "0";
            // 
            // ratioTextBox
            // 
            this.ratioTextBox.Location = new System.Drawing.Point(81, 176);
            this.ratioTextBox.Name = "ratioTextBox";
            this.ratioTextBox.Size = new System.Drawing.Size(73, 20);
            this.ratioTextBox.TabIndex = 12;
            this.ratioTextBox.Text = "1.56863";
            // 
            // commitButton
            // 
            this.commitButton.Enabled = false;
            this.commitButton.Location = new System.Drawing.Point(15, 232);
            this.commitButton.Name = "commitButton";
            this.commitButton.Size = new System.Drawing.Size(109, 22);
            this.commitButton.TabIndex = 13;
            this.commitButton.Text = "Commit to File";
            this.commitButton.UseVisualStyleBackColor = true;
            this.commitButton.Click += new System.EventHandler(this.commitButton_Click);
            // 
            // TypesListBox
            // 
            this.TypesListBox.FormattingEnabled = true;
            this.TypesListBox.Location = new System.Drawing.Point(160, 119);
            this.TypesListBox.Name = "TypesListBox";
            this.TypesListBox.Size = new System.Drawing.Size(120, 82);
            this.TypesListBox.TabIndex = 14;
            this.TypesListBox.DoubleClick += new System.EventHandler(this.TypesListBox_DoubleClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(160, 205);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 21);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(16, 36);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(138, 20);
            this.nameTextBox.TabIndex = 16;
            this.nameTextBox.Text = "Map Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Current Heightmap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Currently Genned Types";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutMenuItem.Text = "&About";
            this.aboutMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(210, 22);
            this.openMenuItem.Text = "&Open Existing Heightmaps";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(210, 22);
            this.exitMenuItem.Text = "E&xit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.TypesListBox);
            this.Controls.Add(this.commitButton);
            this.Controls.Add(this.ratioTextBox);
            this.Controls.Add(this.offsetTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yComboBox);
            this.Controls.Add(this.xComboBox);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.openHeightmapButton);
            this.Controls.Add(this.heightmapFileNameTextbox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "DwarfHeightmap";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openHeightmapButton;
        private System.Windows.Forms.TextBox heightmapFileNameTextbox;
        private System.Windows.Forms.OpenFileDialog openWorldgenFile;
        private System.Windows.Forms.OpenFileDialog openHeightmapFile;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.ComboBox xComboBox;
        private System.Windows.Forms.ComboBox yComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox offsetTextBox;
        private System.Windows.Forms.TextBox ratioTextBox;
        private System.Windows.Forms.Button commitButton;
        private System.Windows.Forms.ListBox TypesListBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
    }
}