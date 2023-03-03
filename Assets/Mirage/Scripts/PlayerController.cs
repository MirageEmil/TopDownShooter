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

    public GameObject projectilePrefab;
    public GameObject projectileSpawnPoint;

    public float xRight;
    public float xLeft;
    public float yTop;
    public float yBottom;

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, projectileSpawnPoint.transform.position, projectileSpawnPoint.transform.rotation);
        }
    }

    void Move()
    {

    }
}
