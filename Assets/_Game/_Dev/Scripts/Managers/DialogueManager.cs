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

        _currentDialogue = new Dialogue();
    }
    public void StartDialogue(DialogueSecuenceSO _newSequence)
    {
        _messageIndex = 0;
        _currentDialogue.sequence = _newSequence;
    }

    public bool SpawnDialogueMessage()
    {
        string _playerName = StateManager.instance.player.PlayerName;
        string _messageText = _currentDialogue.sequence.messages[_messageIndex].messageTxt;
        string _nameText = _currentDialogue.sequence.messages[_messageIndex].isPlayer ? _playerName : _currentDialogue.sequence.npcName;

        messageUI.SetMessageText(_nameText, _messageText);
        messageUI.SpawnMessage();
        if (_messageIndex + 1 < _currentDialogue.sequence.messages.Length)
        {
            _messageIndex++;
            return true;
        }
        else
        {
            HideLastMessage();
            return false;
        }
    }

    public void HideLastMessage()
    {
        Debug.Log("Dialogue Ended");
        messageUI.HideMessageUI();
        _messageIndex = 0;
        StateManager.instance.player.ToggleTalkingState(false);
    }
}
