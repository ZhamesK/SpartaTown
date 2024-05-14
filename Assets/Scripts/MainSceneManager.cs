using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainSceneManager : MonoBehaviour
{
    public Text NameTxt;
    public TextMeshProUGUI TimeTxt;

    // Start is called before the first frame update
    void Start()
    {
        LoadName();
    }

    // Update is called once per frame
    void Update()
    {
        TimeTxt.text = GetCurrentTime();
    }

    public void LoadName()
    {
        if (PlayerPrefs.HasKey("Name"))
        {
            NameTxt.text = PlayerPrefs.GetString("Name");
        }
        else
        {
            Debug.Log("No Name");
        }
    }


    // 현재 시간
    public string GetCurrentTime()
    {
        return DateTime.Now.ToString("HH:mm:ss");
    }
}
