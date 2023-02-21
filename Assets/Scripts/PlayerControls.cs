using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    //rigid body 2d object that is stored
    [Header("RigidBody")]
    public Rigidbody2D rb;
    [Header("Default Down Speed")]
    public float downSpeed = 20f;
    [Header("Default Movement Speed")]
    //movement speed of the object
    public float movementSpeed = 10f;
    [Header("Default Directional Movement Speed")]
    //movement direction of the object
    public float movement = 0f;








    // Start is called before the first frame update
    void Start()
    {
        //variable equals to component rigidbody 2d
        rb = GetComponent<Rigidbody2D>();



    }

    // Update is called once per frame
    void Update()
    {
        //movement equals horizontal movement
        //multiplied by movement speed
        movement = Input.GetAxis("Horizontal") * movementSpeed; 
    //if direction on x axis is less than 0
if (movement < 0)
{
//object faces to the left
this.GetComponent<SpriteRenderer>().flipX = false;

} else {
            //object faces to the right
    this.GetComponent<SpriteRenderer>().flipX = true;

        }}

        //fixedupdate called every fixed frame-rate frame
        void FixedUpdate()
        {
            //vector 2 which is x y velocity
            //equals to the velocity of the rigidbody2D
            Vector2 velocity = rb.velocity;
            //velocity of x axis equals to
            //the direction movement on the x axis
            //of the charactor
            velocity.x = movement;
            //rigidbody2d velocity equals to
            //velocity of the object
            rb.velocity = velocity;
        
        
        }



    private void OnCollisionEnter2D(Collision2D collision)

    {
        //velocity with the downspeed
        rb.velocity = new Vector3(rb.velocity.x, downSpeed, 0);

    }

};