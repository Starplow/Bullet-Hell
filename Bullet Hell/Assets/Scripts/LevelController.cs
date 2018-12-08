using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

    public float camSpeed;
    float step;

    public int LevelStatus = 1;
    int camStatus = 1;

    public GameObject Level02Activation;
    public GameObject Level03Activation;
    public GameObject Level04Activation;
    public GameObject Level05Activation;
    public GameObject Level06Activation;
    public GameObject Level07Activation;
    public GameObject Level08Activation;
    public GameObject Level09Activation;

    public GameObject Wall01;
    public GameObject Wall02;
    public GameObject Wall03;
    public GameObject Wall04;
    public GameObject Wall05;
    public GameObject Wall06;
    public GameObject Wall07;
    public GameObject Wall08;
   

    public Transform target01;
    public Transform target02;
    public Transform target03;
    public Transform target04;
    public Transform target05;
    public Transform target06;
    public Transform target07;
    public Transform target08;


    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        step = camSpeed * Time.deltaTime;

        if (LevelStatus == 2) {
                Level02Activation.SetActive(true);
                Destroy(Wall01);
                transform.position = Vector3.MoveTowards(transform.position, target01.position, step);
        }

        if (LevelStatus == 3)
        {
            Level03Activation.SetActive(true);
            Destroy(Wall02);
            transform.position = Vector3.MoveTowards(transform.position, target02.position, step);
        }

        if (LevelStatus == 4)
        {
            Level04Activation.SetActive(true);
            Destroy(Wall03);
            transform.position = Vector3.MoveTowards(transform.position, target03.position, step);
        }


        if (LevelStatus == 5)
        {
            Level05Activation.SetActive(true);
            Destroy(Wall04);
            transform.position = Vector3.MoveTowards(transform.position, target04.position, step);
        }

        if (LevelStatus == 6)
        {
            Level06Activation.SetActive(true);
            Destroy(Wall05);
            transform.position = Vector3.MoveTowards(transform.position, target05.position, step);
        }

        if (LevelStatus == 7)
        {
            Level07Activation.SetActive(true);
            Destroy(Wall06);
            transform.position = Vector3.MoveTowards(transform.position, target06.position, step);
        }

        if (LevelStatus == 8)
        {
            Level08Activation.SetActive(true);
            Destroy(Wall07);
            transform.position = Vector3.MoveTowards(transform.position, target07.position, step);
        }

        if (LevelStatus == 9)
        {
            Level09Activation.SetActive(true);
            Destroy(Wall08);
            transform.position = Vector3.MoveTowards(transform.position, target08.position, step);
        }
















    }
}

