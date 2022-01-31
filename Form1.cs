using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DotNetBrowser.Navigation.Events;
using VladB.Utility;

namespace TamrielTradeApp {
    public partial class Form1 : Form {
        public static Form1 instance { get; private set; }

        public BrowserHelper browserHelper = new();
        public ItemList itemList = new();
        public SearchList searchList = new();
        public System.Windows.Forms.ToolTip urlToolTip = new();
        public Updater updater = new();
        public Form1() {
            instance = this;

            browserHelper.Init();
            InitializeComponent();

            splitContainer1.Panel2.Controls.Add(browserHelper.browserView);
            browserHelper.Init2();

            FormClosed += Form1_FormClosed;
            browserHelper.browser.Navigation.FrameLoadFinished += ParseHTML;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;

            NextSearch();

            updater.Init();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            // Ignore clicks that are not on button cells. 
            if(e.ColumnIndex != dataGridView1.Columns["ButtonHide"].Index) {
                return;
            }
            string guid = dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.Columns["GUID"].Index].Value.ToString();
            //Debug.WriteLine($"HIDE! {guid}");
            var item = itemList.GetItemWithGUID(guid);
            item.isHidden = !item.isHidden;
            //(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as DataGridViewButtonCell).value;
            UpdateUI_ItemList();
        }

        public void NextSearch() {
            searchList.NextSearchQuery();

            LinkGenerator.FullInfo info = searchList.currentSearch.infoForLink;
            label_loadingNowInfo.Text = 
                "Поиск :" + "\n"
                + $"{info.baseInfo.namePattern}" + "\n"
                + $"Качество: {info.baseInfo.quality}" + "\n"
                + (info.priceInfo.isActiveRestrictions ? $"Цена от {info.priceInfo.priceMin} до {info.priceInfo.priceMax}" : "Цена любая") + "\n"
                + (info.amountInfo.isActiveRestrictions ? $"Количество от {info.amountInfo.amountMin} до {info.amountInfo.amountMax}" : "Количество любое") + "\n"
                + (info.levelInfo.isActiveRestrictions ? $"Уровень({(info.levelInfo.IsChampionPointsType ? "ЧП" : "Обычный")}) от {info.levelInfo.levelMin} до {info.levelInfo.levelMax}" : "Уровень любой");
            urlToolTip.SetToolTip(linkLabelButton_copyURL, searchList.currentSearch.GetURL());

            browserHelper.browser.Navigation.LoadUrl(searchList.currentSearch.GetURL());
        }

        void ParseHTML(object sender, FrameLoadFinishedEventArgs e) {
            Debug.WriteLine($"Loaded");
            Thread.Sleep(3200);
            //ParseHTML();
            Invoke((Action)(() => ParseHTML()));

            browserHelper.browser.Navigation.Stop();
            Thread.Sleep(1 * 1000);

            Invoke((Action)(() => NextSearch()));
        }

        private void ParseHTML() {
            //if(browserHelper.browser.MainFrame != null) {
            List<ItemInfo> list = new HtmlParser().ParseHTML(browserHelper?.browser?.MainFrame?.Html);
            itemList.AddItems(list);
            //UpdateUI_ItemList();
            //}
        }

        public void UpdateUI_ItemList(bool isUpdateList = true) {
            if(isUpdateList) {
                //itemList.UpdateAll_IsTrash();
                itemList.SortList();
            }

            dataGridView1.Rows.Clear();

            itemList.items.Where(it => !it.IsTrash()).Act(item => {

                dataGridView1.Rows.Add(
                    item.image?.Clone(),
                    item.name,
                    $"{item.place}\n{item.guild}",
                    $"{String.Format("{0,12:N0}", item.onePrice).Replace(',', ' ')}",
                    $"{item.count}",
                    $"{String.Format("{0,12:N0}", item.fullPrice).Replace(',', ' ')}",
                    $"{item.time}",
                    item.isHidden ? "Показывать" : "Скрывать",
                    $"{item.guid}"
                );

                dataGridView1.Rows[^1].Cells[0].Style.BackColor = ItemInfo.qualityColors[(int)item.quality];
                dataGridView1.Rows[^1].Cells[1].Style.BackColor = ItemInfo.qualityColors[(int)item.quality];

                if(item.timeMinutes <= 15) {
                    dataGridView1.Rows[^1].Cells[6].Style.BackColor = Color.FromArgb(255, 100, 210, 100);
                } else if(item.timeMinutes <= 30) {
                    dataGridView1.Rows[^1].Cells[6].Style.BackColor = Color.FromArgb(255, 215, 225, 120);
                }

            });

            updater.timer_updateItemList.TimerSetActive(updater.timer_updateItemList.isTimerActive, true);

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            browserHelper.browser.Navigation.FrameLoadFinished -= ParseHTML;
            browserHelper.browser?.Dispose();
            browserHelper.engine?.Dispose();
        }


        private void linkLabelBtn_UnHideAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if(itemList.items.Count(it => it.isHidden) != 0) {
                itemList.SetAllIsHidden(false);
                UpdateUI_ItemList();
            }
        }

        private void linkLabelButton_copyURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Clipboard.SetText(searchList.currentSearch.GetURL());
        }

        private void BtnUpdateItemsList_Click(object sender, EventArgs e) {
            UpdateUI_ItemList();
        }

        private void SettingsToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e) {
            groupBox1.Visible = !groupBox1.Visible;
            menuStrip1.Items[0].Text = groupBox1.Visible ? "Настройки(Скрыть)" : "Настройки(Показать)";
        }
    }
}
