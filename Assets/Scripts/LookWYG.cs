using UnityEngine;
using System.Collections;

public class LookWYG : MonoBehaviour
{
    private PlayerController _playerController;
    // Use this for initialization
    void Start()
    {
        _playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        if (_playerController == null)
            return;

        // NOOOOOOOOOOOO
        //lookPosition.x = Input.GetAxis("Horizontal");
        //lookPosition.y = Input.GetAxis("Vertical");
        //lookPosition += _playerController.velocity;
        //transform.LookAt(lookPosition);
        

        Vector3 lookPosition = transform.position;
        lookPosition += _playerController.velocity;
        transform.LookAt(lookPosition);
        
    }
}
