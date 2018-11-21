using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderSphere : MonoBehaviour
{

    // Use this for initialization

    private void OnTriggerExit(Collider collider)
    {

        Destroy(collider.gameObject);



    }
}
