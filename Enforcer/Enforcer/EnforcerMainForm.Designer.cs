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
            this.grpDescription = new System.Windows.Forms.GroupBox();
            this.txtItemDesc = new System.Windows.Forms.TextBox();
            this.PanelInstallItems = new System.Windows.Forms.Panel();
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
            // grpDescription
            // 
            this.grpDescription.Controls.Add(this.txtItemDesc);
            this.grpDescription.Location = new System.Drawing.Point(12, 322);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(765, 106);
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
            this.txtItemDesc.Size = new System.Drawing.Size(752, 72);
            this.txtItemDesc.TabIndex = 0;
            // 
            // PanelInstallItems
            // 
            this.PanelInstallItems.AutoScroll = true;
            this.PanelInstallItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelInstallItems.Location = new System.Drawing.Point(12, 43);
            this.PanelInstallItems.Name = "PanelInstallItems";
            this.PanelInstallItems.Size = new System.Drawing.Size(765, 263);
            this.PanelInstallItems.TabIndex = 4;
            // 
            // EnforcerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 469);
            this.Controls.Add(this.PanelInstallItems);
            this.Controls.Add(this.grpDescription);
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
        private System.Windows.Forms.GroupBox grpDescription;
        private System.Windows.Forms.TextBox txtItemDesc;
        private System.Windows.Forms.Panel PanelInstallItems;

    }
}

