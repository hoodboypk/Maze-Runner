using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float moveForce = 10f;
    public float verticalSpeed = 8f;


    public Rigidbody2D rb;
    private float movementX;
    private float movementY;
    private float verticalInput;
    

    private Rigidbody2D myBody;

    private SpriteRenderer sr;

    private Animator anim;
    private string WALK_ANIMATION = "Go";
    private string MOVE_ANIMATION = "Move";






    private void Awake()
    {

        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

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
        HandleVerticalMovement();
        AnimatePlayer();
    }

    void PlayerMoveKeyboard()
    {

        movementX = Input.GetAxisRaw("Horizontal");

        myBody.velocity = new Vector2(movementX * moveForce, myBody.velocity.y);

    }

    void HandleVerticalMovement()
    {
        // Get input from the vertical axis (up and down keys or W and S keys)
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement in the vertical direction
        Vector3 verticalMovement = new Vector3(0f, verticalInput, 0f).normalized;

        // Move the player vertically
        myBody.velocity = new Vector2(myBody.velocity.x, verticalInput * verticalSpeed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trap")
        {
            Debug.Log("Ho gaya!");
            SceneManager.LoadScene("GameOver");
        }
    }
    void AnimatePlayer()
    {

        // we are going to the right side
        if (movementX > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }
        else if (movementX < 0)
        {
            // we are going to the left side
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;
        }
        if (Input.GetKey("up"))
        {
            anim.SetBool(MOVE_ANIMATION, true);
            sr.flipY = false;
        }
        else if (Input.GetKey("down"))
        {
            // we are going to the left side
            anim.SetBool(MOVE_ANIMATION, false);
            sr.flipY = false;
        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }

    }




} // class































