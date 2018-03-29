using System.Collections;
using System;
using Vuforia;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour {
	private Anchor anchor;
	public string state = "1";
	public List<GameObject> nums = new List<GameObject> ();

	// Use this for initialization
	void Start () {
		for (int i =0; i < 5; i++) {
			GameObject cool = GameObject.FindGameObjectWithTag ("" + i + "");
			print ("A" + cool.name);
			nums.Add (cool);
		}
		for (int i = 0; i < nums.Count; i++) {
			print ("B" + nums[i].name); 
			nums [i].SetActive (false);
		}
		stateChange ("1");
		print (nums);
	}
	
	// Update is called once per frame
	void Update () {
		


	}
	public void stateChange(string buttonName) {
		state = buttonName;
		for (int i = 0; i < nums.Count; i++) {
			if (String.Equals (state, ""+i + "")) {
				print ("A"+state);
				nums [i].SetActive (true);
			}
			if (!String.Equals (state, ""+i + "")) {
				print ("B"+state);
				nums [i].SetActive (false);
			}
		}
	}
}
