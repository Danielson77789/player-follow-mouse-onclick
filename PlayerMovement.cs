using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] 
    private float moveSpeed = 0;
    [SerializeField] 
    private Rigidbody2D rb;

    private Vector2 moveDirection;

    //Called evenly even on frames
    void FixedUpdate()
    {
        Move();
        
    }

    void Move() {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        Vector2 moveDirection = new Vector2(
            mousePosition.x - transform.position.x * moveSpeed,
            mousePosition.y - transform.position.y * moveSpeed
        );

        transform.up = direction;
        if(Input.GetMouseButton(0)){
            rb.AddForce(direction);
        };
    }


}
