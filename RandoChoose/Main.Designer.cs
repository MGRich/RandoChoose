namespace RandoChoose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionTree = new System.Windows.Forms.TreeView();
            this.selectDropdown = new System.Windows.Forms.ComboBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.chooseDisplay = new System.Windows.Forms.Label();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.chooseBox = new System.Windows.Forms.GroupBox();
            this.addBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addText = new System.Windows.Forms.TextBox();
            this.addDropdown = new System.Windows.Forms.ComboBox();
            this.addLabel = new System.Windows.Forms.Label();
            this.renDelBox = new System.Windows.Forms.GroupBox();
            this.gLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupDropdown = new System.Windows.Forms.ComboBox();
            this.renButton = new System.Windows.Forms.Button();
            this.eLabel = new System.Windows.Forms.Label();
            this.entryDropdown = new System.Windows.Forms.ComboBox();
            this.renText = new System.Windows.Forms.TextBox();
            this.delButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.chooseBox.SuspendLayout();
            this.addBox.SuspendLayout();
            this.renDelBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutButton});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(558, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.saveButton,
            this.saveAsButton});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openButton
            // 
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(114, 22);
            this.openButton.Text = "Open";
            this.openButton.Click += new System.EventHandler(this.open);
            // 
            // saveButton
            // 
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 22);
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.save);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(114, 22);
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.Click += new System.EventHandler(this.saveAs);
            // 
            // selectionTree
            // 
            this.selectionTree.Indent = 10;
            this.selectionTree.Location = new System.Drawing.Point(12, 31);
            this.selectionTree.Name = "selectionTree";
            this.selectionTree.Size = new System.Drawing.Size(121, 201);
            this.selectionTree.TabIndex = 1;
            // 
            // selectDropdown
            // 
            this.selectDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectDropdown.FormattingEnabled = true;
            this.selectDropdown.Items.AddRange(new object[] {
            "All"});
            this.selectDropdown.Location = new System.Drawing.Point(84, 13);
            this.selectDropdown.Name = "selectDropdown";
            this.selectDropdown.Size = new System.Drawing.Size(110, 21);
            this.selectDropdown.TabIndex = 2;
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(9, 40);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(185, 23);
            this.rollButton.TabIndex = 3;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.roll);
            // 
            // chooseDisplay
            // 
            this.chooseDisplay.AutoSize = true;
            this.chooseDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseDisplay.Location = new System.Drawing.Point(6, 66);
            this.chooseDisplay.Name = "chooseDisplay";
            this.chooseDisplay.Size = new System.Drawing.Size(0, 24);
            this.chooseDisplay.TabIndex = 4;
            this.chooseDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Location = new System.Drawing.Point(6, 16);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(69, 13);
            this.chooseLabel.TabIndex = 5;
            this.chooseLabel.Text = "Choose from:";
            // 
            // chooseBox
            // 
            this.chooseBox.Controls.Add(this.chooseLabel);
            this.chooseBox.Controls.Add(this.chooseDisplay);
            this.chooseBox.Controls.Add(this.selectDropdown);
            this.chooseBox.Controls.Add(this.rollButton);
            this.chooseBox.Location = new System.Drawing.Point(140, 31);
            this.chooseBox.Name = "chooseBox";
            this.chooseBox.Size = new System.Drawing.Size(200, 100);
            this.chooseBox.TabIndex = 6;
            this.chooseBox.TabStop = false;
            this.chooseBox.Text = "Choose";
            // 
            // addBox
            // 
            this.addBox.Controls.Add(this.addButton);
            this.addBox.Controls.Add(this.addText);
            this.addBox.Controls.Add(this.addDropdown);
            this.addBox.Controls.Add(this.addLabel);
            this.addBox.Location = new System.Drawing.Point(140, 137);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(200, 95);
            this.addBox.TabIndex = 6;
            this.addBox.TabStop = false;
            this.addBox.Text = "Add";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 66);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(188, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.add);
            // 
            // addText
            // 
            this.addText.Location = new System.Drawing.Point(6, 40);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(188, 20);
            this.addText.TabIndex = 7;
            // 
            // addDropdown
            // 
            this.addDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addDropdown.FormattingEnabled = true;
            this.addDropdown.Items.AddRange(new object[] {
            "Tree"});
            this.addDropdown.Location = new System.Drawing.Point(58, 13);
            this.addDropdown.Name = "addDropdown";
            this.addDropdown.Size = new System.Drawing.Size(136, 21);
            this.addDropdown.TabIndex = 6;
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Location = new System.Drawing.Point(7, 16);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(41, 13);
            this.addLabel.TabIndex = 0;
            this.addLabel.Text = "Add to:";
            // 
            // renDelBox
            // 
            this.renDelBox.Controls.Add(this.delButton);
            this.renDelBox.Controls.Add(this.renText);
            this.renDelBox.Controls.Add(this.entryDropdown);
            this.renDelBox.Controls.Add(this.eLabel);
            this.renDelBox.Controls.Add(this.gLabel);
            this.renDelBox.Controls.Add(this.label2);
            this.renDelBox.Controls.Add(this.groupDropdown);
            this.renDelBox.Controls.Add(this.renButton);
            this.renDelBox.Location = new System.Drawing.Point(346, 47);
            this.renDelBox.Name = "renDelBox";
            this.renDelBox.Size = new System.Drawing.Size(200, 166);
            this.renDelBox.TabIndex = 7;
            this.renDelBox.TabStop = false;
            this.renDelBox.Text = "Rename/Remove";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Location = new System.Drawing.Point(6, 16);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(39, 13);
            this.gLabel.TabIndex = 5;
            this.gLabel.Text = "Group:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupDropdown
            // 
            this.groupDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupDropdown.FormattingEnabled = true;
            this.groupDropdown.Location = new System.Drawing.Point(51, 13);
            this.groupDropdown.Name = "groupDropdown";
            this.groupDropdown.Size = new System.Drawing.Size(143, 21);
            this.groupDropdown.TabIndex = 2;
            this.groupDropdown.SelectedIndexChanged += new System.EventHandler(this.groupSelected);
            // 
            // renButton
            // 
            this.renButton.Location = new System.Drawing.Point(10, 132);
            this.renButton.Name = "renButton";
            this.renButton.Size = new System.Drawing.Size(184, 23);
            this.renButton.TabIndex = 3;
            this.renButton.Text = "Rename";
            this.renButton.UseVisualStyleBackColor = true;
            this.renButton.Click += new System.EventHandler(this.rename);
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Location = new System.Drawing.Point(6, 48);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(34, 13);
            this.eLabel.TabIndex = 6;
            this.eLabel.Text = "Entry:";
            // 
            // entryDropdown
            // 
            this.entryDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entryDropdown.FormattingEnabled = true;
            this.entryDropdown.Items.AddRange(new object[] {
            "None"});
            this.entryDropdown.Location = new System.Drawing.Point(46, 45);
            this.entryDropdown.Name = "entryDropdown";
            this.entryDropdown.Size = new System.Drawing.Size(148, 21);
            this.entryDropdown.TabIndex = 7;
            // 
            // renText
            // 
            this.renText.Location = new System.Drawing.Point(10, 106);
            this.renText.Name = "renText";
            this.renText.Size = new System.Drawing.Size(184, 20);
            this.renText.TabIndex = 8;
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(10, 72);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(184, 23);
            this.delButton.TabIndex = 9;
            this.delButton.Text = "Remove";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delete);
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(52, 20);
            this.aboutButton.Text = "About";
            this.aboutButton.Click += new System.EventHandler(this.about);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 241);
            this.Controls.Add(this.renDelBox);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.chooseBox);
            this.Controls.Add(this.selectionTree);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "RandoChoose";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.chooseBox.ResumeLayout(false);
            this.chooseBox.PerformLayout();
            this.addBox.ResumeLayout(false);
            this.addBox.PerformLayout();
            this.renDelBox.ResumeLayout(false);
            this.renDelBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openButton;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
        private System.Windows.Forms.ToolStripMenuItem saveAsButton;
        private System.Windows.Forms.TreeView selectionTree;
        private System.Windows.Forms.ComboBox selectDropdown;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label chooseDisplay;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.GroupBox chooseBox;
        private System.Windows.Forms.GroupBox addBox;
        private System.Windows.Forms.ComboBox addDropdown;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addText;
        private System.Windows.Forms.GroupBox renDelBox;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.TextBox renText;
        private System.Windows.Forms.ComboBox entryDropdown;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox groupDropdown;
        private System.Windows.Forms.Button renButton;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
    }
}

