using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class UIInventorySlot : MonoBehaviour
{
    public Image InventorySlotHighLight;
    public Image InventorySlotImage;
    public TextMeshProUGUI textMeshProUGUI;

    [HideInInspector] public ItemDetails itemDetails;
    [HideInInspector] public int itemQuantity;
}
