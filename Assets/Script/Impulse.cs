using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    public Vector2 direction;
    public float acceleraion;
    public Rigidbody2D rb;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        rb.AddForce(direction.normalized*acceleraion);
    }
}
