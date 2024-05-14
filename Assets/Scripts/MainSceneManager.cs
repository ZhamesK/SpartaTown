using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainSceneManager : MonoBehaviour
{
    public InputField InputChangedName;

    public Button ChangeNameUIBttn;
    public Button ConfirmBttn;

    public GameObject ChangeNameUI;

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
        ConfirmBttn.onClick.AddListener(ChangeName);
        ChangeNameUIBttn.onClick.AddListener(CallChangeNameUI);
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


    // ���� �ð�
    public string GetCurrentTime()
    {
        return DateTime.Now.ToString("HH:mm:ss");
    }

    public void CallChangeNameUI()
    {
        ChangeNameUI.SetActive(true);
    }

    public void ChangeName()
    {
        NameTxt.text = InputChangedName.text;
        ChangeNameUI.SetActive(false);
    }
}
