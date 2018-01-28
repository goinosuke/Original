using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class damage : MonoBehaviour
{
    [Header("体力")]
    public float HP = 2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Enemy")) {
			HP -= 1;
			this.gameObject.GetComponent<BoxCollider>().enabled = false;
		}
		if (HP <= 0)
		{
			SceneManager.LoadScene("GameOver");
		}
	}
}
  

