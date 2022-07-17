using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;

    public bool isTalking;
    Rigidbody2D _rb;
    Transform _tr;

    private void Awake()
    {
        _tr = transform;
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (isTalking) return;

        if (Input.GetKey(KeyCode.W)) Move(Vector2.up);
        if (Input.GetKey(KeyCode.S)) Move(Vector2.down);
        if (Input.GetKey(KeyCode.A)) Move(Vector2.left);
        if (Input.GetKey(KeyCode.D)) Move(Vector2.right);

        if (_rb.velocity != Vector2.zero)
        {
            if (StateManager.instance.player.isMoving) return;
            StateManager.instance.player.isMoving = true;
            StateManager.instance.player.StartWalkingAnim();
        }
        else
        {
            if (!StateManager.instance.player.isMoving) return;

            StateManager.instance.player.isMoving = false;
            StateManager.instance.player.StartWalkingAnim();
        }
    }

    public void Move(Vector2 _direction)
    {
        _rb.AddForce(_direction * speed);
    }
}
