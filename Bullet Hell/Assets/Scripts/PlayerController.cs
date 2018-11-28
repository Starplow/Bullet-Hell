using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{

    //how fast the Player moves around
    public float moveSpeed;
    private Rigidbody myRigidbody;

    private Vector3 moveInput;
    public Vector3 moveVelocity;

    private Camera mainCamera;

    public static GameObject playerObject;

    public GunController theGun;

    public bool useController;

    public float recoilIntensity;

    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

        mainCamera = FindObjectOfType<Camera>();
        playerObject = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * moveSpeed;


        // Rotate with mouse
        if (!useController)
        {
            Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
            Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
            float rayLength;

            if (groundPlane.Raycast(cameraRay, out rayLength))
            {
                Vector3 pointToLook = cameraRay.GetPoint(rayLength);
                Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);

                transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));

            }

        }
        // rotate with Controller
        if (useController)
        {
            Vector3 playerDirection = (Vector3.right * Input.GetAxisRaw("RHorizontal")) + (Vector3.forward * (-Input.GetAxisRaw("RVertical")));

            if (playerDirection.sqrMagnitude > 0.0f)
            {

                transform.rotation = Quaternion.LookRotation(playerDirection, Vector3.up);

            }

        }
        if (Input.GetButtonDown("Fire1"))
        {

            theGun.isFiring = true;

        }
        if (Input.GetButtonUp("Fire1"))
        {
            theGun.isFiring = false;
        }
    }
    private void FixedUpdate()
    {

        myRigidbody.AddForce(moveVelocity);
        print((myRigidbody.velocity).magnitude);
        if (myRigidbody.velocity.magnitude > 21)
        {
            myRigidbody.AddForce(-myRigidbody.velocity * 10);
        }
    }
    public void recoil()
    {

        myRigidbody.AddForce(-Vector3.Normalize(transform.forward) * recoilIntensity);
        print((-Vector3.Normalize(transform.forward) * recoilIntensity).magnitude);

    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == ("Enemy"))
            SceneManager.LoadScene("DefeatScreen");
        else if (collision.gameObject.tag == ("Bullet"))
        {
            SceneManager.LoadScene("DefeatScreen");
        }
    }
    */
}
