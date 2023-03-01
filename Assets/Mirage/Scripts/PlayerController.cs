using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float horizontalInput;
    public float verticalInput;

    public Rigidbody2D rd;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector2.up * moveSpeed * verticalInput * Time.deltaTime);
        transform.Translate(Vector2.right * moveSpeed * horizontalInput * Time.deltaTime);
    }
}
