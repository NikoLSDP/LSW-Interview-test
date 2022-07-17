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
        if (Input.GetKey(KeyCode.W)) _rb.AddForce(Vector2.up * speed);
        if (Input.GetKey(KeyCode.S)) _rb.AddForce(Vector2.down * speed);
        if (Input.GetKey(KeyCode.A)) _rb.AddForce(Vector2.left * speed);
        if (Input.GetKey(KeyCode.D)) _rb.AddForce(Vector2.right * speed);
    }
}
