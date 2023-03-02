using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    
    [SerializeField] float health, maxHealth = 3f;
    [SerializeField] float moveSpeed = 5f;
    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;

    //Declare a variable for the spriterenderer
    public SpriteRenderer spriteRenderer;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        //GEt the spriterenderer component
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        health = maxHealth;
        target = GameObject.Find("Player").transform;
    }
    private void Update()
    {
        
        if(target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            moveDirection = direction;

            //If the target is on the left of the enemy, set flipX to true
            if(target.transform.position.x < transform.position.x)
            {
                spriteRenderer.flipX= true;
            }else
            {
                spriteRenderer.flipX = false;
            }
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
        
            Destroy(gameObject);
        }
        
    }
}
