using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastOff : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    public GameObject Off;

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
                }
            }

        }
    }
}
