using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementKnight : MonoBehaviour
{


    public float moveSpeed;
    public Rigidbody2D rb;

    public GameObject slash;
    public Transform firePoint;

    private Vector2 moveDirection;
    private Vector2 mousePosition;

    private bool canAttack = true;
    public float Speeder = 1;
    public float aschange;

    // Start is called before the first frame update
    void Start()
    {
        firePoint.position = new Vector2(transform.position.x + 0.4f, transform.position.y - 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();

    }

    void FixedUpdate()
    {
        Move();


    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canAttack == true)
            {
                GameObject projectile = Instantiate(slash, firePoint.position, firePoint.rotation);
                projectile.transform.SetParent(transform);
                Destroy(projectile, 0.45f);
                StartCoroutine(Attacker());
            }

        }

        if (moveX < 0)
        {
            transform.localScale = new Vector2(-1, 1);
            slash.transform.localScale = new Vector2(-2.0f, slash.transform.localScale.y);
        }

        else if (moveX > 0)
        {
            transform.localScale = new Vector2(1, 1);
            slash.transform.localScale = new Vector2(2.0f, slash.transform.localScale.y);
        }


        moveDirection = new Vector2(moveX, moveY).normalized;


    }

    IEnumerator Attacker()
    {
        canAttack = false;
        yield return new WaitForSeconds(Speeder);
        canAttack = true;

    }


    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

    }



}
