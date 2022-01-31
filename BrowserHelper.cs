using DotNetBrowser.Browser;
using DotNetBrowser.Engine;
using DotNetBrowser.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamrielTradeApp {
    public class BrowserHelper {
        public IBrowser browser { get; private set; }
        public IEngine engine { get; private set; }
        public BrowserView browserView { get; private set; }

        public void Init() {
            //Create the Windows Forms BrowserView control.
            browserView = new BrowserView {
                Dock = DockStyle.Fill,
                Padding = new Padding(5, 5, 5, 5)
            };

            // Create and initialize the IEngine instance.
            EngineOptions engineOptions = new EngineOptions.Builder {
                RenderingMode = RenderingMode.HardwareAccelerated,
                UserDataDirectory = @"D:\VladsBrowserData",
                LicenseKey = "1BNKDJZJSD5MAKB9FS6K7OFSPMDAL4K6AEKAX41BPBRR4K93KKISN14ZUZ80ASEHIPQL7O"
            }.Build();
            engine = EngineFactory.Create(engineOptions);

            // Create the IBrowser instance.
            browser = engine.CreateBrowser();
        }

        public void Init2() {
            browserView.InitializeFrom(browser);
            browserView.Hide();
        }
    }
}
