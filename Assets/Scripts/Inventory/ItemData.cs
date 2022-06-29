using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Item")]
public class ItemData : ScriptableObject
{
    [SerializeField] public string decription;

    //Icon to be displayed in UI
    [SerializeField] public Sprite thumbnail;

    //GameObject to be show in scene
    [SerializeField] public GameObject gameModel;
}
