using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Vector3 targetPosition;
    public Rigidbody2D rb;
    private Vector2 newPosition;

    void Start () 
    {
        targetPosition = transform.position;
    }
     
    void Update () 
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = transform.position.z;
        }
        newPosition = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        rb.MovePosition(newPosition);
    }   
}
