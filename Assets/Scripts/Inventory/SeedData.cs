using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Seeds")]
public class SeedData : ItemData
{
    public Sprite seed;   
    [Header("Grow")]
    public GameObject phase1;
    public GameObject phase2;
    public GameObject phase3;
    [Header("Other Information")]
    public int hoursToGrow;
    public int earnFromIt;
}
