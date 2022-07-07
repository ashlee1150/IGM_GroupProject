using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMovement : MonoBehaviour
{
    Vector2 vec2;
    public bool isSlipped=false;
    public int initialSpeed = 8;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update(){
        if(isSlipped == true)
        {
            initialSpeed = initialSpeed +4;
            isSlipped = false;

        }
        vec2 = transform.localPosition;
        vec2.x += Input.GetAxis("Horizontal") * Time.deltaTime * initialSpeed;
        vec2.y += Input.GetAxis("Vertical") * Time.deltaTime * initialSpeed;
        if (vec2.x >= -7.3f && vec2.x <= 7.3f && vec2.y >= -4.3f && vec2.y <= 4.3f)
        {
            transform.localPosition = vec2;
        }
    }

}
