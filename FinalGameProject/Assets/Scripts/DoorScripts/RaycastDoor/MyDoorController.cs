using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDoorController : MonoBehaviour
{
    private Animator doorAnim;
    private bool doorOpen = false;
    [SerializeField] private string doorOpenAnim;
    [SerializeField] private string doorCloseAnim;

    void Awake()
    {
        doorAnim = gameObject.GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if (!doorOpen)
        {
            doorAnim.Play(doorOpenAnim, 0, 0.0f);
            doorOpen = true;
            Debug.Log("Door Open");
        }
        else
        {
            doorAnim.Play(doorCloseAnim, 0, 0.0f);
            doorOpen = false;
            Debug.Log("Door Closed");
        }
    }
}
