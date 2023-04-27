using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string regionNow;

    private GameObject backgroundManager;
    private BackgroundManager backgroundManagerScript;

    private Player playerScript;
    private GameObject player;
    private string spawnPoint;
    GameObject spawnPointObject;
    
    void Start()
    {
            backgroundManager = GameObject.Find("Background Manager");
            backgroundManagerScript = backgroundManager.GetComponent<BackgroundManager>();
            player = GameObject.Find("Player Box");
            playerScript = player.GetComponent<Player>();
            spawnPoint = playerScript.spawnPoint;
            spawnPointObject = GameObject.Find(spawnPoint);

        if (player != null && playerScript.goToSpawnPoint && spawnPointObject != null)
            {
                    player.transform.position = spawnPointObject.transform.position;
                    playerScript.goToSpawnPoint = false;
            }

        backgroundManagerScript.ChangeRegion(regionNow);
    }
}