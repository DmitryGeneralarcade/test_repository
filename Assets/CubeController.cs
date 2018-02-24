using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
    public float tumble;
    //Rigidbody rigidbody;
    // Use this for initialization
    void Start () {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
    }
	
	// Update is called once per frame
	void Update () {
        // transform.rotation = Random.rotation*0.1f;

        //transform.eulerAngles = euler;
    }
}
