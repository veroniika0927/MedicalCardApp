using System.Drawing;

namespace MedicalCardApp.Formes
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TreeView treeViewEntities;
        private System.Windows.Forms.DataGridView dataGridViewEntities;
        private System.Windows.Forms.Button buttonLoadXML;
        private System.Windows.Forms.Button buttonLoadJSON;
        private System.Windows.Forms.Button buttonShowDetails;
        private System.Windows.Forms.Button buttonResetData;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.treeViewEntities = new System.Windows.Forms.TreeView();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.dataGridViewEntities = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLoadXML = new System.Windows.Forms.Button();
            this.buttonLoadJSON = new System.Windows.Forms.Button();
            this.buttonShowDetails = new System.Windows.Forms.Button();
            this.buttonResetData = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntities)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.flowButtons.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 38);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.panelLeft);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.dataGridViewEntities);
            this.splitContainerMain.Panel2.Controls.Add(this.panelButtons);
            this.splitContainerMain.Size = new System.Drawing.Size(880, 352);
            this.splitContainerMain.SplitterDistance = 224;
            this.splitContainerMain.SplitterWidth = 3;
            this.splitContainerMain.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.treeViewEntities);
            this.panelLeft.Controls.Add(this.pictureBoxLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(224, 352);
            this.panelLeft.TabIndex = 2;
            // 
            // treeViewEntities
            // 
            this.treeViewEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewEntities.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.treeViewEntities.Location = new System.Drawing.Point(0, 0);
            this.treeViewEntities.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewEntities.Name = "treeViewEntities";
            this.treeViewEntities.Size = new System.Drawing.Size(224, 202);
            this.treeViewEntities.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxLogo.Image = global::MedicalCardApp.Properties.Resources.medical_icon;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 202);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(224, 150);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // dataGridViewEntities
            // 
            this.dataGridViewEntities.AllowUserToAddRows = false;
            this.dataGridViewEntities.AllowUserToDeleteRows = false;
            this.dataGridViewEntities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEntities.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEntities.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEntities.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEntities.Name = "dataGridViewEntities";
            this.dataGridViewEntities.ReadOnly = true;
            this.dataGridViewEntities.RowHeadersWidth = 51;
            this.dataGridViewEntities.Size = new System.Drawing.Size(653, 288);
            this.dataGridViewEntities.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.LightGray;
            this.panelButtons.Controls.Add(this.flowButtons);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 288);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(2);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(653, 64);
            this.panelButtons.TabIndex = 1;
            // 
            // flowButtons
            // 
            this.flowButtons.Controls.Add(this.buttonLoadXML);
            this.flowButtons.Controls.Add(this.buttonLoadJSON);
            this.flowButtons.Controls.Add(this.buttonShowDetails);
            this.flowButtons.Controls.Add(this.buttonResetData);
            this.flowButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowButtons.Location = new System.Drawing.Point(0, 0);
            this.flowButtons.Margin = new System.Windows.Forms.Padding(2);
            this.flowButtons.Name = "flowButtons";
            this.flowButtons.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.flowButtons.Size = new System.Drawing.Size(653, 64);
            this.flowButtons.TabIndex = 0;
            // 
            // buttonLoadXML
            // 
            this.buttonLoadXML.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonLoadXML.Location = new System.Drawing.Point(10, 7);
            this.buttonLoadXML.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoadXML.Name = "buttonLoadXML";
            this.buttonLoadXML.Size = new System.Drawing.Size(170, 46);
            this.buttonLoadXML.TabIndex = 0;
            this.buttonLoadXML.Text = "Загрузить XML";
            this.buttonLoadXML.UseVisualStyleBackColor = true;
            // 
            // buttonLoadJSON
            // 
            this.buttonLoadJSON.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonLoadJSON.Location = new System.Drawing.Point(184, 7);
            this.buttonLoadJSON.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoadJSON.Name = "buttonLoadJSON";
            this.buttonLoadJSON.Size = new System.Drawing.Size(176, 46);
            this.buttonLoadJSON.TabIndex = 1;
            this.buttonLoadJSON.Text = "Загрузить JSON";
            this.buttonLoadJSON.UseVisualStyleBackColor = true;
            // 
            // buttonShowDetails
            // 
            this.buttonShowDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShowDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonShowDetails.Location = new System.Drawing.Point(364, 7);
            this.buttonShowDetails.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowDetails.Name = "buttonShowDetails";
            this.buttonShowDetails.Size = new System.Drawing.Size(126, 46);
            this.buttonShowDetails.TabIndex = 2;
            this.buttonShowDetails.Text = "Подробно";
            this.buttonShowDetails.UseVisualStyleBackColor = false;
            // 
            // buttonResetData
            // 
            this.buttonResetData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonResetData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonResetData.Location = new System.Drawing.Point(494, 7);
            this.buttonResetData.Margin = new System.Windows.Forms.Padding(2);
            this.buttonResetData.Name = "buttonResetData";
            this.buttonResetData.Size = new System.Drawing.Size(94, 46);
            this.buttonResetData.TabIndex = 3;
            this.buttonResetData.Text = "Сброс";
            this.buttonResetData.UseVisualStyleBackColor = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(880, 38);
            this.panelTop.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.LightGray;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(880, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Медицинская карта пациента";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 390);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(724, 369);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Медицинская карта пациента";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntities)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.flowButtons.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}