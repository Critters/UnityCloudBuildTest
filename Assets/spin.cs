using UnityEngine;
using System.Collections;

public class spin : MonoBehaviour {
	void Start () {
	
	}
	
	void Update () {
		transform.Rotate(new Vector3(0.5f, 1.8f, 1f), Time.deltaTime*180f);
	}
}
