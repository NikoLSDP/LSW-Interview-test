using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
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

    public void ToggleTalkingState(bool _isTalking) => movement.isTalking = _isTalking;
}
