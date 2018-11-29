using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

   
    void Start()
    {
        
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);



    }
}

