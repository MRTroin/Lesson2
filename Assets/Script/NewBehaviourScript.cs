using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector2 firstPosition;
    public Vector2 secondPosition;
    public CapsuleCollider2D Hero;
    public float Speed = 0.5f;
    private float progress;
    void Start()
    {
        Hero= GetComponent<CapsuleCollider2D>();
        progress= 0;
        firstPosition= Vector2.zero;
    }
    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, secondPosition, progress);
        progress += Speed;
    }
}
