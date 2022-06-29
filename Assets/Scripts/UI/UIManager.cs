using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [Header("Inventory System")]
    public BagSlot[] bagSlots;

    private void Start()
    {
        RenderInventory();
    }
    private void Awake()
    {
        //if there is more than one instance, destroy the extra
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            //Set the static instance to this instance
            Instance = this;
        }
    }
    
    public void RenderInventory() // ship inventory to bag slot
    {
        ItemData[] inventoryToSlots = InventoryManager.Instance.bag;
        for (int i = 0; i < bagSlots.Length; i++)
        {
            //Display them
            bagSlots[i].Display(inventoryToSlots[i]);
        }
    }
}
