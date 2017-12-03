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
        /*
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, 0, -25);
        }
        if (Input.GetKeyUp("a"))
        {
            transform.Rotate(0, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 0, 25);
        }
        if (Input.GetKey("d"))
        {
            transform.rotation = new Quaternion(0,0,0,0);
        }
        */
    }
}
