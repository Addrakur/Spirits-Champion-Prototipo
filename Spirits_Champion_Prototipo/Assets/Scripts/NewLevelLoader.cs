using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevelLoader : MonoBehaviour
{
    [SerializeField] private string nextScene;

    public string nextRegion;
    private float sceneLoadDelay = 0.5f;
    private Player playerScript;
    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player Box");
        playerScript = player.GetComponent<Player>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player Box")
        {
            playerScript.goToSpawnPoint = true;
            GameObject backgroundManager = GameObject.Find("Background Manager");
            backgroundManager.SendMessage("ChangeRegion", nextRegion);
            GameObject player = GameObject.Find("Player Box");
            player.SendMessage("SpawnPoint", "Spawn Point " + nextScene);
            StartCoroutine(SceneLoad());
        }
    }

    IEnumerator SceneLoad()
    {
        yield return new WaitForSeconds(sceneLoadDelay);
        SceneManager.LoadScene(nextScene);
    }
}