using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Playable : MonoBehaviour {
    public float strength;
    Rigidbody body;


	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Z))
        {
            body.AddForce(Vector3.forward * Time.deltaTime * strength);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            body.AddForce(Vector3.left * Time.deltaTime * strength);
        }
        if (Input.GetKey(KeyCode.S))
        {
            body.AddForce(Vector3.back * Time.deltaTime * strength);
        }
        if (Input.GetKey(KeyCode.D))
        {
            body.AddForce(Vector3.right * Time.deltaTime * strength);
        }
    }
}
