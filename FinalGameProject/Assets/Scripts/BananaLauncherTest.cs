using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaLauncherTest : MonoBehaviour
{
    [SerializeField] private float launchSpeed = 700;
    private bool doOnce = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && !doOnce)
        {
            this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            this.gameObject.GetComponent<Rigidbody>().AddRelativeForce((new Vector3(0, 0, launchSpeed)));
            this.transform.parent = null;
            doOnce = true;
            //capsule.GetComponent<Rigidbody>().AddRelativeForce((new Vector3(0, 0, launchVelocity)));
        }

        if(Input.GetKeyDown("r"))
        {
            Debug.Log("Instantiate");
            Instantiate(this);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Destroy(this.gameObject, 5);
    }
}
