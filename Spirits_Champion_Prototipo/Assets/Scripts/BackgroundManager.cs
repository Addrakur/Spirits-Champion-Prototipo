using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField] private GameObject[] backgrounds; // Array com todos os backgrounds
    public string regiao; // Regiao atual do jogo

    private void Start()
    {
        if(regiao == null)
        {
            regiao = "Village";
        }
    }

    public void ChangeRegion(string newRegion)
    {
        regiao = newRegion;

        switch (regiao)
        {
            case "Village":
                for (int i = 0; i < backgrounds.Length; i++) // Verifica se a regiao atual e a vila
                {
                    if (backgrounds[i].name == "BG Village")
                    {
                        backgrounds[i].SetActive(true); // Ativa o BG da vila
                    }
                    else
                    {
                        backgrounds[i].SetActive(false); // Desativa qualquer outro BG
                    }
                }
                break;

            case "Forest":
                for (int i = 0; i < backgrounds.Length; i++)
                {
                    if (backgrounds[i].name == "BG Forest")
                    {
                        backgrounds[i].SetActive(true);
                    }
                    else
                    {
                        backgrounds[i].SetActive(false);
                    }
                }
                break;
        }
    }

}