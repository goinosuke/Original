using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {
    float a = 5;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 0);
        }
 
		if (Input.GetKey("right")){
			transform.position += new Vector3(5*Time.deltaTime, 0, 0);
        }

		if (Input.GetKey("left")){
			transform.position += new Vector3(-5*Time.deltaTime, 0, 0);
		}
	
		if (Input.GetKeyDown("right"))
		{
			transform.Rotate(0, 0, -25);
		}
		if (Input.GetKeyDown("left"))
		{
			transform.Rotate(0, 0, 25);
		} 
		if (Input.GetKeyUp("right"))
		{
			transform.Rotate(0, 0, 25);
		}
		if (Input.GetKeyUp ("left")) {
			transform.Rotate (0, 0, -25);
		}
}
}
