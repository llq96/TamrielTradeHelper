using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using VladB.Utility;
using System.Drawing;
using System.Diagnostics;

namespace TamrielTradeApp {
    public class ItemInfo {
        public string name;
        public string place;
        public string guild;
        string __time;
        public string time {
            get {
                return __time;
            }
            set {
                __time = value;
                UpdateTimeMinutes();
            }
        }
        public float onePrice;
        public int count;
        public float fullPrice;

        public ItemQuality quality;

        string __imageHtmlName;
        public string imageHtmlName {
            get {
                return __imageHtmlName;
            }
            set {
                __imageHtmlName = value;
                Task task = new Task(() => {
                    //Debug.WriteLine("TASKTASKTASKTASKTASKTASK");
                    image = ItemImages.GetImage(__imageHtmlName);
                    //Debug.WriteLine("ASKTASKTASKTASK");
                });
                task.Start();
                //image = ItemImages.GetImage(__imageHtmlName);
            }
        }
        public Image image;

        string __guid;
        public string guid {
            get {
                if(__guid.IsNullOrEmpty()) {
                    __guid = Extensions.GetRandomGUID();
                }
                return __guid;
            }
        }
        
        public int timeMinutes;
        public override string ToString() => $"{name}, {place}, {guild}, {time}, {onePrice}, {count}, {fullPrice}";

        bool __isHidden;
        public bool isHidden {
            get {
                return __isHidden;
            }
            set {
                __isHidden = value;
                if(__isHidden) {
                    OnAnyItemHidden?.Invoke();
                } else {
                    OnAnyItemUnHidden?.Invoke();
                }
            }
        }

        public static Action OnAnyItemHidden;
        public static Action OnAnyItemUnHidden;

        public bool IsEqual(ItemInfo other) {
            return name == other.name &&
                quality == other.quality &&
                place == other.place &&
                guild == other.guild &&
                onePrice == other.onePrice &&
                count == other.count &&
                fullPrice == other.fullPrice;
        }

        void UpdateTimeMinutes() {
            if(time.Contains("сейчас")) {
                timeMinutes = 0;
            } else {
                var regexMinutes = new Regex(@"^(\d+) мин. назад$").Match(time);
                var regexHours = new Regex(@"^(\d+) ч. назад$").Match(time);
                if(regexMinutes.Success) {
                    int val = int.Parse(regexMinutes.Groups[1].Value);
                    timeMinutes = val;
                } else if(regexHours.Success) {
                    int val = int.Parse(regexHours.Groups[1].Value);
                    timeMinutes = 60 * val;
                } else {
                    Debug.WriteLine("AAAAAAAAAAAAAAAAAAAAAA: " + time);
                }
            }
        }

        public bool IsTrash() {
            if(Form1.instance.checkBox_IsHideOld.Checked) {
                if(timeMinutes >= 120) {
                    return true;
                }
            }
            if(Form1.instance.checkBox_IsHideUserHided.Checked) {
                if(isHidden) {
                    return true;
                }
            }
            return false;
        }

        public static Color[] qualityColors = new Color[] {
            Color.White,
            Color.White,
            Color.FromArgb(255,105,231,117),
            Color.FromArgb(255,40,179,237),
            Color.FromArgb(255,232,108,228),
            Color.FromArgb(255,231,227,105),
        };
    }


}
