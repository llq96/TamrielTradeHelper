using System.Collections.Generic;
using System.Linq;
using VladB.Utility;

namespace TamrielTradeApp {
    public class ItemList {
        public List<ItemInfo> items = new();
        public void AddItems(List<ItemInfo> newItems) {
            newItems.Act(newItem => {
                ItemInfo existedCopy = items.FirstOrDefault(item => item.IsEqual(newItem));
                if(existedCopy != null) {
                    existedCopy.time = newItem.time;
                    if(existedCopy.timeMinutes > newItem.timeMinutes) {
                        //Debug.WriteLine($"Item Time Update From {existedCopy.time} To {newItem.time}");
                        existedCopy.isHidden = false;
                    }
                    //Debug.WriteLine("Item Was Not Added, Because Already Exist In The List");
                    return;
                }
                items.Add(newItem);
                //Debug.WriteLine("Item Was Added");
            });
        }

        public void SortList() {
            items = items.OrderBy(it => it.timeMinutes).ToList();
        }

        public ItemInfo GetItemWithGUID(string guid) {
            return items.FirstOrDefault(it => it.guid == guid);
        }

        public void SetAllIsHidden(bool isHidden) {
            items.Act(it => it.isHidden = isHidden);
        }
    }
}
