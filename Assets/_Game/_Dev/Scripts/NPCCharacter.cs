using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCharacter : MonoBehaviour
{
    [SerializeField] DialogueSecuenceSO dialogueSecuenceSO;
    [SerializeField] bool alwaysTalks;
    [Space(15)]
    [SerializeField] GameState state;
    bool _alreadySpoken, _startedSpeaking;

    private void Update()
    {
        if (!_startedSpeaking) return;

        if (Input.anyKeyDown)
        {
            _startedSpeaking = DialogueManager.instance.SpawnDialogueMessage();

            if (!_startedSpeaking && state != StateManager.instance.currentState)
            {
                StateManager.instance.ChangeGameState(state);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Player"))
        {
            if (!alwaysTalks && _alreadySpoken) return;

            Debug.Log("Dialogue started");
            _startedSpeaking = true;
            StateManager.instance.player.ToggleTalkingState(true);
            DialogueManager.instance.StartDialogue(dialogueSecuenceSO);
            DialogueManager.instance.SpawnDialogueMessage();
            SetSpokenState();
        }
    }

    void SetSpokenState()
    {
        if (alwaysTalks) return;

        _alreadySpoken = true;
    }
}
