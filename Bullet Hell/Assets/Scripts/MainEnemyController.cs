using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainEnemyController : MonoBehaviour {

    public BulletController bulletDestroyable;
    public Transform firePoint;
    public float timeBetweenShots;
    private float shotCounter;
    public float bulletSpeed;
    public float enemyHealth;

    public Camera cam;
    public CameraMovement Move;


    // Use this for initialization
    void Start () {

        Move = cam.GetComponent<CameraMovement>();

    }
	
	// Update is called once per frame
	void Update () {

        
        

        shotCounter -= Time.deltaTime;
        if (shotCounter <= 0)
        {


            shotCounter = timeBetweenShots;
            BulletController destroyableBullet = Instantiate(bulletDestroyable, firePoint.position, firePoint.rotation) as BulletController;
            destroyableBullet.speed = bulletSpeed;






            //Quaternion rotation = Quaternion.Euler(0, 90, 0);


            shotCounter = timeBetweenShots;
            BulletController destroyableBullet2 = Instantiate(bulletDestroyable, firePoint.position, firePoint.rotation) as BulletController;
            destroyableBullet2.transform.Rotate(0, 90, 0);
            destroyableBullet2.speed = bulletSpeed;






            shotCounter = timeBetweenShots;
            BulletController destroyableBullet3 = Instantiate(bulletDestroyable, firePoint.position, firePoint.rotation) as BulletController;
            destroyableBullet3.transform.Rotate(0, 180, 0);
            destroyableBullet3.speed = bulletSpeed;






            shotCounter = timeBetweenShots;
            BulletController destroyableBullet4 = Instantiate(bulletDestroyable, firePoint.position, firePoint.rotation) as BulletController;
            destroyableBullet4.transform.Rotate(0, 270, 0);
            destroyableBullet4.speed = bulletSpeed;


        }

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("PlayerBullet"))
        {
            Destroy(collision.gameObject);
            enemyHealth--;
           
                    
            if (enemyHealth <= 0)
            {
                Move.endLevel01 = true;
                Destroy(this.gameObject);

                //SceneManager.LoadScene("VictoryScreen");
            }
        }

    }
    private void FixedUpdate()
    {
        transform.Rotate(0, 2, 0);
    }

  


}

