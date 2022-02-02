using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using VladB.Utility;

namespace TamrielTradeApp {
    class HtmlParser {
        List<ItemInfo> allItems = new();

        static string[] htmlQualities = new string[] {
                            "item-quality-normal",
                            "item-quality-fine",
                            "item-quality-superior",
                            "item-quality-epic",
                            "item-quality-legendary"
                        };

        public List<ItemInfo> ParseHTML(string html) {
            HtmlAgilityPack.HtmlDocument doc = new();
            doc.LoadHtml(html);
            HtmlDocumentProcessing(doc);
            return allItems;
        }

        void HtmlDocumentProcessing(HtmlAgilityPack.HtmlDocument doc) {
            Debug.WriteLine("HtmlDocumentProcessing");
            HtmlAgilityPack.HtmlNode table = doc.DocumentNode.SelectSingleNode(".//table[@class='trade-list-table max-width']");
            //Debug.WriteLine(tables != null);
            if(table != null) {
                var tbody = table.SelectSingleNode(".//tbody");
                //Debug.WriteLine("tbody.InnerHtml" + tbody.InnerHtml);
                if(tbody != null) {
                    var items = table.SelectNodes(".//tr[@class='cursor-pointer']");
                    Debug.WriteLine("ITEMS_COUNT=" + items.Count);
                    foreach(var item in items) {
                        var tds = item.SelectNodes(".//td");
                        var itemName = tds[0].SelectSingleNode(".//div").InnerText;

                        var itemImageHtmlPath = tds[0].SelectSingleNode(".//img").Attributes["src"].Value;
                        var itemImageHtmlName = "";
                        var regex_itemImageHtmlPath = new Regex(@"Content/icons\/(.+)\.(\w+)$").Match(itemImageHtmlPath);
                        if(regex_itemImageHtmlPath.Success) {
                            itemImageHtmlName = regex_itemImageHtmlPath.Groups[1].Value;
                            //Debug.WriteLine(itemImageHtmlName);
                        } else {
                            //Debug.WriteLine("FALSE: " + itemImageHtmlPath);
                        }


                        var itemQualityStr = tds[0].SelectSingleNode(".//div").Attributes["class"].Value;
                        var itemQuality = GetQuality(itemQualityStr);

                        var itemPlace = tds[2].SelectNodes(".//div")[0].InnerText;
                        var itemGuild = tds[2].SelectNodes(".//div")[1].InnerText;
                        var itemTime = tds[4].InnerText;

                        var itemOnePriceStr = tds[3].SelectSingleNode(".//span[@data-bind='localizedNumber: UnitPrice']").InnerText;
                        float itemOnePrice = ConvertToFloat(itemOnePriceStr);

                        var itemCountStr = tds[3].SelectSingleNode(".//span[@data-bind='localizedNumber: Amount']").InnerText;
                        int itemCount = (int)ConvertToFloat(itemCountStr);

                        var itemFullPriceStr = tds[3].SelectSingleNode(".//span[@data-bind='localizedNumber: TotalPrice']").InnerText;
                        float itemFullPrice = ConvertToFloat(itemFullPriceStr);

                        if(itemName.IsHaveSomething() && itemPlace.IsHaveSomething()//TODO
                            && itemGuild.IsHaveSomething() && itemTime.IsHaveSomething()
                            && itemOnePrice != 0 && itemCount != 0 && itemFullPrice != 0) {
                            var newItem = new ItemInfo() {
                                name = itemName,
                                imageHtmlName = itemImageHtmlName,
                                quality = itemQuality,
                                place = itemPlace,
                                guild = itemGuild,
                                time = itemTime,
                                onePrice = itemOnePrice,
                                count = itemCount,
                                fullPrice = itemFullPrice,
                            };
                            allItems.Add(newItem);
                        } else {
                            Debug.WriteLine($"Error,Data: {itemName}, {itemPlace}, {itemGuild}, {itemTime}, {itemOnePrice}, {itemCount}, {itemFullPrice}");
                        }
                    }
                } else {
                    Debug.WriteLine("tbody == null");
                }
            } else {
                Debug.WriteLine("table == null");
            }

            float ConvertToFloat(string str) => float.Parse(string.Concat(str.Where(c => char.IsDigit(c) || c == ',').ToList()).Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);

            ItemQuality GetQuality(string htmlQualityClass) {
                return (ItemQuality)(htmlQualities.ToList().IndexOf(htmlQualityClass) + 1);
            }
        }


    }
}
