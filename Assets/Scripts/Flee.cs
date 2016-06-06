using UnityEngine;
using System.Collections;

public class Flee : MonoBehaviour
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
        if (ReferenceEquals(target, null))
            return;
        velocity = transform.position - target.transform.position;
        velocity.Normalize();
        transform.Translate(velocity * speed * Time.deltaTime, Space.World);
    }
}
