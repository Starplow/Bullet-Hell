using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class BarricadeDestructableController : MonoBehaviour {



    private void OnCollisionEnter(Collision collision)
    {

        Destroy(this.gameObject.GetComponent<NavMeshObstacle>());
        if (collision.gameObject.tag == ("PlayerBullet"))
        {
            
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == ("EnemyBullet"))
        {
            Destroy(collision.gameObject);
        }
    }
}