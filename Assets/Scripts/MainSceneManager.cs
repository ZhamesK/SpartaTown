using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneManager : MonoBehaviour
{
    public Text NameTxt;

    // Start is called before the first frame update
    void Start()
    {
        LoadName();
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
