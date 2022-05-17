using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaLauncherTest : MonoBehaviour
{
    [SerializeField] private float launchSpeed = 700;
    //public float fortnite = new Vector3(0, -1.77547228, 4.45869923);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            this.gameObject.GetComponent<Rigidbody>().AddRelativeForce((new Vector3(0, 0, launchSpeed)));
            //capsule.GetComponent<Rigidbody>().AddRelativeForce((new Vector3(0, 0, launchVelocity)));
        }

        if(Input.GetKeyDown("R"))
        {
            //Instantiate()
        }
    }
}
