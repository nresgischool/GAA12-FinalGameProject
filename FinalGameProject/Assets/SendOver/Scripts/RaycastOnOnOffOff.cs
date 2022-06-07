using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastOnOnOffOff : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    public GameObject On;
    public GameObject On2;
    public GameObject Off;
    public GameObject Off2;

    private Transform _selection;

    private void Update()
    {

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                _selection = selection;
                if (Input.GetMouseButton(0))
                {
                    Off.SetActive(false);
                    On.SetActive(true);
                    On2.SetActive(true);
                    Off2.SetActive(false);
                }
            }

        }
    }
}
