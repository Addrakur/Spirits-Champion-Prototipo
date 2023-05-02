using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraBounds : MonoBehaviour
{
    private CinemachineConfiner2D confiner;

    [SerializeField] GameObject backgroundManager;
    [SerializeField] private GameObject cameraBoundVillage;
    [SerializeField] private GameObject cameraBoundForest;
    [SerializeField] private GameObject cameraBoundTeste;

    private BackgroundManager backgroundManagerScript;
    private PolygonCollider2D cameraPolygonVillage;
    private PolygonCollider2D cameraPolygonForest;
    private PolygonCollider2D cameraPolygonTeste;

    // Start is called before the first frame update
    void Start()
    {
        backgroundManagerScript = backgroundManager.GetComponent<BackgroundManager>();
        confiner = GetComponent<Cinemachine.CinemachineConfiner2D>();
        cameraPolygonVillage = cameraBoundVillage.GetComponent<PolygonCollider2D>();
        cameraPolygonForest = cameraBoundForest.GetComponent<PolygonCollider2D>();
        cameraPolygonTeste = cameraBoundTeste.GetComponent<PolygonCollider2D>();
    }

    private void Update()
    {
        switch (backgroundManagerScript.regiao)
        {
            case "Village":
                confiner.m_BoundingShape2D = cameraPolygonVillage;
                break;

            case "Forest":
                confiner.m_BoundingShape2D = cameraPolygonForest;
                break;

            case "Teste":
                confiner.m_BoundingShape2D = cameraPolygonTeste;
                break;
        }
    }
}