using DotNetBrowser.Browser;
using DotNetBrowser.Engine;
using DotNetBrowser.WinForms;
using System.Windows.Forms;

namespace TamrielTradeApp {
    public class BrowserHelper {
        public IBrowser browser { get; private set; }
        public IEngine engine { get; private set; }
        public BrowserView browserView { get; private set; }

        public void Init() {
            browserView = new BrowserView {
                Dock = DockStyle.Fill,
                Padding = new Padding(5, 5, 5, 5)
            };

            EngineOptions engineOptions = new EngineOptions.Builder {
                RenderingMode = RenderingMode.HardwareAccelerated,
                UserDataDirectory = @"E:\VladsBrowserData2",
                LicenseKey = "1BNKDJZJSD5VJJ6NK6AD934GT2X3I8299ICGB9SZO8ALY6JCBCO64DB99V3W0N6Q3XGXU1"
            }.Build();
            engine = EngineFactory.Create(engineOptions);

            browser = engine.CreateBrowser();
        }

        public void Init2() {
            browserView.InitializeFrom(browser);
            browserView.Hide();
        }
    }
}
