using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Rotation[] objs = GameObject.FindObjectsOfType<Rotation>();
        foreach(Rotation obj in objs)
        {
            obj.isSpinning = true;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
