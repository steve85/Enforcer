namespace Enforcer
{
    partial class EnforcerMainForm
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
            this.lblInstallItems = new System.Windows.Forms.Label();
            this.ListBoxInstallItems = new System.Windows.Forms.ListBox();
            this.grpDescription = new System.Windows.Forms.GroupBox();
            this.txtItemDesc = new System.Windows.Forms.TextBox();
            this.grpDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstallItems
            // 
            this.lblInstallItems.AutoSize = true;
            this.lblInstallItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallItems.Location = new System.Drawing.Point(12, 23);
            this.lblInstallItems.Name = "lblInstallItems";
            this.lblInstallItems.Size = new System.Drawing.Size(130, 17);
            this.lblInstallItems.TabIndex = 1;
            this.lblInstallItems.Text = "Installation Items";
            // 
            // ListBoxInstallItems
            // 
            this.ListBoxInstallItems.FormattingEnabled = true;
            this.ListBoxInstallItems.ItemHeight = 16;
            this.ListBoxInstallItems.Location = new System.Drawing.Point(16, 46);
            this.ListBoxInstallItems.Name = "ListBoxInstallItems";
            this.ListBoxInstallItems.Size = new System.Drawing.Size(445, 244);
            this.ListBoxInstallItems.TabIndex = 2;
            this.ListBoxInstallItems.SelectedIndexChanged += new System.EventHandler(this.ListBoxInstallItems_SelectedIndexChanged);
            // 
            // grpDescription
            // 
            this.grpDescription.Controls.Add(this.txtItemDesc);
            this.grpDescription.Location = new System.Drawing.Point(16, 322);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(445, 106);
            this.grpDescription.TabIndex = 3;
            this.grpDescription.TabStop = false;
            this.grpDescription.Text = "Item Description";
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.Location = new System.Drawing.Point(7, 22);
            this.txtItemDesc.Multiline = true;
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.ReadOnly = true;
            this.txtItemDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtItemDesc.Size = new System.Drawing.Size(432, 72);
            this.txtItemDesc.TabIndex = 0;
            // 
            // EnforcerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 469);
            this.Controls.Add(this.grpDescription);
            this.Controls.Add(this.ListBoxInstallItems);
            this.Controls.Add(this.lblInstallItems);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnforcerMainForm";
            this.Text = "Enforcer";
            this.grpDescription.ResumeLayout(false);
            this.grpDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstallItems;
        private System.Windows.Forms.ListBox ListBoxInstallItems;
        private System.Windows.Forms.GroupBox grpDescription;
        private System.Windows.Forms.TextBox txtItemDesc;

    }
}

