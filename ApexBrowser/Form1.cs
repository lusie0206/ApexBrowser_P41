using ApexBrowser.Interfaces;
using Microsoft.Web.WebView2.WinForms;

namespace ApexBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WebControlStorage.Instance.ActiveWebControlChanged += Instance_ActiveWebControlChanged;
            WebControlStorage.Instance.NotifyWebControlNavigationCompleted += Instance_NotifyWebControlNavigationCompleted;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetInitialState();
        }

        private void SetInitialState()
        {
            buttonBack.Enabled = false;
            buttonForward.Enabled = false;
            textBoxUrl.Text = string.Empty;
        }

        private void Instance_ActiveWebControlChanged(object? sender, EventArgs e)
        {
            UpdateNavigationPanelState();
        }

        private void Instance_NotifyWebControlNavigationCompleted(object? sender, EventArgs e)
        {
            UpdateNavigationPanelState();
        }

        private IWebControl GetWebControl() => WebControlStorage.Instance.GetActualWebControl();

        private void UpdateNavigationPanelState()
        {
            if (GetWebControl() is IWebControl webControl &&
                webControl.GetWebView2Instance() is WebView2 webView2)
            {
                string currentUrl = webControl.GetCurrentUrl();
                bool canGoBack = webView2.CanGoBack;
                bool canGoForward = webView2.CanGoForward;
                bool isReloadActive = !string.IsNullOrWhiteSpace(currentUrl);

                textBoxUrl.Text = currentUrl;
                buttonBack.Enabled = canGoBack;
                buttonForward.Enabled = canGoForward;
                buttonReload.Enabled = isReloadActive;
            }
        }
        
        private void buttonBack_Click(object sender, EventArgs e)
        {
            GetWebControl()?.GoBack();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            GetWebControl()?.GoForward();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            GetWebControl()?.Reload();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            GetWebControl()?.Navigate(textBoxUrl.Text);
        }

        private void textBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetWebControl()?.Navigate(textBoxUrl.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 16x9
            int width = (flowLayoutPanel1.Width - 20) / 2;
            int height = (int)(width * 0.5625);
            flowLayoutPanel1.Controls.Add(new WebControl(width, height));
        }
    }
}
