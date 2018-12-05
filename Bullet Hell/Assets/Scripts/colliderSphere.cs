using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderSphere : MonoBehaviour
{
    private void OnTriggerExit(Collider collider)
    {
        Destroy(collider.gameObject);
    }
}
