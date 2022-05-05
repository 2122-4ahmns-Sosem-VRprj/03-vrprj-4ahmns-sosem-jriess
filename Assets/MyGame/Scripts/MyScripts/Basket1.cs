using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket1 : MonoBehaviour
{
    public int eggCount;
    public Door doorOne;
    bool doorOpened;
    void Start()
    {
        eggCount = 0;
        doorOpened = false;
    }

    
    void Update()
    {
        if(eggCount >= 3 && !doorOpened)
        {
            doorOpened = true;
            doorOne.OpenDoor();          
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Egg")
        {
            eggCount += 1;
            Destroy(collision.gameObject);
        }
    }
}
