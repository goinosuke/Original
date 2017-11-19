using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wing_animation_Script : MonoBehaviour {
    private Animator animator;

    // Use this for initialization
    void Start () {

        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("wing1");
        }
	}
}
