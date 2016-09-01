using UnityEngine;
using System.Collections;

public class SeekRigidbody : MonoBehaviour
{
    public GameObject target;
    public float speed = .5f;
    private Vector3 velocity;

    private Rigidbody _rb;

    // Use this for initialization
    void Start()
    {
        velocity = Vector3.zero;
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_rb == null || target == null)
            return;
        velocity = target.transform.position - transform.position;
        velocity.Normalize();
        // NOUP, NOUP, NOUP
        //transform.Translate(velocity * speed * Time.deltaTime, Space.World);
        velocity *= speed;
        // THIS ONE
        _rb.AddForce(velocity, ForceMode.VelocityChange);
        // OR THIS ONE
        //_rb.AddForce(velocity, ForceMode.Force);
    }
}
