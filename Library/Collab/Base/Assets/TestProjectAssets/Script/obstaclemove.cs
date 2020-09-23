using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclemove : MonoBehaviour
{
	public int timer = 6;

	void Start()
    {
        
    }

    void Update()
    {
		//timer--;

		//if (timer == 2)
		//{
		//	transform.Translate (-2*Time.deltaTime,0,0);
		//	timer = 5;

		//}
		//if (timer == 3)
		//{
		//	transform.Translate(2 * Time.deltaTime, 0, 0);
		//	timer =4;
		//}
		

	}

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log(tag);

		if (other.tag=="Sag")
		{
			Debug.Log("test");
			transform.Translate(2 * Time.deltaTime, 0, 0);
		}

		if(other.tag=="Sol")
		{
			transform.Translate(-2 * Time.deltaTime, 0, 0);

		}
	}


}
