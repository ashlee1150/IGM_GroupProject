using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawn : MonoBehaviour
{
    public GameObject customerPrefab;
    
    private float xPos=9f;
    private float yPos;
    int randomNumber;
    int randomCust;
    int randomObs;
    private bool play;
    Vector2 randomPos;
    //public bool obstacleSpawn;
    private float lastYPos=0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
            InvokeRepeating("GenerateCustomer", 1.0f, 0.8f);

        
    }
    // Update is called once per frame
    
    
    void GenerateCustomer()
    {
        randomNumber = Random.Range(0, 2);
        if (randomNumber == 1)
        {
            randomCust = Random.Range(1, 3);
            if (randomCust == 1)
            {
                
                yPos = Random.Range(-3.7f, 3.7f);
                while (yPos<= lastYPos+0.4f && yPos>= lastYPos - 0.4f)
                {
                    lastYPos = yPos;
                    yPos = Random.Range(-3.7f, 3.7f);
                }
                randomPos.x = xPos;
                randomPos.y = yPos;
                //Instantiate(customerPrefab2, randomPos, Quaternion.identity);
                lastYPos = yPos;
            }
            else
            {
                yPos = Random.Range(-3.7f, 3.7f);
                while (yPos <= lastYPos + 0.4f && yPos >= lastYPos - 0.4f)
                {
                    lastYPos = yPos;
                    yPos = Random.Range(-3.7f, 3.7f);
                }
                randomPos.x = xPos;
                randomPos.y = yPos;
                Instantiate(customerPrefab, randomPos, Quaternion.identity);
                lastYPos = yPos;
            }
            /*
            
            if(obstacleSpawn == true)
            {
                randomObs = Random.Range(1, 5);
                if (randomObs == 2)
                {
                    yPos = Random.Range(-3.7f, 3.7f);
                    while (yPos <= lastYPos + 0.4f && yPos >= lastYPos - 0.4f)
                    {
                        lastYPos = yPos;
                        yPos = Random.Range(-3.7f, 3.7f);
                    }
                    randomPos.x = xPos;
                    randomPos.y = yPos;
                    //Instantiate(obstaclePrefab, randomPos, Quaternion.identity);
                    lastYPos = yPos;
                }
            }
            */
            
        }
        
    }
}
