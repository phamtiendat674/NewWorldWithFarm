using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Plants")]
public class PlantData : ItemData
{
    [SerializeField] public Sprite seed;   
    [Header("Grow")]
    [SerializeField] public GameObject phase1;
    [SerializeField] public GameObject phase2;
    [SerializeField] public GameObject phase3;
    [Header("Other Information")]
    [SerializeField] public int hoursToGrow;
    [SerializeField] public int earnFromIt;
}
