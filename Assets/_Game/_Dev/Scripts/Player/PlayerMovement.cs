using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MoveDirections { Up, Down, Left, Right }
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

        if (Input.GetKey(KeyCode.W)) Move(MoveDirections.Up);
        if (Input.GetKey(KeyCode.S)) Move(MoveDirections.Down);
        if (Input.GetKey(KeyCode.A)) Move(MoveDirections.Left);
        if (Input.GetKey(KeyCode.D)) Move(MoveDirections.Right);

        // if (_rb.velocity != Vector2.zero)
        // {
        //     if (StateManager.instance.player.isMoving) return;
        //     StateManager.instance.player.isMoving = true;
        //     StateManager.instance.player.StartWalkingAnim();
        // }
        // else
        // {
        //     if (!StateManager.instance.player.isMoving) return;

        //     StateManager.instance.player.isMoving = false;
        //     StateManager.instance.player.StartWalkingAnim();
        // }
    }

    public void Move(MoveDirections _direction)
    {
        switch (_direction)
        {
            case MoveDirections.Up:
                _rb.AddForce(Vector2.up * speed);
                StateManager.instance.player.MoveAnimation(1);
                break;
            case MoveDirections.Down:
                _rb.AddForce(Vector2.down * speed);
                StateManager.instance.player.MoveAnimation(2);
                break;
            case MoveDirections.Left:
                _rb.AddForce(Vector2.left * speed);
                StateManager.instance.player.MoveAnimation(3);
                break;
            case MoveDirections.Right:
                _rb.AddForce(Vector2.right * speed);
                StateManager.instance.player.MoveAnimation(4);
                break;
            default:
                break;
        }

    }
}
