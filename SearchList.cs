using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TamrielTradeApp.LinkGenerator;

namespace TamrielTradeApp {
    public class SearchList {
        List<SearchInfo> searchQueries = new List<SearchInfo>();
        public SearchInfo currentSearch => searchQueries[currentSearchIndex];
        int currentSearchIndex = -1;

        public SearchList() {
            //searchQueries.Add(new SearchInfo(
            //        new BaseInfo("р", ItemQuality.Any),
            //        new LevelInfo(true, LevelInfo.LevelType.ChampionPoints, 150, 150),
            //        new AmountInfo(true, 1, 10),
            //        new PriceInfo(true, 200, 500)
            //));
            searchQueries.Add(new SearchInfo(
                new BaseInfo("Карта сокровищ Мертвых Земель", ItemQuality.Any),
                new LevelInfo(),
                new AmountInfo(),
                new PriceInfo(true, 0, 80000)
            ));
            searchQueries.Add(new SearchInfo(
                new BaseInfo("Кута", ItemQuality.Q4_Legendary),
                new LevelInfo(),
                new AmountInfo(true , 1,2),
                new PriceInfo(true, 0, 1400)
            ));
            //searchQueries.Add(new SearchInfo(
            //    new BaseInfo("Мотив 16", ItemQuality.Any),
            //    new LevelInfo(),
            //    new AmountInfo(),
            //    new PriceInfo(true, 0, 3000)
            //));
            //searchQueries.Add(new SearchInfo(
            //    new BaseInfo("Мотив 17", ItemQuality.Any),
            //    new LevelInfo(),
            //    new AmountInfo(),
            //    new PriceInfo(true, 0, 3000)
            //));
            //searchQueries.Add(new SearchInfo(
            //    new BaseInfo("Мотив 18", ItemQuality.Any),
            //    new LevelInfo(),
            //    new AmountInfo(),
            //    new PriceInfo(true, 0, 3000)
            //));
            //searchQueries.Add(new SearchInfo(
            //    new BaseInfo("Мотив 19", ItemQuality.Any),
            //    new LevelInfo(),
            //    new AmountInfo(),
            //    new PriceInfo(true, 0, 3000)
            //));
            //searchQueries.Add(new SearchInfo(
            //    new BaseInfo("Мотив 20", ItemQuality.Any),
            //    new LevelInfo(),
            //    new AmountInfo(),
            //    new PriceInfo(true, 0, 3000)
            //));
            searchQueries.Add(new SearchInfo(
                new BaseInfo("Обычная руна", ItemQuality.Any),
                new LevelInfo(),
                new AmountInfo(true , 7),
                new PriceInfo(true, 0, 150)
            ));

            searchQueries.Add(new SearchInfo(
                new BaseInfo("Дреугский воск", ItemQuality.Any),
                new LevelInfo(),
                new AmountInfo(),
                new PriceInfo(true, 0, 13000)
            ));

            searchQueries.Add(new SearchInfo(
                new BaseInfo("Изысканная подкладка", ItemQuality.Any),
                new LevelInfo(),
                new AmountInfo(true, 12),
                new PriceInfo(true, 0, 90)
            ));

            searchQueries.Add(new SearchInfo(
                new BaseInfo("Луб", ItemQuality.Any),
                new LevelInfo(),
                new AmountInfo(true, 20),
                new PriceInfo(true, 0, 25)
            ));

            searchQueries.Add(new SearchInfo(
                new BaseInfo("Необработанный шелк предков", ItemQuality.Any),
                new LevelInfo(),
                new AmountInfo(true, 13),
                new PriceInfo(true, 0, 70)
            ));

            searchQueries.Add(new SearchInfo(
                new BaseInfo("Смола", ItemQuality.Q1_Fine),
                new LevelInfo(),
                new AmountInfo(true, 10),
                new PriceInfo(true, 0, 100)
            ));

            searchQueries.Add(new SearchInfo(
                new BaseInfo("Ядровая древесина", ItemQuality.Any),
                new LevelInfo(),
                new AmountInfo(true, 2),
                new PriceInfo(true, 0, 900)
            ));

            searchQueries.Add(new SearchInfo(
                new BaseInfo("Платиновая пыль", ItemQuality.Any),
                new LevelInfo(),
                new AmountInfo(true, 7),
                new PriceInfo(true, 0, 160)
            ));

            searchQueries.Add(new SearchInfo(
                new BaseInfo("Гранулы хрома", ItemQuality.Any),
                new LevelInfo(),
                new AmountInfo(),
                new PriceInfo(true, 0, 20000)
            ));

            searchQueries.Add(new SearchInfo(
                new BaseInfo("Декоративный воск", ItemQuality.Any),
                new LevelInfo(),
                new AmountInfo(true, 4),
                new PriceInfo(true, 0, 300)
            ));

        }

        public SearchInfo NextSearchQuery() {
            currentSearchIndex = currentSearchIndex >= searchQueries.Count - 1 ? 0 : currentSearchIndex + 1;
            return currentSearch;
        }

        public class SearchInfo {
            public FullInfo infoForLink { get; private set; }
            string url;

            public SearchInfo(FullInfo infoForLink) {
                Init(infoForLink);
            }

            public SearchInfo(BaseInfo baseInfo, LevelInfo levelInfo, AmountInfo amountInfo, PriceInfo priceInfo) {
                Init(new FullInfo(baseInfo, levelInfo, amountInfo, priceInfo));
            }

            void Init(FullInfo infoForLink) {
                this.infoForLink = infoForLink;
                RegenerateURL();
            }

            public string GetURL(bool isNeedReGenerate = false) {
                if(isNeedReGenerate) {
                    RegenerateURL();
                }
                return url;
            }

            void RegenerateURL() {
                url = LinkGenerator.GetURL(infoForLink);
            }
        }
    }
}
