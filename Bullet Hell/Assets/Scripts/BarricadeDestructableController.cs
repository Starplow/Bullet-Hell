using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class BarricadeDestructableController : MonoBehaviour {



    private void OnCollisionEnter(Collision collision)
    {

       

        if (collision.gameObject.tag == ("PlayerBullet"))
        {
            //Destroy(GetComponent<NavMeshObstacle>());
            Destroy(collision.gameObject);
            //Destroy(this.gameObject);
            
        }
        else if (collision.gameObject.tag == ("EnemyBullet"))
        {
            Destroy(collision.gameObject);
        }
        
    }
}