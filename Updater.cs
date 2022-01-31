using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using VladB.Utility;

namespace TamrielTradeApp {
    public class Updater {
        Form1 form => Form1.instance;
        //public float timeUpdate_ItemList = 10f;
        //public float timeUpdate_ProgressBarUpdateValue = 0.5f;
        //public float timeUpdate_BtnUnHide = 1f;

        public Timer timer_updateBtnUnHide = new Timer(1f);
        public Timer timer_updateProgressBar = new Timer(0.05f);
        public Timer timer_updateItemList = new Timer(5f);


        public List<Timer> timers;

        public void Init() {
            timers = new List<Timer>() { 
                timer_updateBtnUnHide,
                timer_updateProgressBar,
                timer_updateItemList
            };
            //timers.AddRange(new List<Timer>() { timer_updateBtnUnHide, timer_updateItemList });

            timer_updateBtnUnHide.OnEndTime += Update_BtnUnHide;//TODO Вынести
            timer_updateItemList.OnEndTime += UpdateItemsUI;
            timer_updateProgressBar.OnEndTime += UpdateProgressBar;

            timers.Act(t => {
                t.TimerSetActive(true, true);
            });

            new TaskFactory().StartNew(async () => await UpdateTask());
        }

        async Task UpdateTask(int deltaMilliseconds = 50) {
            while(true) {
                Stopwatch sw = Stopwatch.StartNew();
                //Debug.WriteLine("sw.Start(); ");
                await Task.Delay(deltaMilliseconds);
                sw.Stop();
                //Debug.WriteLine("sw.Stop(); ");
                form.Invoke((Action)(() => UpdateTimers(sw.ElapsedMilliseconds / 1000f)));
            }
        }

        void UpdateTimers(float deltaTime) {
            timers.Act(t => t.UpdateFunc(deltaTime));
        }



        //---------------------------------------------------

        void Update_BtnUnHide() {
            form.linkLabelBtn_UnHideAll.Text = $"очистить список скрытого({form.itemList.items.Count(it => it.isHidden)})";
        }

        void UpdateItemsUI() {
            form.UpdateUI_ItemList();
        }

        private void UpdateProgressBar() {
            int value = (int)(100 * (1f - (timer_updateItemList.currentTime / timer_updateItemList.maxTimeValue)));
            form.pictureBox2.Size = new System.Drawing.Size(value, 15);
        }
    }
}
