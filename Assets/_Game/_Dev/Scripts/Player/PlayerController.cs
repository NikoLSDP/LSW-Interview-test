using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerMovement movement;
    [SerializeField] CharacterAnimations animations;


    public bool isMoving;

    public void StartWalkingAnim(bool _isWalking) => animations.ToggleWalkingAnimation(_isWalking);
    private void OnCollisionEnter(Collision other)
    {

    }
}
