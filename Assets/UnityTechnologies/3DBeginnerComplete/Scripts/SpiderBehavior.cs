using UnityEngine;

public class SpiderBehavior : MonoBehaviour
{
    public Transform player;
    public float spiderspeed = 3f;

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToPlayer = player.position - transform.position;
        Vector3 objectForward = transform.forward;

        float dotProduct = Vector3.Dot(directionToPlayer.normalized, objectForward);

        if(dotProduct > 0){

            Vector3 targetPosition = player.position;
            float step = spiderspeed * Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, targetPosition, step);
        }
    }
}
