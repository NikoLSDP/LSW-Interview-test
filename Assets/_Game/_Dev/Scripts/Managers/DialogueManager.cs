using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueMessage
{
    public string messageTxt;
    public bool isPlayer;
}

public class Dialogue
{
    public DialogueSecuenceSO sequence;
}

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance = null;
    [SerializeField] MessageUI messageUI;
    Dialogue _currentDialogue;
    int _messageIndex;


    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }
    public void StartDialogue(DialogueSecuenceSO _newSequence)
    {
        _messageIndex = 0;
        _currentDialogue.sequence = _newSequence;
    }

    public void SpawnDialogueMessage()
    {
        string _messageText = _currentDialogue.sequence.messages[_messageIndex].messageTxt;
        string _nameText = _currentDialogue.sequence.messages[_messageIndex].isPlayer ? "Player" : _currentDialogue.sequence.npcName;

        messageUI.SetMessageText(_nameText, _messageText);
        messageUI.SpawnMessage();
        _messageIndex++;
    }
}
