using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float moveForce = 10f;

   
    public Rigidbody2D rb;
    private float movementX;
    private float movementY;

    private Rigidbody2D myBody;

    private SpriteRenderer sr;

    private Animator anim;
    private string WALK_ANIMATION = "Go";





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
        AnimatePlayer();


    }

    

    void PlayerMoveKeyboard()
    {

        movementX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(movementX, 0f, 0f) * moveForce * Time.deltaTime;

        movementY = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(movementY, 0f, 0f) * moveForce * Time.deltaTime;

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
        if (movementY > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipY = false;
        }
        else if (movementY < 0)
        {
            // we are going to the left side
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipY = false;
        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }

    }




} // class































