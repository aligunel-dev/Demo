using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aicontrol : MonoBehaviour
{

    public Transform RespawnPoint;
    public Animator anim;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.forward * Variable.aispeed * Time.deltaTime;
        anim.SetBool("Run", true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "obstacle")
        {
			Variable.aispeed = 0;
            Respawn();
            anim.SetBool("Death", true);
            Variable.aihudspawn = (true);

        }
		if (other.tag == "finish")
		{
			Variable.aispeed = 0;
		
			anim.SetBool("finish", true);

		}
		else
            anim.SetBool("Death", false);
    }
    public void Respawn()
    {
        transform.position = RespawnPoint.transform.position;
		Variable.aispeed = 0.18f;
        anim.SetBool("run", true);
    }
}
