using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.name == ("EasyEnemy")) { 
        //SceneManager.LoadScene("DefeatScreen");
    }
        else if (collider.gameObject.tag == ("EnemyBullet"))
        {
            //SceneManager.LoadScene("DefeatScreen");
        }
    }

}
