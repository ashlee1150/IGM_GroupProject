using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Anim : MonoBehaviour
{
    float dirx, moveSpeed;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        moveSpeed = 2f;
        
    }

    // Update is called once per frame
    void Update()
    {
        dirx = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        transform.position = new Vector2(transform.position.x + dirx, transform.position.y);
         
    }
}
