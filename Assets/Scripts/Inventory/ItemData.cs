using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items")]
public class ItemData : ScriptableObject
{
    public string decription;

    //Icon to be displayed in UI
    public Sprite thumbnail;

    //GameObject to be show in scene
    public GameObject gameModel;
}
