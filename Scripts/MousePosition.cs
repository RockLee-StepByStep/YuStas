using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    [SerializeField]Vector3 mousy;

    private void Start()
    {
       mousy = Camera.main.ScreenToViewportPoint(Input.mousePosition);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log(mousy);
        }
    }
}
