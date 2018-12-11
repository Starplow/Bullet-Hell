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
    float sizePerHealth = 0.4f;
    float minSize = 0.6f;
    public Camera cam;
    public LevelController LevelManager;


    // Use this for initialization
    void Start () {

        LevelManager = cam.GetComponent<LevelController>();
        this.transform.localScale = Vector3.one * (minSize + enemyHealth * sizePerHealth);
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





            BulletController destroyableBullet2 = Instantiate(bulletDestroyable, firePoint.position, firePoint.rotation) as BulletController;
            destroyableBullet2.transform.Rotate(0, 90, 0);

            destroyableBullet2.speed = bulletSpeed;






            BulletController destroyableBullet3 = Instantiate(bulletDestroyable, firePoint.position, firePoint.rotation) as BulletController;
            destroyableBullet3.transform.Rotate(0, 180, 0);

            destroyableBullet3.speed = bulletSpeed;





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
            this.transform.localScale = Vector3.one * (minSize + enemyHealth * sizePerHealth);


            if (enemyHealth <= 0)
            {

                if (LevelManager.LevelStatus == 9)
                {
                    SceneManager.LoadScene("Credits");
                }
                else if (LevelManager.LevelStatus == 8)
                {
                    LevelManager.LevelStatus = 9;
                }
                else if (LevelManager.LevelStatus == 7)
                {
                    LevelManager.LevelStatus = 8;
                }
                else if (LevelManager.LevelStatus == 6)
                {
                    LevelManager.LevelStatus = 7;
                }
                else if (LevelManager.LevelStatus == 5)
                {
                    LevelManager.LevelStatus = 6;
                }
                else if (LevelManager.LevelStatus == 4)
                {
                    LevelManager.LevelStatus = 5;
                }
                else if (LevelManager.LevelStatus == 3)
                {
                    LevelManager.LevelStatus = 4;
                }
                else if (LevelManager.LevelStatus == 2)
                {
                    LevelManager.LevelStatus = 3;
                }
                else{
                    LevelManager.LevelStatus = 2;
                }

                Destroy(this.gameObject);
                         
            }
        }

    }

    private void FixedUpdate()
    {
        transform.Rotate(0, 2, 0);
    }

  


}

