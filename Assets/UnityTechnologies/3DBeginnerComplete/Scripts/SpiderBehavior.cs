using System;
using UnityEngine;

public class SpiderBehavior : MonoBehaviour
{
    public Transform player;
    public float spiderspeed = 3f;
    public float view = 33f;

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToPlayer = player.position - transform.position;
        Vector3 objectForward = transform.forward;

        float dotProduct = Vector3.Dot(directionToPlayer.normalized, objectForward);
        float angle = Mathf.Acos(dotProduct) * Mathf.Rad2Deg;

        if(angle < view){

            Vector3 targetPosition = player.position;
            float step = spiderspeed * Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, targetPosition, step);

        }
    }
}
