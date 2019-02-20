using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlipCar : MonoBehaviour
{
	
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{

	}
	void OnTriggerEnter(Collider other)
	{
	
	
			
			transform.parent.parent.rotation = Quaternion.Euler(transform.rotation.y, transform.rotation.x, 0);


		}
	}
