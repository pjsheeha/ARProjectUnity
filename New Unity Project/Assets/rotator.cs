using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour {
	public int countDown = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		countDown += 1;
		transform.eulerAngles = new Vector3 (10, countDown, 10);
	}
}
