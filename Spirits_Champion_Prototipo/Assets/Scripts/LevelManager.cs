using System.Collections;
using System.Collections.Generic;
using System.Security;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private string nextScene; // Proxima cena a ser carregada
    [SerializeField] private string[] unloadScene; // Cenas antigas para dar unload

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player Box") // Verifica se o colisor está colidindo com o player e se a próxima cena não está carregada
        {
            if (!SceneManager.GetSceneByName(nextScene).isLoaded)
            {
                SceneManager.LoadSceneAsync(nextScene, LoadSceneMode.Additive); // Carrega a próxima cena

                for (int i = 0; i < unloadScene.Length; i++)
                {
                    if (SceneManager.GetSceneByName(unloadScene[i]).isLoaded) // Verifica se as cenas antigas estão carregadas
                    {
                        SceneManager.UnloadSceneAsync(unloadScene[i]); // Da unload nas cenas antigas
                    }
                }
            }
        }
    }
}