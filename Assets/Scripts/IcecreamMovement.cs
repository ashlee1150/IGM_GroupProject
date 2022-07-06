using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcecreamMovement : MonoBehaviour
{
    Rigidbody2D rb2D;
    private float thrust = 400f;
    public bool isHit = false;
    Vector2 currentLoc;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.AddForce(transform.right * thrust);
    }

    // Update is called once per frame
    void Update(){
        currentLoc = transform.localPosition;
        if (isHit == false && currentLoc.x <= 7.5f && currentLoc.x >= -7.5f && currentLoc.y <= 5.0f && currentLoc.y >= -5.0f) {
            transform.Rotate(0, 0, -1, Space.World);
        }
        else
        {
            Destroy(this.gameObject, 0.0f);
        }
    }
}
