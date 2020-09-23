using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class CharacterController : MonoBehaviour
{
    
	public Transform RespawnPoint;
	public Animator PlayerAnim;
	void Start()
    {
		//PlayerAnim.GetComponent<Animator>();
	}

    void Update()
    {
		if (Input.GetKey(KeyCode.Mouse0))
		{
			PlayerAnim.SetBool("Run", true);
			transform.position += Vector3.forward * Variable.chspeed * Time.deltaTime;
		}
		else
			PlayerAnim.SetBool("Run", false);
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag== "obstacle")
        {
			Variable.chspeed  = 0;
			Variable.spawn=true;
			Respawn();
		}
		
	}
	public void Respawn()
	{
		transform.position = RespawnPoint.transform.position;
		Variable.chspeed = 0.2f;

	}
}
