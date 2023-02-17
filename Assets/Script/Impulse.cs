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
        int a = 7;
        rb = GetComponent<Rigidbody2D>();
        acceleraion = a;
        rb.AddForce(direction.normalized*acceleraion);
        direction= rb.velocity;
    }
}
