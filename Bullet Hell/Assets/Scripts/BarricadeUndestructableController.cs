using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarricadeUndestructableController : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("PlayerBullet"))
        {
             Destroy(collision.gameObject);
        }
    }
}
