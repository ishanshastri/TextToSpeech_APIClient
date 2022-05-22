namespace TTS_Project
    {
    partial class TextToSpeechUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextToSpeechUI));
            this.genderLabel = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.PickVoiceLabel = new System.Windows.Forms.Label();
            this.VoicesComboBox = new System.Windows.Forms.ComboBox();
            this.UserInputTextBox = new System.Windows.Forms.TextBox();
            this.UserTexBoxLabel = new System.Windows.Forms.Label();
            this.speakButton = new System.Windows.Forms.Button();
            this.saveCheckBox = new System.Windows.Forms.CheckBox();
            this.mp3RadioButton = new System.Windows.Forms.RadioButton();
            this.wavRadioButton = new System.Windows.Forms.RadioButton();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.optionsPanel.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(9, 9);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(54, 17);
            this.genderLabel.TabIndex = 0;
            this.genderLabel.Text = "Gender:";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(12, 32);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 1;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(12, 55);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 2;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.PickVoiceLabel);
            this.optionsPanel.Controls.Add(this.VoicesComboBox);
            this.optionsPanel.Controls.Add(this.maleRadioButton);
            this.optionsPanel.Controls.Add(this.genderLabel);
            this.optionsPanel.Controls.Add(this.femaleRadioButton);
            this.optionsPanel.Location = new System.Drawing.Point(12, 57);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(305, 83);
            this.optionsPanel.TabIndex = 3;
            this.optionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PickVoiceLabel
            // 
            this.PickVoiceLabel.AutoSize = true;
            this.PickVoiceLabel.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickVoiceLabel.Location = new System.Drawing.Point(86, 9);
            this.PickVoiceLabel.Name = "PickVoiceLabel";
            this.PickVoiceLabel.Size = new System.Drawing.Size(92, 17);
            this.PickVoiceLabel.TabIndex = 4;
            this.PickVoiceLabel.Text = "Pick A Voice:";
            // 
            // VoicesComboBox
            // 
            this.VoicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VoicesComboBox.FormattingEnabled = true;
            this.VoicesComboBox.Location = new System.Drawing.Point(89, 32);
            this.VoicesComboBox.MaxDropDownItems = 6;
            this.VoicesComboBox.Name = "VoicesComboBox";
            this.VoicesComboBox.Size = new System.Drawing.Size(187, 21);
            this.VoicesComboBox.TabIndex = 3;
            this.VoicesComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UserInputTextBox
            // 
            this.UserInputTextBox.Location = new System.Drawing.Point(12, 172);
            this.UserInputTextBox.Multiline = true;
            this.UserInputTextBox.Name = "UserInputTextBox";
            this.UserInputTextBox.Size = new System.Drawing.Size(305, 100);
            this.UserInputTextBox.TabIndex = 4;
            // 
            // UserTexBoxLabel
            // 
            this.UserTexBoxLabel.AutoSize = true;
            this.UserTexBoxLabel.Location = new System.Drawing.Point(13, 153);
            this.UserTexBoxLabel.Name = "UserTexBoxLabel";
            this.UserTexBoxLabel.Size = new System.Drawing.Size(55, 13);
            this.UserTexBoxLabel.TabIndex = 5;
            this.UserTexBoxLabel.Text = "Input Text";
            // 
            // speakButton
            // 
            this.speakButton.Location = new System.Drawing.Point(9, 363);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(75, 23);
            this.speakButton.TabIndex = 6;
            this.speakButton.Text = "Speak (Save)";
            this.speakButton.UseVisualStyleBackColor = true;
            this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
            // 
            // saveCheckBox
            // 
            this.saveCheckBox.AutoSize = true;
            this.saveCheckBox.Location = new System.Drawing.Point(9, 340);
            this.saveCheckBox.Name = "saveCheckBox";
            this.saveCheckBox.Size = new System.Drawing.Size(51, 17);
            this.saveCheckBox.TabIndex = 7;
            this.saveCheckBox.Text = "Save";
            this.saveCheckBox.UseVisualStyleBackColor = true;
            // 
            // mp3RadioButton
            // 
            this.mp3RadioButton.AutoSize = true;
            this.mp3RadioButton.Checked = true;
            this.mp3RadioButton.Location = new System.Drawing.Point(9, 308);
            this.mp3RadioButton.Name = "mp3RadioButton";
            this.mp3RadioButton.Size = new System.Drawing.Size(45, 17);
            this.mp3RadioButton.TabIndex = 5;
            this.mp3RadioButton.TabStop = true;
            this.mp3RadioButton.Text = "mp3";
            this.mp3RadioButton.UseVisualStyleBackColor = true;
            // 
            // wavRadioButton
            // 
            this.wavRadioButton.AutoSize = true;
            this.wavRadioButton.Location = new System.Drawing.Point(73, 308);
            this.wavRadioButton.Name = "wavRadioButton";
            this.wavRadioButton.Size = new System.Drawing.Size(45, 17);
            this.wavRadioButton.TabIndex = 6;
            this.wavRadioButton.Text = "wav";
            this.wavRadioButton.UseVisualStyleBackColor = true;
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileTypeLabel.Location = new System.Drawing.Point(8, 284);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(66, 17);
            this.fileTypeLabel.TabIndex = 5;
            this.fileTypeLabel.Text = "File Type";
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripComboBox1});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(435, 25);
            this.toolBar.TabIndex = 8;
            this.toolBar.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "item1",
            "item2"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // TextToSpeechUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 395);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.mp3RadioButton);
            this.Controls.Add(this.wavRadioButton);
            this.Controls.Add(this.saveCheckBox);
            this.Controls.Add(this.speakButton);
            this.Controls.Add(this.UserTexBoxLabel);
            this.Controls.Add(this.UserInputTextBox);
            this.Controls.Add(this.optionsPanel);
            this.Name = "TextToSpeechUI";
            this.Text = "TextToSpeechUI";
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.ComboBox VoicesComboBox;
        private System.Windows.Forms.TextBox UserInputTextBox;
        private System.Windows.Forms.Label UserTexBoxLabel;
        private System.Windows.Forms.Button speakButton;
        private System.Windows.Forms.Label PickVoiceLabel;
        private System.Windows.Forms.CheckBox saveCheckBox;
        private System.Windows.Forms.RadioButton mp3RadioButton;
        private System.Windows.Forms.RadioButton wavRadioButton;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        }
    }