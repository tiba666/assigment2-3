using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HP : MonoBehaviour
{

    public int hp = 100;
	public string newGameLevel;


	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {

            Destroy(gameObject);
			SceneManager.LoadScene(newGameLevel);
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
