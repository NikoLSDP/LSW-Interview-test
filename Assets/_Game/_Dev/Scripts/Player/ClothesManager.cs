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

    public Dictionary<string, Gargement> ClothesInventory;

    public void SetAllClothes()
    {
        //Usar diccionario para cargar el inventario de ropa
    }

    public void WearNewGargement(Gargement _newGargement)
    {
        switch (_newGargement.type)
        {
            case ClothesType.Head:
                body.Clothes.headWear = _newGargement;
                break;
            case ClothesType.Top:
                body.Clothes.topWear = _newGargement;
                break;
            case ClothesType.Bottom:
                body.Clothes.BottomWear = _newGargement;
                break;
            case ClothesType.Foot:
                body.Clothes.FootWear = _newGargement;
                break;
            default:
                break;
        }
    }
}
