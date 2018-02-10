using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class damage : MonoBehaviour
{
	GameObject rightwing2;
	GameObject leftwing2;
    [Header("体力")]
    public float HP = 2;
    // Use this for initialization
    void Start()
    {
		rightwing2 = GameObject.FindGameObjectWithTag ("rightwing2");
		leftwing2 = GameObject.FindGameObjectWithTag ("leftwing2");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Enemy")) {
			HP -= 1;
			rightwing2.SetActive (false);
			leftwing2.SetActive (false);
			if (HP <= 0) {
				SceneManager.LoadScene ("GameOver");
			}
		}
	 if (other.gameObject.CompareTag ("recovery")) {
			rightwing2.SetActive (true);
			leftwing2.SetActive (true);
			
	}
}
  
}
