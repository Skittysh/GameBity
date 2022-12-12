using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MovementMage : MonoBehaviour
{
    public Camera sceneCamera;
    public float moveSpeed;
    public Rigidbody2D rb;
    public GameObject bulletPrefab;
    private Vector2 moveDirection;
    private Vector2 mousePosition;
    public Transform fire_point;
    public float fireLong;

    public float fireRate = 1.0f;

    private bool canShoot = true;



    public float bullet_speed;

    void fire()
    {
        if (!canShoot)
            return;


        var mouseDirection = mousePosition - new Vector2(transform.position.x, transform.position.y);
        GameObject projectile = Instantiate(bulletPrefab, transform.position + new Vector3  (moveDirection.x * 
            moveSpeed * Time.deltaTime, moveDirection.y * moveSpeed * Time.deltaTime), Quaternion.identity);
        

        projectile.transform.right = mouseDirection;
        Rigidbody2D r = projectile.GetComponent<Rigidbody2D>();
        r.AddForce(mouseDirection.normalized * bullet_speed, ForceMode2D.Impulse);
        


        canShoot = false;
        Destroy(projectile, fireLong);
        //StartCoroutine(DestroyFireball());
        StartCoroutine(ResetCanShoot());

    }


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
        float moveX = Input.GetAxisRaw("Horizontal2");
        float moveY = Input.GetAxisRaw("Vertical2");
        moveDirection = new Vector2(moveX, moveY).normalized;
        mousePosition = sceneCamera.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            fire();
        }
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
   


    }



   // IEnumerator DestroyFireball()
  //  {
  //
   //     yield return new WaitForSeconds(fireLong);
  //          Destroy(projectile);
  //  }
    IEnumerator ResetCanShoot()
    {
        yield return new WaitForSeconds(fireRate);
        canShoot = true;
    }
}
