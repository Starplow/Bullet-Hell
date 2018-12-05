using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderBorder : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("PlayerBullet"))
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == ("EnemyBullet"))
        {
            Destroy(collision.gameObject);
        }
    }
}
