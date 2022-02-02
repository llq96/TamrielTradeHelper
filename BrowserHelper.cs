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
                UserDataDirectory = @"D:\VladsBrowserData",
                LicenseKey = "1BNKDJZJSD5MAKB9FS6K7OFSPMDAL4K6AEKAX41BPBRR4K93KKISN14ZUZ80ASEHIPQL7O"
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
