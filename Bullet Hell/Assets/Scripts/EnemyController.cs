using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class EnemyController : MonoBehaviour
{

    private Rigidbody myRigidbody;
    public float enemySpeed;

    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
    }

    void MoveToPlayer()
    {

        //Debug.DrawLine(this.transform.position, PlayerController.playerObject.transform.position);

        //Vector3 direction = PlayerController.playerObject.transform.position - this.transform.position;
        //direction = direction.normalized;
        this.GetComponent<NavMeshAgent>().SetDestination(PlayerController.playerObject.transform.position);
        //myRigidbody.velocity = Vector3.Normalize(new Vector3(direction.x, 0f, direction.z)) * enemySpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {

            SceneManager.LoadScene("DefeatScreen");

        }
        else if (collision.gameObject.tag == ("PlayerBullet"))
        {
            
            Destroy(this.gameObject);
            Destroy(collision.gameObject);

        }
    }
    
}
