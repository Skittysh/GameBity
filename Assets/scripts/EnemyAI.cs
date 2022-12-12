using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyAI : MonoBehaviour
{
    private Transform enemyTransform;
    public Is_alive test;
    public Rigidbody2D hero1;
    public Rigidbody2D hero2;
    public Rigidbody2D debil;
    public Heal_or_dmg knight_hp;
    public Heal_or_dmg mage_hp;
    public damage dmg;

    private void Awake()
    {
        debil = GetComponent<Rigidbody2D>();

        var heroGameObject = GameObject.Find("PMage");
        bool hero_test = heroGameObject.active;
        hero1 = heroGameObject.GetComponent<Rigidbody2D>();
        var hero2GameObject = GameObject.Find("PKnight");
        hero2 = hero2GameObject.GetComponent<Rigidbody2D>();
        bool hero_test_2 = hero2GameObject.active;
        knight_hp = heroGameObject.GetComponent<Heal_or_dmg>();
        mage_hp = hero2GameObject.GetComponent<Heal_or_dmg>();




    }



    public float moveSpeed = 1.0f;

    void Start()
    {

        enemyTransform = GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 playerPosition1 = hero1.transform.position;
        Vector3 playerPosition2 = hero2.transform.position;

        var distV = transform.position - playerPosition1;
        var length1 = Math.Pow(transform.position.x - playerPosition1.x, 2) + Math.Pow(transform.position.y - playerPosition1.y, 2);
        var length2 = Math.Pow(transform.position.x - playerPosition2.x, 2) + Math.Pow(transform.position.y - playerPosition2.y, 2);

        if (!hero1.gameObject.activeSelf)
            length1 = Mathf.Infinity;

        if (!hero2.gameObject.activeSelf)
            length2 = Mathf.Infinity;

        if (!hero1.gameObject.activeSelf && !hero2.gameObject.activeSelf)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (length1 < length2)
        {
            enemyTransform.position = Vector2.MoveTowards(enemyTransform.position, playerPosition1, moveSpeed * Time.deltaTime);
        }
        else
        {
            enemyTransform.position = Vector2.MoveTowards(enemyTransform.position, playerPosition2, moveSpeed * Time.deltaTime);
        }
    }
    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Mage" && gameObject.tag == "MONSTER")
        {
            knight_hp.take_damage(3);
            if (knight_hp.get_current_hp() <= 0)
            {
                hero1.gameObject.SetActive(false);
            }

        }
        if (gameObject.tag == "MONSTER" && coll.gameObject.tag == "Knight")
        {
            mage_hp.take_damage(3);
            if (mage_hp.get_current_hp() <= 0)
            {
                hero2.gameObject.SetActive(false);
            }

        }
    }



}
