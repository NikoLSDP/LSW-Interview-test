using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Scriptable Objects/Dialogue")]
public class DialogueSecuenceSO : ScriptableObject
{
    public DialogueMessage[] messages;

    public string npcName;

    public Color playerTextColor, otherTextColor;

}
