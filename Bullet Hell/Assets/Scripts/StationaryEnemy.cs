using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class StationaryEnemy : MonoBehaviour {



    public BulletController stationaryBullet;
    public Transform fireFront;
    public float timeBetweenShots;
    private float shotCounter;
    public float bulletSpeed;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 shotCounter -= Time.deltaTime;
        if (shotCounter <= 0)
        {


            shotCounter = timeBetweenShots;
            BulletController destroyableBullet = Instantiate(stationaryBullet, fireFront.position, fireFront.rotation) as BulletController;
            destroyableBullet.speed = bulletSpeed;






            //Quaternion rotation = Quaternion.Euler(0, 90, 0);


            shotCounter = timeBetweenShots;
            BulletController destroyableBullet2 = Instantiate(stationaryBullet, fireFront.position, fireFront.rotation) as BulletController;
            destroyableBullet2.transform.Rotate(0, 90, 0);
            destroyableBullet2.speed = bulletSpeed;






            shotCounter = timeBetweenShots;
            BulletController destroyableBullet3 = Instantiate(stationaryBullet, fireFront.position, fireFront.rotation) as BulletController;
            destroyableBullet3.transform.Rotate(0, 180, 0);
            destroyableBullet3.speed = bulletSpeed;






            shotCounter = timeBetweenShots;
            BulletController destroyableBullet4 = Instantiate(stationaryBullet, fireFront.position, fireFront.rotation) as BulletController;
            destroyableBullet4.transform.Rotate(0, 270, 0);
            destroyableBullet4.speed = bulletSpeed;


        }

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Destroy(collision.gameObject);

        }
        else if (collision.gameObject.tag == ("PlayerBullet"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}

