using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerController : MonoBehaviour
{

    //Speed of character movement and height of the jump. Set these values in the inspector.
    public float speed;
    public float jumpHeight;
    public AudioSource[] sounds;
    public AudioSource jumpsound;
    public AudioSource coinsound;
    public AudioSource Unlock;

    private bool isJumping;
    private Animator anim;


    //Assigning a variable where we'll store the Rigidbody2D component.
    private Rigidbody2D rb;

    private bool canJump;
    //Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //Sets our variable 'rb' to the Rigidbody2D component on the game object where this script is attached.
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
       
        sounds = GetComponents<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {


        //If we're able to jump and the player has pressed the space bar, then we jump!
        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            anim.SetBool("isJumping", true);
            rb.velocity = Vector2.up * jumpHeight;
            jumpsound.Play();
        }


        //Movement code for left and right arrow keys.
        //if((!Input.GetKeyDown(KeyCode.RightArrow))|| !(Input.GetKey(KeyCode.LeftArrow))){
          //  anim.SetBool("walking", false);
        //}
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            anim.SetBool("isJumping", false);
            //anim.Set
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isJumping", false);
            rb.velocity = new Vector2(+speed, rb.velocity.y);
        }
        //ELSE if we're not pressing an arrow key, our velocity is 0 along the X axis, and whatever the Y velocity is (determined by jump)
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            anim.SetBool("isJumping", false);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If we collide with an object tagged "ground" then our jump resets and we can now jump.
        if (collision.gameObject.tag == "ground")
        {
            canJump = true;
            //print statements print to the Console panel in Unity. 
            //This will print the value of onGround, which is a boolean, so either True or False.
        }
        if (collision.gameObject.tag == "item" || collision.gameObject.tag == "item2" || collision.gameObject.tag == "item3" || collision.gameObject.tag == "item4" || collision.gameObject.tag == "item5" || collision.gameObject.tag == "item6" || collision.gameObject.tag == "item7" || collision.gameObject.tag == "item8" || collision.gameObject.tag == "item9" || collision.gameObject.tag == "item10") 
        {
            coinsound.Play();

            Debug.Log("Played sound");
        }
        if(collision.gameObject.tag == "key_white")
        {
            Unlock.Play();
            Debug.Log("key played");
        }else if (  collision.gameObject.tag == "green_key")
        {
            Unlock.Play();
            Debug.Log("green key played");
        }
        else if(collision.gameObject.tag == "red_key")
        {
            Unlock.Play();
            Debug.Log("red key played");
        }

    }
  

    private void OnCollisionExit2D(Collision2D collision)
    {
        //If we exit our collision with the "ground" object, then we are unable to jump.
        if (collision.gameObject.tag == "ground")
        {
            canJump = false;
        }

    }

}
