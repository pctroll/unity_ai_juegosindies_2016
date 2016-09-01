using UnityEngine;
using System.Collections;

public class Seek : MonoBehaviour
{
    public GameObject target;
    public float speed = .5f;
    private Vector3 velocity;

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
        velocity = target.transform.position - transform.position;
        velocity.Normalize();
        transform.Translate(velocity * speed * Time.deltaTime, Space.World);
    }
}
