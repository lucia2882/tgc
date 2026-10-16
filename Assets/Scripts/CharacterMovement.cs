using System;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movementDirection;
    [SerializeField] private float velocity;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        movementDirection = transform.TransformDirection(movementDirection);
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = movementDirection * velocity;
    }
}

internal class SerializedFieldAttribute : Attribute
{
}