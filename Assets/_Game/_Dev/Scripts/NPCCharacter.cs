using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCharacter : MonoBehaviour
{
    [SerializeField] DialogueSecuenceSO dialogueSecuenceSO;
    [SerializeField] bool alwaysTalks;

    bool _alreadySpoken;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Player"))
        {
            if (!alwaysTalks && _alreadySpoken) return;
            Debug.Log("Dialogue started");
            DialogueManager.instance.StartDialogue(dialogueSecuenceSO);
            SetSpokenState();
        }
    }

    void SetSpokenState()
    {
        if (alwaysTalks) return;

        _alreadySpoken = true;
    }
}
