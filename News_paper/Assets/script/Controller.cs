using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void move(){

		transform.localPosition += new Vector3 (0, 10, 0);
		transform.eulerAngles += new Vector3 (5, 20, 5);
	}
}
