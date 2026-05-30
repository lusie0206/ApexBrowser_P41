using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexBrowser.Interfaces;

public interface IWebControl
{
    void GoBack();
    void GoForward();
    void Reload();
    void Navigate(string query);
    string GetCurrentUrl();

    WebView2 GetWebView2Instance();
}
