namespace ImageEnhancingUtility.Winforms.DarkForms
{
    partial class ModelTreeviewForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ok_button = new AltUI.Controls.DarkButton();
            this.mainPanel = new AltUI.Controls.DarkSectionPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ok_button, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mainPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.36842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.631579F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 760);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ok_button
            // 
            this.ok_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ok_button.FlatBottom = false;
            this.ok_button.FlatTop = false;
            this.ok_button.HoldColour = false;
            this.ok_button.Location = new System.Drawing.Point(209, 705);
            this.ok_button.Name = "ok_button";
            this.ok_button.Padding = new System.Windows.Forms.Padding(5);
            this.ok_button.Size = new System.Drawing.Size(200, 52);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "CONFIRM";
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // mainPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.mainPanel, 2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.SectionHeader = null;
            this.mainPanel.Size = new System.Drawing.Size(406, 696);
            this.mainPanel.TabIndex = 1;
            // 
            // ModelTreeviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 760);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ModelTreeviewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ModelTreeviewForm";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AltUI.Controls.DarkButton ok_button;
        private AltUI.Controls.DarkSectionPanel mainPanel;
    }
}