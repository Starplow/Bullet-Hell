using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashScreen02 : MonoBehaviour {

   
    void Start()
    {
        
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("Level01");

 
       
    }
}

