using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMovement : MonoBehaviour
{
    float speed = 2f;
    Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.position += Vector3.down * Time.deltaTime * speed;
       if(transform.position.y <=-7)
       {
           Destroy(transform.gameObject);
       }
    }
}
