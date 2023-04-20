using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool isBase;

    // Start is called before the first frame update
    void Start()
    {

        if (!isBase && !SceneManager.GetSceneByName("Base").isLoaded)
        {
            SceneManager.LoadScene("Base", LoadSceneMode.Additive);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}