using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : SingletonMonoBehavior<InventoryManager>
{
    private Dictionary<int, ItemDetails> itemDetailsDictionary;
    [SerializeField] private SO_ItemList itemList = null;
    protected override void Awake()
    {
        base.Awake();
        CreateItemDetailDictionary();
    }
    private void CreateItemDetailDictionary()
    {
        itemDetailsDictionary = new Dictionary<int, ItemDetails>();
        foreach(ItemDetails itemDetails in itemList.itemDetails)
        {
            itemDetailsDictionary.Add(itemDetails.itemCode, itemDetails);
        }
    }
    public ItemDetails GetItemDetails(int ItemCode)
    {
        ItemDetails itemDetails;

        if(itemDetailsDictionary.TryGetValue(ItemCode, out itemDetails))
        {
            return itemDetails;
        }
        else
        {
            return null;
        }
    }
}
