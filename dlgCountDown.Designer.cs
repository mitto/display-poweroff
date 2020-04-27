namespace DisplayPowerOff
{
	partial class dlgCountDown
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
			this.components = new System.ComponentModel.Container();
			this.lblCountdown = new System.Windows.Forms.Label();
			this.pbarCountDown = new System.Windows.Forms.ProgressBar();
			this.timerMain = new System.Windows.Forms.Timer(this.components);
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblCountdown
			// 
			this.lblCountdown.AutoSize = true;
			this.lblCountdown.Location = new System.Drawing.Point(12, 17);
			this.lblCountdown.Name = "lblCountdown";
			this.lblCountdown.Size = new System.Drawing.Size(35, 12);
			this.lblCountdown.TabIndex = 0;
			this.lblCountdown.Text = "label1";
			// 
			// pbarCountDown
			// 
			this.pbarCountDown.Location = new System.Drawing.Point(14, 41);
			this.pbarCountDown.Name = "pbarCountDown";
			this.pbarCountDown.Size = new System.Drawing.Size(301, 23);
			this.pbarCountDown.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.pbarCountDown.TabIndex = 1;
			this.pbarCountDown.Value = 100;
			// 
			// timerMain
			// 
			this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(223, 12);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(92, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "button1";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// dlgCountDown
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(327, 83);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.pbarCountDown);
			this.Controls.Add(this.lblCountdown);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "dlgCountDown";
			this.ShowInTaskbar = false;
			this.Text = "dlgCountDown";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCountdown;
		private System.Windows.Forms.ProgressBar pbarCountDown;
		private System.Windows.Forms.Timer timerMain;
		private System.Windows.Forms.Button btnCancel;
	}
}