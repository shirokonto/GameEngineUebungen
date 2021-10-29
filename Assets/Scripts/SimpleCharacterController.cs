using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour  
{
    [SerializeField] private RigidBody rb;
    [SerializeField] private Vector3 velocity;
    [SerializeField] [Range(-10, 10)] private float acceleration;
    [SerializeField] private Vector3 directionVector;
    //Define the speed at which the object moves
    public float moveSpeed = 10;

    //public float velocity;
    //public float jumpForce = 20f;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    //void Update()
    //{
    //velocity = 0;
    //float horizontalInput = Input.GetAxis("Horizontal");

    // float verticalInput = Input.GetAxis("Vertical");

    //transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime);

    //if(verticalInput.GetKeyDown(KeyCode.Space))
    //{
    //velocity = jumpForce;
    //}
    //transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
    //}

    private void FixedUpdate()
    {
        this.velocity = rb.velocity;

        //float horizontalInput = Input.GetAxis("Horizontal");

        //float verticalInput = Input.GetAxis("Vertical");

        //Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        //this.velocity = ReadOnlyCollectionBase.velocity;
        directionVector = this.directionIndicatorTransform.position = this.transform.position;
        
        this.velocity += directionVector.normalized * (acceleration * Time.deltaTime);

        this.rb.velocity = this.velocity;
    }
}
