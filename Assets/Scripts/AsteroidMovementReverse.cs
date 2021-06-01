using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovementReverse : MonoBehaviour
{
    // Start is called before the first frame update
   public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, 2) * 7 - 3;
        transform.position = new Vector3(-x, transform.position.y, transform.position.z);

    }
}
