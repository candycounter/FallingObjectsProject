using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCatcher : MonoBehaviour
{

    float speed = 6f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * Time.deltaTime * speed;
        }
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cuboid(Clone)")
        {
            Destroy(collision.gameObject);
            ScoreChange.score ++;
        }
    }

}

