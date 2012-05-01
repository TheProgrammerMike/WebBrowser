namespace _122908WebBrowser
{
    partial class txtADDRESS
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
            this.btnGO = new System.Windows.Forms.Button();
            this.txtHTML = new System.Windows.Forms.TextBox();
            this.webBROWSERWINDOW = new System.Windows.Forms.WebBrowser();
            this.lblLOADING = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(1183, 12);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(75, 23);
            this.btnGO.TabIndex = 0;
            this.btnGO.Text = "Go";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // txtHTML
            // 
            this.txtHTML.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtHTML.Location = new System.Drawing.Point(12, 14);
            this.txtHTML.Name = "txtHTML";
            this.txtHTML.Size = new System.Drawing.Size(1165, 20);
            this.txtHTML.TabIndex = 1;
            this.txtHTML.Text = "Type Address";
            this.txtHTML.TextChanged += new System.EventHandler(this.txtHTML_TextChanged);
            // 
            // webBROWSERWINDOW
            // 
            this.webBROWSERWINDOW.Location = new System.Drawing.Point(12, 40);
            this.webBROWSERWINDOW.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBROWSERWINDOW.Name = "webBROWSERWINDOW";
            this.webBROWSERWINDOW.Size = new System.Drawing.Size(1246, 509);
            this.webBROWSERWINDOW.TabIndex = 2;
            this.webBROWSERWINDOW.Url = new System.Uri("about:Welcome to my Browser", System.UriKind.Absolute);
            // 
            // lblLOADING
            // 
            this.lblLOADING.AutoSize = true;
            this.lblLOADING.Location = new System.Drawing.Point(594, 312);
            this.lblLOADING.Name = "lblLOADING";
            this.lblLOADING.Size = new System.Drawing.Size(54, 13);
            this.lblLOADING.TabIndex = 3;
            this.lblLOADING.Text = "Loading...";
            this.lblLOADING.Visible = false;
            // 
            // txtADDRESS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 561);
            this.Controls.Add(this.lblLOADING);
            this.Controls.Add(this.webBROWSERWINDOW);
            this.Controls.Add(this.txtHTML);
            this.Controls.Add(this.btnGO);
            this.Name = "txtADDRESS";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.txtADDRESS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.TextBox txtHTML;
        private System.Windows.Forms.WebBrowser webBROWSERWINDOW;
        private System.Windows.Forms.Label lblLOADING;
    }
}

