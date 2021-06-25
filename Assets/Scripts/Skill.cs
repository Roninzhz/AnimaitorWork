using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		//print(other.transform.name);
		other.GetComponent<HP>().Damage(20);
	}
}
