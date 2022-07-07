using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcecreamLauncher : MonoBehaviour
{
    public GameObject icecreamPrefab;
    Vector3 currentPos;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            currentPos = transform.localPosition;
            currentPos.x = currentPos.x + 1;
            Instantiate(icecreamPrefab, currentPos, Quaternion.identity);

        }
    }
}
