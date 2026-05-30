using ApexBrowser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexBrowser;

internal sealed class WebControlStorage
{
    #region Singleton
    public static WebControlStorage Instance { get; } = new();

    private WebControlStorage()
    {
    }

    static WebControlStorage()
    {
    }
    #endregion

    public event EventHandler ActiveWebControlChanged;
    public event EventHandler NotifyWebControlNavigationCompleted;

    private IWebControl webControl;


    public IWebControl GetActualWebControl() => webControl;

    public void SetActiveWebControl(IWebControl webControl)
    {
        this.webControl = webControl;

        ActiveWebControlChanged?.Invoke(null, EventArgs.Empty);
    }

    public void NotifyNavigationCompleted()
    {
        NotifyWebControlNavigationCompleted?.Invoke(null, EventArgs.Empty);
    }
}
