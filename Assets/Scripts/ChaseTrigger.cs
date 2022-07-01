using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class ChaseTrigger : MonoBehaviour
{
    

        public float moveTimeSeconds;            //Time it will take object to move, in seconds.

        private float xMax = 10.0f; // The boundaries of the spawn area
        private float yMax = 10.0f;
        private float xMin = -10.0f; // The boundaries of the spawn area
        private float yMin = -10.0f;

        public int xDistanceRange; // The max distance you can move at one time
        //public int yDistanceRange;

        private BoxCollider2D boxCollider;         //The BoxCollider2D component attached to this object.
        private Rigidbody2D rb2D;                //The Rigidbody2D component attached to this object.
        private float inverseMoveTime;            //Used to make movement more efficient.
        public Vector2 start;
        public Vector2 end;
        public bool roam = true;
        public Collider2D[] hits;
        public Transform player; // changed this to Transform
        public float detectRange = 10; // this gets multiplied by itself to compare to a sqr magnitude check (instead of distance)
        public bool inRange = false;
        public float moveSpeed = 2f; // you can adjust this, of course.
                                     //Rigidbody2D rb;  // cached the reference, so you can avoid GetComponent calls in Update/FixedUpdate.
        void Awake()
        {
            rb2D = GetComponent<Rigidbody2D>();
            detectRange *= detectRange;
        }
        void Start()
        {
            boxCollider = GetComponent<BoxCollider2D>();
            rb2D = GetComponent<Rigidbody2D>();

            inverseMoveTime = 1f / moveTimeSeconds;
            InvokeRepeating("RandomMove", 0.0f, 5.0f);

        }

        void Update()
        {
            Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, 10); // returns all colliders within radius of enemy
            int i = 0;
            while (hits.Length > i)
            {
                //Debug.Log("Sees");
                //Debug.Log(hits[i]);
                i++;
            }
            //followPlayer();

            if (roam)
            {
                //Debug.Log("Roam");
                transform.position = Vector2.MoveTowards(transform.position, end, inverseMoveTime * Time.deltaTime); //Random move to new position
            }
            float distsqr = (player.position - transform.position).sqrMagnitude;

            if (distsqr <= detectRange)
            {
                inRange = true;
                
            // get a velocity based on the normalized direction, multiplied by move speed.
                Vector2 velocity = (player.transform.position - transform.position).normalized * moveSpeed;
                rb2D.velocity = velocity;
            }
    }

        

    
        public void RandomMove() // gets random coordinates near enemy and moves there
        {
            float xDistance = Random.Range(-xDistanceRange, xDistanceRange); // check
            //float yDistance = Random.Range(-yDistanceRange, yDistanceRange);// check

            if (xDistance < xMax && xDistance > xMin && roam == true) // If within boundaries of walking space
            {
                start = transform.position;
                end = start + new Vector2(xDistance,0);

                Debug.Log("Roaming From : " + start + " To : " + end);
            }
        }
        
          
}

