using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject cuboid;
    float time = 4.0f;
    Vector3 clone;
    Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time < 0){
            clone = new Vector3(Random.Range(-5,5), transform.position.y, Random.Range(-5,5));
            if(ScoreChange.score >= 5 && ScoreChange.score < 10){
                time = 3.5f;
            }
            else if(ScoreChange.score>=10 && ScoreChange.score <15){
                time = 3.0f;
            }
            else if(ScoreChange.score>=15 && ScoreChange.score <20)
            {
                time = 2.5f;
            }
            else if(ScoreChange.score>=20){
                time = 2.0f;
            }
            else 
                time = 4.0f;
            Instantiate(cuboid, clone, transform.rotation);
        }
    }
}

