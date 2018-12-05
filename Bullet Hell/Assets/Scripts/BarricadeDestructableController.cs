using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarricadeDestructableController : MonoBehaviour {
  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("PlayerBullet"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}