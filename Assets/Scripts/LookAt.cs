using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour
{
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;
        transform.LookAt(target.transform);
    }
}
