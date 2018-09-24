using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 0;
    private CharacterController characterController;
    private Vector3 velocity;
    private bool isGrounded;

    // Use this for initialization
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        // get input data from keyboard or controller
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // update player position based on input
        Vector3 position = transform.position;
        position.x += moveHorizontal * speed * Time.deltaTime;
        position.z += moveVertical * speed * Time.deltaTime;
        transform.position = position;*/

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.Move(move * Time.deltaTime * speed);
        //Transform cameraTransform = transform.Find("OVRCameraRig").Find("TrackingSpace").Find("CenterEyeAnchor");
        //GameObject camera = gameObject.

        //if (cameraTransform.forward != Vector3.zero)
        //{
           // transform.forward = cameraTransform.forward;
        //}

       // isGrounded = Physics.CheckSphere(_groundChecker.position, GroundDistance, Ground, QueryTriggerInteraction.Ignore);
        //if (isGrounded && velocity.y < 0)
       // {
       //     velocity.y = 0f;
       // }

        velocity.y += Physics.gravity.y * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);

    }
}