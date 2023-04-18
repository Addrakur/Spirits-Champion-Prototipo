using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public int parallaxLayer;
    public GameObject playerCamera;

    // parallaxLayer 1 = Ceu
    // parallaxLayer 2 = Nuvens e montanhas
    // parallaxLayer 3 = Arvores 1
    // parallaxLayer 4 = Arvores 2

    void Update()
    {
        switch (parallaxLayer)
        {
            case 1:
                
                break;
        }
    }
}