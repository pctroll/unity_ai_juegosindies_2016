using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 _velocity;

    public Vector3 velocity
    {
        get { return _velocity; }
    }

    // Use this for initialization
    void Start()
    {
        _velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        _velocity.x = Input.GetAxis("Horizontal");
        _velocity.z = Input.GetAxis("Vertical");
        _velocity.y = 0f;
        _velocity.Normalize();
        transform.Translate(_velocity * speed * Time.deltaTime, Space.World);
    }
}
