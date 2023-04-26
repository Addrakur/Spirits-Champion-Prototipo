using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraBounds : MonoBehaviour
{

    private CinemachineConfiner2D confiner;
    private GameObject cameraBound;

    // Start is called before the first frame update
    void Start()
    {
        confiner = GetComponent<CinemachineConfiner2D>();
        cameraBound = GameObject.Find("Camera Bound");
        confiner.m_BoundingShape2D = cameraBound.GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}