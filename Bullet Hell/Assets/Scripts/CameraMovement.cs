using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {


    public Transform target;
    public float camSpeed;
    float step;
    public bool endLevel01 = false;

    public GameObject GO;
    public GameObject Wall;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        step = camSpeed * Time.deltaTime;

        if (endLevel01) { 
       
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            GO.SetActive(true);
            Destroy(Wall);
        }
}
}
