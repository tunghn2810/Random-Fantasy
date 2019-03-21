﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Status : MonoBehaviour
{
    public static Status status { get; set; }

    Dictionary<string, int> envStatus = new Dictionary<string, int>();
    public Dictionary<string, int> EnvStatus { get => envStatus; set => envStatus = value; }

    Dictionary<string, int> playerStatus = new Dictionary<string, int>();
    public Dictionary<string, int> PlayerStatus { get => playerStatus; set => playerStatus = value; }

    void Awake()
    {
        if (status == null)
        {
            status = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        //Populate the dictionary
        envStatus.Add("ShopKeeper", 0);
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "PotionStore")
        {
            if(envStatus["ShopKeeper"] == 0)
            {
                ActionManager.actionManager.OtherCharacter.transform.position = new Vector3(13.0f, -0.6f, 94);
            }
            else
            {
                ActionManager.actionManager.OtherCharacter.transform.position = new Vector3(6.0f, -0.6f, 94);
            }
        }
    }
}
