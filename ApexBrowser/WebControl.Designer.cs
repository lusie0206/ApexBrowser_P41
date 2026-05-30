namespace ApexBrowser
{
    partial class WebControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            webView2Control = new Microsoft.Web.WebView2.WinForms.WebView2();
            labelHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)webView2Control).BeginInit();
            SuspendLayout();
            // 
            // webView2Control
            // 
            webView2Control.AllowExternalDrop = true;
            webView2Control.CreationProperties = null;
            webView2Control.DefaultBackgroundColor = Color.White;
            webView2Control.Location = new Point(0, 36);
            webView2Control.Name = "webView2Control";
            webView2Control.Size = new Size(448, 247);
            webView2Control.TabIndex = 0;
            webView2Control.ZoomFactor = 1D;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Location = new Point(3, 9);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(75, 20);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "<header>";
            // 
            // WebControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelHeader);
            Controls.Add(webView2Control);
            Name = "WebControl";
            Size = new Size(454, 286);
            Load += WebControl_Load;
            ((System.ComponentModel.ISupportInitialize)webView2Control).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView2Control;
        private Label labelHeader;
    }
}
