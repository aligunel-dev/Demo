using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclemove : MonoBehaviour
{

	void Start()
    {
        
    }

    void Update()
    {
		
		for(float i=0; i>5; i += Time.deltaTime)
		{
			transform.Translate(-2 * Time.deltaTime, 0, 0);
			for (float j = 0; j > 5; j += Time.deltaTime)
			{
				transform.Translate(2 * Time.deltaTime, 0, 0);
			}
		}
	}


}
