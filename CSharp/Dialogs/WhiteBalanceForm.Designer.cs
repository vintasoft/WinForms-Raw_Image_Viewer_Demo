namespace RawImageViewerDemo
{
    partial class WhiteBalanceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.redValueTrackBar = new System.Windows.Forms.TrackBar();
            this.redValueLabel = new System.Windows.Forms.Label();
            this.greenValueLabel = new System.Windows.Forms.Label();
            this.blueValueLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.greenValueTrackBar = new System.Windows.Forms.TrackBar();
            this.blueValueTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.redValueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenValueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueValueTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Green";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Blue";
            // 
            // redValueTrackBar
            // 
            this.redValueTrackBar.Location = new System.Drawing.Point(48, 12);
            this.redValueTrackBar.Maximum = 50;
            this.redValueTrackBar.Name = "redValueTrackBar";
            this.redValueTrackBar.Size = new System.Drawing.Size(196, 45);
            this.redValueTrackBar.TabIndex = 0;
            this.redValueTrackBar.ValueChanged += new System.EventHandler(this.redValueTrackBar_ValueChanged);
            // 
            // redValueLabel
            // 
            this.redValueLabel.AutoSize = true;
            this.redValueLabel.Location = new System.Drawing.Point(250, 28);
            this.redValueLabel.Name = "redValueLabel";
            this.redValueLabel.Size = new System.Drawing.Size(22, 13);
            this.redValueLabel.TabIndex = 2;
            this.redValueLabel.Text = "0.0";
            // 
            // greenValueLabel
            // 
            this.greenValueLabel.AutoSize = true;
            this.greenValueLabel.Location = new System.Drawing.Point(250, 79);
            this.greenValueLabel.Name = "greenValueLabel";
            this.greenValueLabel.Size = new System.Drawing.Size(22, 13);
            this.greenValueLabel.TabIndex = 5;
            this.greenValueLabel.Text = "0.0";
            // 
            // blueValueLabel
            // 
            this.blueValueLabel.AutoSize = true;
            this.blueValueLabel.Location = new System.Drawing.Point(250, 130);
            this.blueValueLabel.Name = "blueValueLabel";
            this.blueValueLabel.Size = new System.Drawing.Size(22, 13);
            this.blueValueLabel.TabIndex = 8;
            this.blueValueLabel.Text = "0.0";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(107, 165);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(188, 165);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // greenValueTrackBar
            // 
            this.greenValueTrackBar.Location = new System.Drawing.Point(48, 63);
            this.greenValueTrackBar.Maximum = 50;
            this.greenValueTrackBar.Name = "greenValueTrackBar";
            this.greenValueTrackBar.Size = new System.Drawing.Size(196, 45);
            this.greenValueTrackBar.TabIndex = 12;
            this.greenValueTrackBar.ValueChanged += new System.EventHandler(this.greenValueTrackBar_ValueChanged);
            // 
            // blueValueTrackBar
            // 
            this.blueValueTrackBar.Location = new System.Drawing.Point(48, 114);
            this.blueValueTrackBar.Maximum = 50;
            this.blueValueTrackBar.Name = "blueValueTrackBar";
            this.blueValueTrackBar.Size = new System.Drawing.Size(196, 45);
            this.blueValueTrackBar.TabIndex = 13;
            this.blueValueTrackBar.ValueChanged += new System.EventHandler(this.blueValueTrackBar_ValueChanged);
            // 
            // WhiteBalance
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(279, 198);
            this.Controls.Add(this.blueValueTrackBar);
            this.Controls.Add(this.greenValueTrackBar);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.blueValueLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.greenValueLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.redValueLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redValueTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WhiteBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhiteBalance";
            ((System.ComponentModel.ISupportInitialize)(this.redValueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenValueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueValueTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar redValueTrackBar;
        private System.Windows.Forms.Label redValueLabel;
        private System.Windows.Forms.Label greenValueLabel;
        private System.Windows.Forms.Label blueValueLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TrackBar greenValueTrackBar;
        private System.Windows.Forms.TrackBar blueValueTrackBar;
    }
}