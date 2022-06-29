using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagSlot : MonoBehaviour
{
    ItemData itemToDisplay;

    public Image itemDisplayImage;

    public void Display(ItemData itemToDisplay)
    {
        if (itemToDisplay != null)
        {
            itemDisplayImage.sprite = itemToDisplay.thumbnail;
            this.itemToDisplay = itemToDisplay;
            itemDisplayImage.gameObject.SetActive(true);
        }
        else
        {
            itemDisplayImage.gameObject.SetActive(false);
        }  
    }
    public void DisplaySlotHanding(bool cond)
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(cond);
    }

}