using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Equiment")]
public class EquipmentData : ItemData
{
    [SerializeField] public enum ToolType
    {
        Pickaxe, WateringCan, Axe
    }
    [SerializeField] public ToolType toolType;
}
