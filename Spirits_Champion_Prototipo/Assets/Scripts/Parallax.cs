using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private int parallaxLayer;
    [SerializeField] private GameObject playerCamera;

    // parallaxLayer 1 = Ceu
    // parallaxLayer 2 = Nuvens e montanhas
    // parallaxLayer 3 = Arvores 1
    // parallaxLayer 4 = Arvores 2

    private float secondLayerMultiplier = 0.9f;
    private float thirdLayerMultiplier = 0.7f;
    private float fourthLayerMultiplier = 0.5f;

    [SerializeField] private float levelStartX;
    [SerializeField] private float levelStartY;

    private void Start()
    {

    }
    void Update()
    {

        switch (parallaxLayer)
        {
            case 1:
                transform.position = new Vector3(levelStartX + (playerCamera.transform.position.x - levelStartX) , levelStartY , 0);
                break;

            case 2:
                transform.position = new Vector3(levelStartX + ((playerCamera.transform.position.x - levelStartX) * secondLayerMultiplier), levelStartY, 0);
                break;

            case 3:
                transform.position = new Vector3(levelStartX + ((playerCamera.transform.position.x - levelStartX) * thirdLayerMultiplier), levelStartY, 0);
                break;

            case 4:
                transform.position = new Vector3(levelStartX + ((playerCamera.transform.position.x - levelStartX) * fourthLayerMultiplier), levelStartY, 0);
                break;
        }
    }
}