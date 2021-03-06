﻿namespace River.OneMoreAddIn.Dialogs
{
	partial class ResizeImagesDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResizeImagesDialog));
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.pctRadio = new System.Windows.Forms.RadioButton();
			this.absRadio = new System.Windows.Forms.RadioButton();
			this.pctUpDown = new System.Windows.Forms.NumericUpDown();
			this.pctLabel = new System.Windows.Forms.Label();
			this.aspectBox = new System.Windows.Forms.CheckBox();
			this.widthUpDown = new System.Windows.Forms.NumericUpDown();
			this.heightUpDown = new System.Windows.Forms.NumericUpDown();
			this.widthLabel = new System.Windows.Forms.Label();
			this.heightLabel = new System.Windows.Forms.Label();
			this.currentLabel = new System.Windows.Forms.Label();
			this.sizeLabel = new System.Windows.Forms.Label();
			this.presetRadio = new System.Windows.Forms.RadioButton();
			this.presetUpDown = new System.Windows.Forms.NumericUpDown();
			this.presetLabel = new System.Windows.Forms.Label();
			this.origLabel = new System.Windows.Forms.Label();
			this.origSizeLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pctUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.presetUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(280, 349);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(100, 38);
			this.cancelButton.TabIndex = 0;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.Cancel);
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.Location = new System.Drawing.Point(174, 349);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(100, 38);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.OK);
			// 
			// pctRadio
			// 
			this.pctRadio.AutoSize = true;
			this.pctRadio.Checked = true;
			this.pctRadio.Location = new System.Drawing.Point(17, 113);
			this.pctRadio.Name = "pctRadio";
			this.pctRadio.Size = new System.Drawing.Size(116, 24);
			this.pctRadio.TabIndex = 2;
			this.pctRadio.TabStop = true;
			this.pctRadio.Text = "Percentage";
			this.pctRadio.UseVisualStyleBackColor = true;
			this.pctRadio.Click += new System.EventHandler(this.Radio_Click);
			// 
			// absRadio
			// 
			this.absRadio.AutoSize = true;
			this.absRadio.Location = new System.Drawing.Point(17, 166);
			this.absRadio.Name = "absRadio";
			this.absRadio.Size = new System.Drawing.Size(97, 24);
			this.absRadio.TabIndex = 3;
			this.absRadio.Text = "Absolute";
			this.absRadio.UseVisualStyleBackColor = true;
			this.absRadio.Click += new System.EventHandler(this.Radio_Click);
			// 
			// pctUpDown
			// 
			this.pctUpDown.Location = new System.Drawing.Point(148, 113);
			this.pctUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			this.pctUpDown.Name = "pctUpDown";
			this.pctUpDown.Size = new System.Drawing.Size(95, 26);
			this.pctUpDown.TabIndex = 4;
			this.pctUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.pctUpDown.ValueChanged += new System.EventHandler(this.pctUpDown_ValueChanged);
			// 
			// pctLabel
			// 
			this.pctLabel.AutoSize = true;
			this.pctLabel.Location = new System.Drawing.Point(249, 115);
			this.pctLabel.Name = "pctLabel";
			this.pctLabel.Size = new System.Drawing.Size(23, 20);
			this.pctLabel.TabIndex = 5;
			this.pctLabel.Text = "%";
			// 
			// aspectBox
			// 
			this.aspectBox.AutoSize = true;
			this.aspectBox.Checked = true;
			this.aspectBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.aspectBox.Enabled = false;
			this.aspectBox.Location = new System.Drawing.Point(148, 167);
			this.aspectBox.Name = "aspectBox";
			this.aspectBox.Size = new System.Drawing.Size(182, 24);
			this.aspectBox.TabIndex = 6;
			this.aspectBox.Text = "Maintain aspect ratio";
			this.aspectBox.UseVisualStyleBackColor = true;
			this.aspectBox.CheckedChanged += new System.EventHandler(this.aspectBox_CheckedChanged);
			// 
			// widthUpDown
			// 
			this.widthUpDown.Enabled = false;
			this.widthUpDown.Location = new System.Drawing.Point(148, 199);
			this.widthUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.widthUpDown.Name = "widthUpDown";
			this.widthUpDown.Size = new System.Drawing.Size(145, 26);
			this.widthUpDown.TabIndex = 7;
			this.widthUpDown.ValueChanged += new System.EventHandler(this.widthUpDown_ValueChanged);
			// 
			// heightUpDown
			// 
			this.heightUpDown.Enabled = false;
			this.heightUpDown.Location = new System.Drawing.Point(148, 231);
			this.heightUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.heightUpDown.Name = "heightUpDown";
			this.heightUpDown.Size = new System.Drawing.Size(145, 26);
			this.heightUpDown.TabIndex = 8;
			this.heightUpDown.ValueChanged += new System.EventHandler(this.heightUpDown_ValueChanged);
			// 
			// widthLabel
			// 
			this.widthLabel.AutoSize = true;
			this.widthLabel.Location = new System.Drawing.Point(299, 201);
			this.widthLabel.Name = "widthLabel";
			this.widthLabel.Size = new System.Drawing.Size(50, 20);
			this.widthLabel.TabIndex = 9;
			this.widthLabel.Text = "Width";
			// 
			// heightLabel
			// 
			this.heightLabel.AutoSize = true;
			this.heightLabel.Location = new System.Drawing.Point(299, 233);
			this.heightLabel.Name = "heightLabel";
			this.heightLabel.Size = new System.Drawing.Size(56, 20);
			this.heightLabel.TabIndex = 10;
			this.heightLabel.Text = "Height";
			// 
			// currentLabel
			// 
			this.currentLabel.AutoSize = true;
			this.currentLabel.Location = new System.Drawing.Point(40, 33);
			this.currentLabel.Name = "currentLabel";
			this.currentLabel.Size = new System.Drawing.Size(94, 20);
			this.currentLabel.TabIndex = 11;
			this.currentLabel.Text = "Current size";
			// 
			// sizeLabel
			// 
			this.sizeLabel.AutoSize = true;
			this.sizeLabel.Location = new System.Drawing.Point(144, 33);
			this.sizeLabel.Name = "sizeLabel";
			this.sizeLabel.Size = new System.Drawing.Size(78, 20);
			this.sizeLabel.TabIndex = 12;
			this.sizeLabel.Text = "100 x 100";
			// 
			// presetRadio
			// 
			this.presetRadio.AutoSize = true;
			this.presetRadio.Location = new System.Drawing.Point(17, 287);
			this.presetRadio.Name = "presetRadio";
			this.presetRadio.Size = new System.Drawing.Size(80, 24);
			this.presetRadio.TabIndex = 13;
			this.presetRadio.Text = "Preset";
			this.presetRadio.UseVisualStyleBackColor = true;
			this.presetRadio.Click += new System.EventHandler(this.Radio_Click);
			// 
			// presetUpDown
			// 
			this.presetUpDown.Enabled = false;
			this.presetUpDown.Location = new System.Drawing.Point(148, 287);
			this.presetUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.presetUpDown.Name = "presetUpDown";
			this.presetUpDown.Size = new System.Drawing.Size(145, 26);
			this.presetUpDown.TabIndex = 14;
			this.presetUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			// 
			// presetLabel
			// 
			this.presetLabel.AutoSize = true;
			this.presetLabel.Location = new System.Drawing.Point(299, 289);
			this.presetLabel.Name = "presetLabel";
			this.presetLabel.Size = new System.Drawing.Size(50, 20);
			this.presetLabel.TabIndex = 15;
			this.presetLabel.Text = "Width";
			// 
			// origLabel
			// 
			this.origLabel.AutoSize = true;
			this.origLabel.Location = new System.Drawing.Point(40, 53);
			this.origLabel.Name = "origLabel";
			this.origLabel.Size = new System.Drawing.Size(94, 20);
			this.origLabel.TabIndex = 16;
			this.origLabel.Text = "Original size";
			// 
			// origSizeLabel
			// 
			this.origSizeLabel.AutoSize = true;
			this.origSizeLabel.Location = new System.Drawing.Point(144, 53);
			this.origSizeLabel.Name = "origSizeLabel";
			this.origSizeLabel.Size = new System.Drawing.Size(78, 20);
			this.origSizeLabel.TabIndex = 17;
			this.origSizeLabel.Text = "100 x 100";
			// 
			// ResizeImagesDialog
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(397, 404);
			this.Controls.Add(this.origSizeLabel);
			this.Controls.Add(this.origLabel);
			this.Controls.Add(this.presetLabel);
			this.Controls.Add(this.presetUpDown);
			this.Controls.Add(this.presetRadio);
			this.Controls.Add(this.sizeLabel);
			this.Controls.Add(this.currentLabel);
			this.Controls.Add(this.heightLabel);
			this.Controls.Add(this.widthLabel);
			this.Controls.Add(this.heightUpDown);
			this.Controls.Add(this.widthUpDown);
			this.Controls.Add(this.aspectBox);
			this.Controls.Add(this.pctLabel);
			this.Controls.Add(this.pctUpDown);
			this.Controls.Add(this.absRadio);
			this.Controls.Add(this.pctRadio);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ResizeImagesDialog";
			this.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Resize Image";
			((System.ComponentModel.ISupportInitialize)(this.pctUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.presetUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.RadioButton pctRadio;
		private System.Windows.Forms.RadioButton absRadio;
		private System.Windows.Forms.NumericUpDown pctUpDown;
		private System.Windows.Forms.Label pctLabel;
		private System.Windows.Forms.CheckBox aspectBox;
		private System.Windows.Forms.NumericUpDown widthUpDown;
		private System.Windows.Forms.NumericUpDown heightUpDown;
		private System.Windows.Forms.Label widthLabel;
		private System.Windows.Forms.Label heightLabel;
		private System.Windows.Forms.Label currentLabel;
		private System.Windows.Forms.Label sizeLabel;
		private System.Windows.Forms.RadioButton presetRadio;
		private System.Windows.Forms.NumericUpDown presetUpDown;
		private System.Windows.Forms.Label presetLabel;
		private System.Windows.Forms.Label origLabel;
		private System.Windows.Forms.Label origSizeLabel;
	}
}