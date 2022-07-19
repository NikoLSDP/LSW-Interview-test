using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ClothesType { Head, Top, Bottom, Foot }

[System.Serializable]
public class Gargement
{
    public GargementSO gargementSO;
    public ClothesType type;
    public Sprite icon;
    public string name;
    public string description;
}

public class ClothesManager : MonoBehaviour
{
    [Header("CHARACTER CLOTHES//---------------")]
    [SerializeField] Gargement headWear;
    [SerializeField] Gargement TopWear;
    [SerializeField] Gargement BottomWear;
    [SerializeField] Gargement FootWear;
    [Space(20)]

    [Header("CLOTHES POSITIONS//---------------")]
    [SerializeField] PlayerController body;

    public void SetAllClothes()
    {

    }
}
