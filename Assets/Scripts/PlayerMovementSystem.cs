using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementSystem : MonoBehaviour
{
    private float _horizontalMovement;
    private float _verticalMovement;
    public float _speed = 5.0f;
    public float _drag;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentInChildren<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _horizontalMovement = Input.GetAxisRaw("Horizontal");
        _verticalMovement = Input.GetAxisRaw("Vertical");
        Vector3 movementDirection = transform.forward * _verticalMovement + transform.right * _horizontalMovement;
        rb.AddForce(movementDirection * _speed, ForceMode.Force);
        rb.drag = _drag;
    }
}

