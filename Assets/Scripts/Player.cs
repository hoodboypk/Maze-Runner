using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float speed = 10f;

    //[SerializeField]
    //private float jumpForce = 11f;
    public Rigidbody2D rb;
    private float movementX;
    private float movementY;

    private Rigidbody2D myBody;

    private SpriteRenderer sr;

    //private Animator anim;
    //private string WALK_ANIMATION = "Player_move";



    

    private void Awake()
    {

        myBody = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        //AnimatePlayer();
        

    }

    //private void FixedUpdate()
    //{
    //    PlayerJump();
    //}

    void PlayerMoveKeyboard()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Move the player
        transform.Translate(movement * speed * Time.deltaTime);

        // Optional: Rotate the player based on the movement direction
        if (movement != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 500f * Time.deltaTime);
        }

    }

    //void AnimatePlayer()
    //{

    //    // we are going to the right side
    //    if (movementX > 0)
    //    {
    //        anim.SetBool(WALK_ANIMATION, true);
    //        sr.flipX = false;
    //    }
    //    else if (movementX < 0)
    //    {
    //        // we are going to the left side
    //        anim.SetBool(WALK_ANIMATION, true);
    //        sr.flipX = true;
    //    }
    //    else
    //    {
    //        anim.SetBool(WALK_ANIMATION, false);
    //    }

    //}

    

    
} // class































