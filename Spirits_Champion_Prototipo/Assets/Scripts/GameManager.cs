using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Player playerScript;
    private GameObject player;
    private string spawnPoint;
    GameObject spawnPointObject;

    // Start is called before the first frame update
    void Start()
    {
            player = GameObject.Find("Player Box");
            playerScript = player.GetComponent<Player>();
            spawnPoint = playerScript.spawnPoint;
            spawnPointObject = GameObject.Find(spawnPoint);

        if (player != null && playerScript.goToSpawnPoint && spawnPointObject != null)
            {
                    player.transform.position = spawnPointObject.transform.position;
                    playerScript.goToSpawnPoint = false;
            }
    }

    private void Update()
    {

    }
}