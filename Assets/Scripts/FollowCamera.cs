using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    float distance = 10.0f;
    public float offset = 6f;
    public GameObject player;

    float limitx, limity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + offset, player.transform.position.y + 2.485f, player.transform.position.z - distance);

        limitx = Mathf.Clamp(transform.position.x, 2.85f, 18.17f);
        limity = Mathf.Clamp(transform.position.y, 0f, 14.72f);

        transform.position = new Vector3(limitx, limity, transform.position.z);
    }
}

/*
 transform.position = new Vector3 (Mathf.Clamp (transform.position.x, boundsMin.x, boundsMax.x), Mathf.Clamp (transform.position.y, boundsMin.y, boundsMax.y), Mathf.Clamp (transform.position.z, boundsMin.z, boundsMax.z));*/
