namespace MedicalCardApp.Formes
{
    partial class EntityDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelScroll;
        public System.Windows.Forms.Panel panelDetails;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelScroll.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelScroll);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Controls.Add(this.panelButton);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(560, 320);
            this.panelMain.TabIndex = 0;
            // 
            // panelScroll
            // 
            this.panelScroll.AutoScroll = true;
            this.panelScroll.Controls.Add(this.panelDetails);
            this.panelScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScroll.Location = new System.Drawing.Point(0, 38);
            this.panelScroll.Margin = new System.Windows.Forms.Padding(2);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(560, 232);
            this.panelScroll.TabIndex = 0;
            // 
            // panelDetails
            // 
            this.panelDetails.AutoSize = true;
            this.panelDetails.BackColor = System.Drawing.Color.White;
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetails.Location = new System.Drawing.Point(0, 0);
            this.panelDetails.Margin = new System.Windows.Forms.Padding(2);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(560, 0);
            this.panelDetails.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(560, 38);
            this.panelHeader.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.White;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(560, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Информация";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.LightGray;
            this.panelButton.Controls.Add(this.buttonClose);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 270);
            this.panelButton.Margin = new System.Windows.Forms.Padding(2);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(560, 50);
            this.panelButton.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.LightGray;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(219, 4);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 44);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // EntityDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 320);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EntityDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подробная информация";
            this.panelMain.ResumeLayout(false);
            this.panelScroll.ResumeLayout(false);
            this.panelScroll.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}