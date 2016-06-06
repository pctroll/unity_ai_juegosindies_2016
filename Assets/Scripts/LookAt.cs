using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour
{
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        if (ReferenceEquals(target, null))
            return;
        transform.LookAt(target.transform);
    }
}
