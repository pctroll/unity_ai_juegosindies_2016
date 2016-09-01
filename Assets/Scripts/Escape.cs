using UnityEngine;
using System.Collections;

public class Escape : MonoBehaviour
{
    public GameObject target;
    public float speed = .5f;
    public float safeRadius = 1f;
    private Vector3 velocity;
    private float distance;

    // Use this for initialization
    void Start()
    {
        velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;
        distance = Vector3.Distance(target.transform.position, transform.position);
        if (distance >= safeRadius)
            return;
        velocity = transform.position - target.transform.position;
        velocity.Normalize();
        transform.Translate(velocity * speed * Time.deltaTime, Space.World);
    }
}
