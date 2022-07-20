using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gargement", menuName = "Scriptable Objects/Gargement")]
public class GargementSO : ScriptableObject
{
    public ClothesType type;

    public Sprite icon;
    public new string name;
    public string description;
}
