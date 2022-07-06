using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "truck")
        {
            GameObject truck = collision.gameObject;
            truck.GetComponent<TruckMovement>().isSlipped = true;
            GameObject.Find("Score").GetComponent<Score>().healthCounter -= 1;
            gameObject.GetComponent<CustomerMovement>().canMove = false;
            Destroy(gameObject, 0.25f);
        }
        if (collision.gameObject.tag == "icecream")
        {
            GameObject iceCream = collision.gameObject;
            iceCream.GetComponent<IcecreamMovement>().isHit = true;
        }
    }
}
