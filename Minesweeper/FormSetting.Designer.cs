namespace Minesweeper
{
    partial class FormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.slipSoundCheckBox = new System.Windows.Forms.CheckBox();
            this.bombSoundCheckBox = new System.Windows.Forms.CheckBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.minesLabel = new System.Windows.Forms.Label();
            this.minesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.settingGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.soundEffectGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.minesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            this.settingGroupBox.SuspendLayout();
            this.soundEffectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // slipSoundCheckBox
            // 
            this.slipSoundCheckBox.AutoSize = true;
            this.slipSoundCheckBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slipSoundCheckBox.Location = new System.Drawing.Point(14, 22);
            this.slipSoundCheckBox.Name = "slipSoundCheckBox";
            this.slipSoundCheckBox.Size = new System.Drawing.Size(221, 28);
            this.slipSoundCheckBox.TabIndex = 0;
            this.slipSoundCheckBox.Text = "ButtonClickSound";
            this.slipSoundCheckBox.UseVisualStyleBackColor = true;
            this.slipSoundCheckBox.CheckedChanged += new System.EventHandler(this.slipSoundCheckBox_CheckedChanged);
            // 
            // bombSoundCheckBox
            // 
            this.bombSoundCheckBox.AutoSize = true;
            this.bombSoundCheckBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bombSoundCheckBox.Location = new System.Drawing.Point(14, 56);
            this.bombSoundCheckBox.Name = "bombSoundCheckBox";
            this.bombSoundCheckBox.Size = new System.Drawing.Size(137, 28);
            this.bombSoundCheckBox.TabIndex = 0;
            this.bombSoundCheckBox.Text = "BombSound";
            this.bombSoundCheckBox.UseVisualStyleBackColor = true;
            this.bombSoundCheckBox.CheckedChanged += new System.EventHandler(this.bombSoundCheckBox_CheckedChanged);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.heightLabel.Location = new System.Drawing.Point(18, 34);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(82, 24);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.widthLabel.Location = new System.Drawing.Point(18, 72);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(70, 24);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width";
            // 
            // minesLabel
            // 
            this.minesLabel.AutoSize = true;
            this.minesLabel.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.minesLabel.Location = new System.Drawing.Point(18, 110);
            this.minesLabel.Name = "minesLabel";
            this.minesLabel.Size = new System.Drawing.Size(70, 24);
            this.minesLabel.TabIndex = 3;
            this.minesLabel.Text = "Mines";
            // 
            // minesNumericUpDown
            // 
            this.minesNumericUpDown.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.minesNumericUpDown.Location = new System.Drawing.Point(106, 102);
            this.minesNumericUpDown.Name = "minesNumericUpDown";
            this.minesNumericUpDown.Size = new System.Drawing.Size(120, 32);
            this.minesNumericUpDown.TabIndex = 4;
            this.minesNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.widthNumericUpDown.Location = new System.Drawing.Point(106, 64);
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(120, 32);
            this.widthNumericUpDown.TabIndex = 5;
            this.widthNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.heightNumericUpDown.Location = new System.Drawing.Point(106, 26);
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(120, 32);
            this.heightNumericUpDown.TabIndex = 6;
            this.heightNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // settingGroupBox
            // 
            this.settingGroupBox.Controls.Add(this.cancelButton);
            this.settingGroupBox.Controls.Add(this.heightLabel);
            this.settingGroupBox.Controls.Add(this.okButton);
            this.settingGroupBox.Controls.Add(this.heightNumericUpDown);
            this.settingGroupBox.Controls.Add(this.widthLabel);
            this.settingGroupBox.Controls.Add(this.widthNumericUpDown);
            this.settingGroupBox.Controls.Add(this.minesLabel);
            this.settingGroupBox.Controls.Add(this.minesNumericUpDown);
            this.settingGroupBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settingGroupBox.Location = new System.Drawing.Point(12, 130);
            this.settingGroupBox.Name = "settingGroupBox";
            this.settingGroupBox.Size = new System.Drawing.Size(241, 203);
            this.settingGroupBox.TabIndex = 7;
            this.settingGroupBox.TabStop = false;
            this.settingGroupBox.Text = "Setting";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.cancelButton.Location = new System.Drawing.Point(132, 153);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 33);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.okButton.Location = new System.Drawing.Point(14, 153);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 33);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // soundEffectGroupBox
            // 
            this.soundEffectGroupBox.Controls.Add(this.slipSoundCheckBox);
            this.soundEffectGroupBox.Controls.Add(this.bombSoundCheckBox);
            this.soundEffectGroupBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundEffectGroupBox.Location = new System.Drawing.Point(12, 12);
            this.soundEffectGroupBox.Name = "soundEffectGroupBox";
            this.soundEffectGroupBox.Size = new System.Drawing.Size(241, 99);
            this.soundEffectGroupBox.TabIndex = 8;
            this.soundEffectGroupBox.TabStop = false;
            this.soundEffectGroupBox.Text = "sound effect";
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(265, 354);
            this.Controls.Add(this.soundEffectGroupBox);
            this.Controls.Add(this.settingGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSetting";
            this.Text = "GameSetting";
            ((System.ComponentModel.ISupportInitialize)(this.minesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            this.settingGroupBox.ResumeLayout(false);
            this.settingGroupBox.PerformLayout();
            this.soundEffectGroupBox.ResumeLayout(false);
            this.soundEffectGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox slipSoundCheckBox;
        private System.Windows.Forms.CheckBox bombSoundCheckBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label minesLabel;
        private System.Windows.Forms.NumericUpDown minesNumericUpDown;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.GroupBox settingGroupBox;
        private System.Windows.Forms.GroupBox soundEffectGroupBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}