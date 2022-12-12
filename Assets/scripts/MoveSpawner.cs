    using System.Collections;
    using System.Collections.Generic;
    using Unity.VisualScripting;
    using UnityEngine;
    using static Unity.Burst.Intrinsics.X86.Avx;

public class MoveSpawner : MonoBehaviour
{
    public GameObject GoalFor;
    public GameObject Spawner;
    private float speed = 10.0f;
    private Vector2 target;
    private Vector2 position;
    private Vector2 tmp;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0.0f, 200.0f));

        StartCoroutine(ExampleCoroutine());

    }
        
    
        IEnumerator ExampleCoroutine()
                {
               yield return new WaitForSeconds(10);
              rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0.0f, -200.0f));
        yield return new WaitForSeconds(10);
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0.0f, 200.0f));
        yield return new WaitForSeconds(10);
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0.0f, -200.0f));
        yield return new WaitForSeconds(10);
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0.0f, 200.0f));
        yield return new WaitForSeconds(10);
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0.0f, -200.0f));
        yield return new WaitForSeconds(10);
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0.0f, 200.0f));
        yield return new WaitForSeconds(10);
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0.0f, -200.0f));
        yield return new WaitForSeconds(10);
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0.0f, 200.0f));
        yield return new WaitForSeconds(10);
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0.0f, -200.0f));
        yield return new WaitForSeconds(10);
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0.0f, 200.0f));
        yield return new WaitForSeconds(10);
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0.0f, -200.0f));
        yield return new WaitForSeconds(10);
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0.0f, 200.0f));
        yield return new WaitForSeconds(10);
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0.0f, -200.0f));
    }

         


        // Update is called once per frame
        void Update()
        {

        
        }
    }
