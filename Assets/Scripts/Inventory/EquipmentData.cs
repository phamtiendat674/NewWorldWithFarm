using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Equiment")]
public class EquipmentData : ItemData
{
    public enum ToolType
    {
        Pickaxe, WateringCan, Axe
    }
    public ToolType toolType;
}
