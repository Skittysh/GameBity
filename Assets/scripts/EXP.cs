using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXP : MonoBehaviour
{
    private int expAmount_W = 0;
    private int expAmount_M = 0;
    private int maxExp = 10;
    private int lvl = 1;
    public MovementMage owo;
    public MovementKnight attackSpeed;


    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (gameObject.tag == "Knight" && coll.gameObject.tag == "EXP")
        {

            expAmount_W+=1;
            coll.gameObject.SetActive(false);
        }
        ////if (coll.gameObject.tag == "EXP" && gameObject.tag == "Mage")
      //  {
        //    expAmount_M+=1;
        //    coll.gameObject.SetActive(false);

    //    }
    }

    public int get_expAmount()
    {
        return expAmount_W + expAmount_M;
    }

    public int get_maxExp()
    { 
        return maxExp; 
    }

    public int get_lvl() { return lvl;}

    public void set_lvl(int currentXP) {

        if(currentXP >= maxExp)
        {
            lvl++;
            attackSpeed.Speeder = attackSpeed.Speeder - 0.1f;
            maxExp += 5;
            expAmount_W = 0;
            expAmount_M = 0;

        }
    
    }
    
    void Update()
    {
        set_lvl(get_expAmount());
    }
}
