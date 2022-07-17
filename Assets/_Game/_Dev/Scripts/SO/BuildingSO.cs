using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Building", menuName = "Scriptable Objects/Building")]
public class BuildingSO : ScriptableObject
{
    public GameObject buildingSprite;
    public new string name;
    public string description;
}
