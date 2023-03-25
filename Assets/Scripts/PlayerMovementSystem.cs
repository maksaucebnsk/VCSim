using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementSystem : MonoBehaviour
{
    [SerializeField] AudioSource _audiosource;
    private float _horizontalMovement;
    private float _verticalMovement;
    public float _speed;
    public float _drag;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        _audiosource = GetComponent<AudioSource>();
        _audiosource.volume = 0.5f;
        rb = GetComponentInChildren<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _speed = 15f;
            _audiosource.mute = false;
        }
        else
        {
            _speed = 35f;
            _audiosource.mute = true;
        }
        _horizontalMovement = Input.GetAxisRaw("Horizontal");
        _verticalMovement = Input.GetAxisRaw("Vertical");
        Vector3 movementDirection = transform.forward * _verticalMovement + transform.right * _horizontalMovement;
        rb.AddForce(movementDirection * _speed, ForceMode.Force);
        rb.drag = _drag;
    }
}

