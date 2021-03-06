using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { Game, Shop, Inventory }

public class StateManager : MonoBehaviour
{
    public static StateManager instance = null;
    public GameState currentState;

    public UIManager uIManager;
    public PlayerController player;
    public CameraController cameraController;

    #region EVENTS
    public delegate void OnGameStateChanged(GameState _state);
    public static OnGameStateChanged onGameStateChanged;

    #endregion

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        ChangeGameState(currentState);
    }

    public void ChangeGameState(GameState _newState)
    {
        currentState = _newState;
        onGameStateChanged?.Invoke(_newState);
    }


}
