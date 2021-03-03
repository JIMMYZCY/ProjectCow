using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float speed = 10.0f;
    float rotationspeed = 100.0f;
    //public GameObject player_prefab;
    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical") * speed;
        float horizontal = Input.GetAxis("Horizontal") * rotationspeed;

        vertical *= Time.deltaTime;
        horizontal *= Time.deltaTime;
        transform.Translate(0, 0, vertical);
        transform.Rotate(0, horizontal, 0);
    }



}