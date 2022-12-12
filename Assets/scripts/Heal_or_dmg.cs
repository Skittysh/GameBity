using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal_or_dmg : MonoBehaviour
{
    public int current_hp;
    public int max_hp;
    GameObject ziomek;
    // Start is called before the first frame update
    void Start()
    {
        //current_hp = max_hp;
        
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void take_damage(int damage)
    {
        current_hp = current_hp - damage;

    }
    public void take_heal(int heal)
    {
        if (current_hp + heal < max_hp)
        {
            current_hp = current_hp + heal;
        }
        if (current_hp + heal >= max_hp)
        {
            current_hp = max_hp;
        }
    }
    public int get_current_hp()
    {
        return current_hp;
    }

    public int get_max_hp()
    {
        return max_hp;
    }
    // public void OnTriggerEnter2D(Collider2D collision)
    // {
    // if (collision.gameObject.CompareTag("MONSTER"))
    //     {
    //         Destroy(collision.gameObject);
    //     }
    // }

}