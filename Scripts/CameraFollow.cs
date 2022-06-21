using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    [SerializeField] Vector3 cameraPosition;
    void Start()
    {
        cameraPosition = new Vector3(4.83f, 9.05f, 4.2f); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + cameraPosition;    
    }
}
