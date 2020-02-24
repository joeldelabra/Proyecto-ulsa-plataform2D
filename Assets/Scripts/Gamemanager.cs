﻿  
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platform2DUtils.MemorySystem;
//using UnityEngine.SceneManagement;


public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;
    [SerializeField]
    Score score;

    public Score Score { get => score; }

    public GameData gameData { get; set; }

    void Awake()
    {
        if(instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            //gameData = MemorySystem.LoadData();
            //Debug.Log(gameData.Player);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void Save()
    {
        MemorySystem.SaveData(gameData);
    }
    
    public void Load()
    {
        gameData = MemorySystem.LoadData();
    }
    void Start()
    {
        Load();
        Debug.Log(gameData.PlayerPos);

        //int scene = SceneManager.GetActiveScene().buildIndex;
       //score.gameObject.SetActive(scene > 0);
    }
}
