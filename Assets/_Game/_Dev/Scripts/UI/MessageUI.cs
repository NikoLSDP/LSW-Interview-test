using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MessageUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameTMP;
    [SerializeField] TextMeshProUGUI messageTMP;

    Transform _tr;

    private void Awake()
    {
        _tr = transform;
        _tr.localScale = Vector2.zero;
    }

    public void SetMessageText(string _name, string _message)
    {
        nameTMP.text = _name;
        messageTMP.text = _message;
    }

    public void SpawnMessage()
    {
        LeanTween.cancel(gameObject);
        LeanTween.scale(gameObject, Vector2.zero, 0f);
        LeanTween.scale(gameObject, Vector2.one, 0.3f).setEaseOutBack();
    }

    public void HideMessageUI()
    {
        LeanTween.cancel(gameObject);
        LeanTween.scale(gameObject, Vector2.zero, 0.3f).setEaseOutQuad();
    }

    public void SpeedUpMessage()
    {
        LeanTween.cancel(gameObject);
        _tr.localScale = Vector2.one;
    }
}
