using ApexBrowser.Interfaces;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ApexBrowser
{
    public partial class WebControl : UserControl, IWebControl
    {
        private const string startupUrl = "https://developer.microsoft.com/en-us/microsoft-edge/webview2/?form=MA13LH";

        public WebControl()
        {
            InitializeComponent();
        }

        public WebControl(int width, int height)
        {
            InitializeComponent();

            this.Width = width;
            this.Height = height;
        }

        private void WebControl_Load(object sender, EventArgs e)
        {
            InitializeWebView();
            webView2Control.EnsureCoreWebView2Async();

            WebControlStorage.Instance.ActiveWebControlChanged += Instance_ActiveWebControlChanged;
        }

        private void Instance_ActiveWebControlChanged(object? sender, EventArgs e)
        {
            bool equals = false;

            if (WebControlStorage.Instance.GetActualWebControl() is IWebControl webControl)
            {
                equals = webControl == this;
            }

            labelHeader.Font = equals
                ? new System.Drawing.Font(labelHeader.Font, labelHeader.Font.Style | FontStyle.Bold)
                : new System.Drawing.Font(labelHeader.Font, labelHeader.Font.Style & ~FontStyle.Bold);
        }

        private void InitializeWebView()
        {
            if (webView2Control != null)
            {
                // 1. Event to get state that Core is loaded
                webView2Control.CoreWebView2InitializationCompleted += (sender, e) =>
                {
                    if (e.IsSuccess)
                    {
                        // 2. Event to get state that new page is loaded
                        webView2Control.CoreWebView2.NavigationCompleted += (sender, e2) =>
                        {
                            if (!e.IsSuccess)
                            {
                                MessageBox.Show($"Page loading error {e2.WebErrorStatus}");
                            }

                            WebControlStorage.Instance.NotifyNavigationCompleted();
                        };

                        // Make naviagtion
                        Navigate(startupUrl);
                    }
                    else
                    {
                        MessageBox.Show($"WebView2 initialization error: {e.InitializationException.Message}");
                    }
                };
            }
        }

        private void WebControl_Click(object sender, EventArgs e)
        {
            WebControlStorage.Instance.SetActiveWebControl(this as IWebControl);
        }

        #region IWebControl

        public void GoBack()
        {
            webView2Control.GoBack();
        }

        public void GoForward()
        {
            webView2Control.GoForward();
        }

        public void Reload()
        {
            webView2Control.Reload();
        }

        public void Navigate(string query)
        {
            if (!string.IsNullOrEmpty(query))
            {
                if (!query.StartsWith("http://") && !query.StartsWith("https://"))
                {
                    query = $"https://www.google.com/search?q={Uri.EscapeDataString(query)}";
                }
                
                webView2Control.Source = new Uri(query);
            }
        }

        public string GetCurrentUrl() => webView2Control.Source?.AbsoluteUri ?? string.Empty;

        public WebView2 GetWebView2Instance() => webView2Control;
        #endregion
    }

}
