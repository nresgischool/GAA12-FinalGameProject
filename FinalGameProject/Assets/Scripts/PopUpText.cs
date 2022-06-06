using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpText : MonoBehaviour
{
    public TextMeshPro text;
    private bool showText = false;
    public Transform target;


    void Awake()
    {
        text.gameObject.SetActive(false);
    }

    void Update()
    {
        text.transform.LookAt(2 * transform.position - target.transform.position);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            text.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            text.gameObject.SetActive(false);
        }
    }
}
