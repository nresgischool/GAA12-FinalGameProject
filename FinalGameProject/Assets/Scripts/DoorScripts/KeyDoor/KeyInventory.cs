using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace KeySystem
{
    public class KeyInventory : MonoBehaviour
    {
        public bool hasKey = false;
        public TextMeshProUGUI text;
        void Update()
        {
            if (hasKey)
            {
                //text.enable = true;
                text.gameObject.SetActive(true);
            }
        }
    }
}
