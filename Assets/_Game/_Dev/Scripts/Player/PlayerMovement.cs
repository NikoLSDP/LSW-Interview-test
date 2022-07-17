using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D _rb;
    Transform _tr;

    private void Awake()
    {
        _tr = transform;
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)) Move(Vector2.up);
        if (Input.GetKey(KeyCode.S)) Move(Vector2.down);
        if (Input.GetKey(KeyCode.A)) Move(Vector2.left);
        if (Input.GetKey(KeyCode.D)) Move(Vector2.right);

        if (_rb.velocity != Vector2.zero && !StateManager.instance.player.isMoving)
        {
            StateManager.instance.player.isMoving = true;
            StateManager.instance.player.StartWalkingAnim(true);
        }

        if (_rb.velocity.x <= 0.2f && _rb.velocity.y <= 0.2f && StateManager.instance.player.isMoving)
        {
            StateManager.instance.player.isMoving = false;
            StateManager.instance.player.StartWalkingAnim(false);
        }
    }

    public void Move(Vector2 _direction)
    {
        _rb.AddForce(_direction * speed);
    }
}
