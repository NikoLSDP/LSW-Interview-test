using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] View[] uiViews;
    private void OnEnable()
    {
        StateManager.onGameStateChanged += ChangeUIView;
    }
    private void OnDisable()
    {
        StateManager.onGameStateChanged -= ChangeUIView;
    }

    void ChangeUIView(GameState _newState)
    {
        for (int i = 0; i < uiViews.Length; i++)
        {
            uiViews[i].gameObject.SetActive(uiViews[i].State == _newState);
        }
    }
}
