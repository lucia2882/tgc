using System;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 movementDirection;
    [SerializedField] private float horizontalMovement;
    [SerializedField] private float verticalMovement;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(movementDirection, ForceMode2D.Impulse);  
        movementDirection = new Vector3(0, 100, 0);
    }
}

internal class SerializedFieldAttribute : Attribute
{
}