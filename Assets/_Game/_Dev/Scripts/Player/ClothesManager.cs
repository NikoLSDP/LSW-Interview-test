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
    public int price;
    public string description;
    public bool isOn;

    public void SetAllInfo()
    {
        if (gargementSO == null) return;

        icon = gargementSO.icon;
        name = gargementSO.name;
        price = gargementSO.price;
        description = gargementSO.description;
    }
}

public class ClothesManager : MonoBehaviour
{
    public static ClothesManager instance = null;

    [Header("CHARACTER CLOTHES//---------------")]
    [SerializeField] Gargement headWear;
    [SerializeField] Gargement TopWear;
    [SerializeField] Gargement BottomWear;
    [SerializeField] Gargement FootWear;
    [Space(20)]

    [Header("CLOTHES POSITIONS//---------------")]
    [SerializeField] PlayerController body;

    public Dictionary<string, Gargement> ClothesInventory;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void SetAllClothes()
    {
        //funcion para vestir al player con la ropa que tiene guardada
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
        ClothesInventory.Add(_newGargement.name, _newGargement);
    }

}
