using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationaryEnemyController : MonoBehaviour {

    public BulletController stationaryBullets;
    public Transform frontPoint;
    public float timeBetweenShots;
    private float shotCounter;
    public float bulletSpeed;
    



    // Use this for initialization
    void Start()
    {

      

    }

    // Update is called once per frame
    void Update()
    {




        shotCounter -= Time.deltaTime;
        if (shotCounter <= 0)
        {


            shotCounter = timeBetweenShots;
            BulletController stationaryBullet0 = Instantiate(stationaryBullets, frontPoint.position, frontPoint.rotation) as BulletController;
            stationaryBullet0.speed = bulletSpeed;






            //Quaternion rotation = Quaternion.Euler(0, 90, 0);


            shotCounter = timeBetweenShots;
            BulletController stationaryBullet1 = Instantiate(stationaryBullets, frontPoint.position, frontPoint.rotation) as BulletController;
            stationaryBullet1.transform.Rotate(0, 90, 0);
            stationaryBullet1.speed = bulletSpeed;






            shotCounter = timeBetweenShots;
            BulletController stationaryBullet2 = Instantiate(stationaryBullets, frontPoint.position, frontPoint.rotation) as BulletController;
            stationaryBullet2.transform.Rotate(0, 180, 0);
            stationaryBullet2.speed = bulletSpeed;






            shotCounter = timeBetweenShots;
            BulletController stationaryBullet3 = Instantiate(stationaryBullets, frontPoint.position, frontPoint.rotation) as BulletController;
            stationaryBullet3.transform.Rotate(0, 270, 0);
            stationaryBullet3.speed = bulletSpeed;


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
