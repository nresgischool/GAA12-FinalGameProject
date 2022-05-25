using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    public Transform target;

    // Tracks the players location
    void Update()
    {
        transform.LookAt(2 * transform.position - target.transform.position);
    }
}
