using System;
using System.Collections.Generic;
using System.Linq;

namespace TamrielTradeApp {
    public static class LinkGenerator {
        static readonly string startURL = "https://eu.tamrieltradecentre.com/pc/Trade/SearchResult?SearchType=Sell";
        static readonly string linkPart_langRU = "&lang=ru-RU";

        //static readonly Dictionary<string, string> traitsDict = new() {
        //    { "Любая особенность", "" },
        //    { "Бодрость", "12" },
        //    { "Воодушевление", "7" },
        //    { "Гармония", "22" },
        //    { "Жажда крови", "21" },
        //    { "Защита", "23" },
        //    { "Крепкое здоровье", "18" },
        //    { "Магический потенциал", "17" },
        //    { "Мастерство", "15" },
        //    { "Насыщенность", "3" },
        //    { "Непробиваемость", "9" },
        //    { "Неутомимость", "19" },
        //    { "Оберег", "4" },
        //    { "Острота", "6" },
        //    { "Помощь богов", "13" },
        //    { "Прочность", "10" },
        //    { "Развитие", "5" },
        //    { "Сила нирна", "14" },
        //    { "Сила стихий", "1" },
        //    { "Спасение", "0" },
        //    { "Стойкость", "8" },
        //    { "Точность", "2" },
        //    { "Триединство", "25" },
        //    { "Удобство", "11" },
        //    { "Ускорение", "24" },
        //    { "Ценность", "16" },
        //    { "Aggressive", "26" },
        //    { "Augmented", "27" },
        //    { "Bolstered", "28" },
        //    { "Focused", "29" },
        //    { "Prolific", "30" },
        //    { "Quickened", "31" },
        //    { "Shattering", "32" },
        //    { "Soothing", "33" },
        //    { "Special", "20" },
        //    { "Vigorous", "34" }
        //};

        public static string GetURL(FullInfo info) => GetURL(info.baseInfo, info.levelInfo, info.amountInfo, info.priceInfo);

        public static string GetURL(BaseInfo baseInfo, LevelInfo levelInfo, AmountInfo amountInfo, PriceInfo priceInfo) {
            string linkPart_ItemNamePattern = "", linkPart_ItemQualityID = "";
            string linkPart_LevelMin = "", linkPart_LevelMax = "", linkPart_IsChampionPoint = "";
            string linkPart_AmountMin = "", linkPart_AmountMax = "";
            string linkPart_PriceMin = "", linkPart_PriceMax = "";

            linkPart_ItemNamePattern = $"&ItemNamePattern={baseInfo.namePattern}";
            linkPart_ItemQualityID = (baseInfo.quality == ItemQuality.Any) ? "" : $"&ItemQualityID={(int)baseInfo.quality}";

            if(levelInfo.isActiveRestrictions) {
                linkPart_IsChampionPoint = $"&IsChampionPoint={(levelInfo.IsChampionPointsType ? "true" : "false")}";
                linkPart_LevelMin = $"&LevelMin={levelInfo.levelMin}";
                linkPart_LevelMax = $"&LevelMax={levelInfo.levelMax}";
            }

            if(amountInfo.isActiveRestrictions) {
                linkPart_AmountMin = $"&AmountMin={amountInfo.amountMin}";
                linkPart_AmountMax = $"&AmountMax={amountInfo.amountMax}";
            }

            if(priceInfo.isActiveRestrictions) {
                linkPart_PriceMin = $"&PriceMin={priceInfo.priceMin}";
                linkPart_PriceMax = $"&PriceMax={priceInfo.priceMax}";
            }

            string result = startURL + linkPart_ItemNamePattern + linkPart_ItemQualityID +
                linkPart_IsChampionPoint + linkPart_LevelMin + linkPart_LevelMax +
                linkPart_AmountMin + linkPart_AmountMax +
                linkPart_PriceMin + linkPart_PriceMax + linkPart_langRU;
            return result;
        }


        public class FullInfo {
            public BaseInfo baseInfo;
            public LevelInfo levelInfo;
            public AmountInfo amountInfo;
            public PriceInfo priceInfo;

            public FullInfo(BaseInfo baseInfo, LevelInfo levelInfo, AmountInfo amountInfo, PriceInfo priceInfo) {
                this.baseInfo = baseInfo;
                this.levelInfo = levelInfo;
                this.amountInfo = amountInfo;
                this.priceInfo = priceInfo;
            }
        }


        public class BaseInfo {
            public string namePattern;
            public ItemQuality quality;

            public BaseInfo(string namePattern = "", ItemQuality quality = ItemQuality.Any) {
                this.namePattern = namePattern;
                this.quality = quality;
            }
        }


        public class LevelInfo {
            public bool isActiveRestrictions;
            public LevelType type;
            public int levelMin;
            public int levelMax;

            public LevelInfo(bool isActiveRestrictions = false, LevelType type = LevelType.ChampionPoints, int minLevel = 160, int maxLevel = 160) {
                this.isActiveRestrictions = isActiveRestrictions;
                this.type = type;
                this.levelMin = minLevel;
                this.levelMax = maxLevel;
            }

            public enum LevelType {
                Level,
                ChampionPoints
            }

            public bool IsChampionPointsType => type == LevelType.ChampionPoints;
        }


        public class AmountInfo {
            public bool isActiveRestrictions;
            public int amountMin;
            public int amountMax;

            public AmountInfo(bool isActiveRestrictions = false, int amountMin = 1, int amountMax = 9999) {
                this.isActiveRestrictions = isActiveRestrictions;
                this.amountMin = amountMin;
                this.amountMax = amountMax;
            }
        }


        public class PriceInfo {
            public bool isActiveRestrictions;
            public int priceMin;
            public int priceMax;

            public PriceInfo(bool isActiveRestrictions = false, int priceMin = 0, int priceMax = int.MaxValue) {
                this.isActiveRestrictions = isActiveRestrictions;
                this.priceMin = priceMin;
                this.priceMax = priceMax;
            }
        }
    }


    public enum ItemQuality {
        /// <summary> Любое </summary>
        Any = -1,
        /// <summary> Обычное(серый) </summary>
        Q0_Normal = 0,
        /// <summary> Улучшенное(зелёный) </summary>
        Q1_Fine = 1,
        /// <summary> Превосходное(синий) </summary>
        Q2_Superior = 2,
        /// <summary> Эпическое(фиолетовый) </summary>
        Q3_Epic = 3,
        /// <summary> Легендарное(золотой) </summary>
        Q4_Legendary = 4,
    }
}
