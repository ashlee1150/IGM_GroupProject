using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcecreamCollision : MonoBehaviour
{
    public GameObject FireworksAll;

    public Sprite icecreamCollPath;
    public Sprite truckCollPath;
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
        if (collision.gameObject.tag == "icecream")
        {
            GameObject iceCream = collision.gameObject;
            iceCream.GetComponent<IcecreamMovement>().isHit = true;
            GameObject.Find("Score").GetComponent<Score>().scoreCounter +=1;
            gameObject.GetComponent<SpriteRenderer>().sprite = icecreamCollPath;
            gameObject.GetComponent<CustomerMovement>().canMove = false;
            //gameObject.GetComponent<Rigidbody2D>().
            Destroy(gameObject, 0.25f);
        }
        else if (collision.gameObject.tag == "truck")
        {
            Debug.Log("Woah that hurt");
            //GameObject.Find("Score").GetComponent<Score>().healthCounter -= 1;
            Destroy(this.gameObject);
            GameObject firework = Instantiate(FireworksAll, GameObject.FindGameObjectWithTag("enemy").transform.position, Quaternion.identity);
            firework.GetComponent<ParticleSystem>().Play();
            //gameObject.GetComponent<SpriteRenderer>().sprite = truckCollPath;
            //gameObject.GetComponent<CustomerMovement>().canMove = false;
            //gameObject.GetComponent<Rigidbody2D>().
            //Destroy(gameObject, 0.25f);
        }
    }
}
