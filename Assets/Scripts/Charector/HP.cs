using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HP : MonoBehaviour
{

    public int hp = 100;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            hp -= 10;
        }
    }
}
