using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{

    public float speed = 25;
    //Моделька препятсвия
    public GameObject[] obstacleModels;
    //Сам объект препятсвия, которым мы будем управлять 
    private GameObject obstacle;

    void Start()
    {
        obstacle = GameObject.Instantiate(obstacleModels[ Random.Range(0,obstacleModels.Length)]);
    }

    // Update is called once per frame
    void Update()
    {
        obstacle.transform.Translate(Vector3.back * speed * Time.deltaTime);

        if (obstacle.transform.position.z < -50) 
        {
            Destroy(obstacle);
            obstacle = GameObject.Instantiate(obstacleModels[Random.Range(0, obstacleModels.Length)]);


        }



    }
}
