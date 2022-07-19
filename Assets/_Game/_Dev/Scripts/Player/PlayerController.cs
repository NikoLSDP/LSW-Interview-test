using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterClothes
{
    public Gargement headWear, topWear, BottomWear, FootWear;
}

public class PlayerController : MonoBehaviour
{
    [SerializeField] CharacterClothes clothes;
    [SerializeField] PlayerMovement movement;
    [SerializeField] CharacterAnimations animations;
    [SerializeField] string playerName;

    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    public bool isMoving;

    public void StartWalkingAnim() => animations.ToggleWalkingAnimation(isMoving);

    public void MoveAnimation(int _dir) => animations.WalkingAnimation(_dir);

    public void ToggleTalkingState(bool _isTalking) => movement.isTalking = _isTalking;
}
