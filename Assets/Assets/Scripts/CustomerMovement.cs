using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerMovement : MonoBehaviour
{
    Vector2 customerPos;
    public bool canMove=true;
    // Start is called before the first frame update
    void Start()
    {
        customerPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (customerPos.x < -8){
            Destroy(this.gameObject, 0.0f);
        }
        else if (customerPos.x > -8 && canMove == true){
            customerPos.x -= 0.01f;
            transform.position = customerPos;
        }
    }
}
