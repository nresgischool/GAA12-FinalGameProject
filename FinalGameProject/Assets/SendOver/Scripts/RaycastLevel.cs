using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaycastLevel : MonoBehaviour
{
    public int levelSelect;
    [SerializeField] private string selectableTag = "SelectableFinal";

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
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + levelSelect);
                }
            }

        }
    }
}
