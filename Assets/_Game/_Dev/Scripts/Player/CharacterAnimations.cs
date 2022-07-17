using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    [SerializeField] Animator anim;

    public void ToggleWalkingAnimation(bool _isWalking)
    {
        anim.SetBool("isWalking", _isWalking);
    }
}
