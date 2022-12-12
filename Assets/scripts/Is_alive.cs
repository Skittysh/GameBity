using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Is_alive : MonoBehaviour
{
    private int alive_count;
    public GameObject mage;
    public GameObject knight;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ctr();
    }
    public void ctr()
    {
        if (mage.active && knight.active)
        {
            alive_count = 2;
        }
        if (mage.active == false && knight.active == true)
        {
            alive_count = 1;
        }
        if (mage.active == true && knight.active == false)
        {
            alive_count = 1;
            
        }
        else
        {
            alive_count = 0;
        }

    }
    public int name_dead()
    {
        if(mage.active == false)
        {
            return 1;
        }       
        if(knight.active == false)
        {
            return 2;
        }
            return 3;  
    }
    public int get_ctr()
    {
        return alive_count;
    }
}
