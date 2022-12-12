using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    Heal_or_dmg debil_hp;
   
    public damage mage;
    public damage knight;
    damage damage_debil;
    public GameObject Bluexp;


    public void Start()
    {
        var heroGameObject = GameObject.Find("PMage");
        mage = heroGameObject.GetComponent<damage>();
        var hero2GameObject = GameObject.Find("PKnight");
        knight = hero2GameObject.GetComponent<damage>();

        debil_hp= heroGameObject.GetComponent<Heal_or_dmg>();
       
        // if (gameObject.name != "PMage" || gameObject.name != "PKnight")
        // {
        //     ziomek = GameObject.Find()
        damage_debil = GetComponent<damage>();
        debil_hp = GetComponent<Heal_or_dmg>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BULLET") &&  gameObject.CompareTag("MONSTER"))
        {
            if (debil_hp.get_current_hp() > 0)
            {
                debil_hp.take_damage(mage.get_damage());
            }
            if (debil_hp.get_current_hp() <= 0)
            {
                Destroy(debil_hp.gameObject);
                Instantiate(Bluexp, transform.position, Quaternion.identity);
            }

        }
        if (collision.gameObject.CompareTag("Slashy")&&gameObject.CompareTag("MONSTER"))
        {
            if (debil_hp.get_current_hp() > 0)
            {
                debil_hp.take_damage(knight.get_damage());
            }
            if (debil_hp.get_current_hp() <= 0)
            {
                Destroy(debil_hp.gameObject);
                Instantiate(Bluexp, transform.position, Quaternion.identity);
            }

        }
      
    }

}