using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractText : MonoBehaviour
{
    public TextMeshPro text;
    private bool showText = false;
    public Transform target;

    public void ShowText()
    {
        if (!showText)
        {
            text.gameObject.SetActive(true);
            showText = true;
            Debug.Log("Show Text");
        }
        else
        {
            text.gameObject.SetActive(false);
            showText = false;
            Debug.Log("Hide Text");
        }
    }

    void Awake()
    {
        text.gameObject.SetActive(false);
    }

    void Update()
    {
        this.transform.LookAt(2 * transform.position - target.transform.position);
    }

    /*void OnTriggerEnter(Collider col)
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
    }*/
}
