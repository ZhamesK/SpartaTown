using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpeningSceneManager : MonoBehaviour
{
    public InputField InputName;
    
    public Button JoinButton;       // "Join" 버튼
    public Button SelectCharButton; // 캐릭터 선택 버튼
    public Button PenguinButton;    // 캐릭터 펭귄 선택 버튼
    public Button GreenButton;      // 캐릭터 2 선택 버튼

    public Sprite SpritePenguin;
    public Sprite SpriteGreen;

    public SpriteRenderer characterRenderer;

    public GameObject CharacterBox; // 캐릭터 창
    public GameObject SelectBox;    // 캐릭터 선택 창
    public GameObject NameBox;      // 이름 입력 박스
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        JoinButton.onClick.AddListener(NextScene);
        SelectCharButton.onClick.AddListener(ShowSelectMenu);
        PenguinButton.onClick.AddListener(SelectPenguin);
        GreenButton.onClick.AddListener(SelectGreen);

    }

    //  "Join" 누른 후 다음 씬 이동
    public void NextScene()
    {
        if (InputName.text.Length >= 2)
        {
            PlayerPrefs.SetString("Name", InputName.text);
            SceneManager.LoadScene("MainScene");
        }
        else
            Debug.Log("이름의 길이는 2 ~ 10 사이입니다.");
    }

    // 캐릭터 창 클릭 후 캐릭터 선택 창 활성화
    public void ShowSelectMenu()
    {
        SelectBox.SetActive(true);
        NameBox.SetActive(false);
        CharacterBox.SetActive(false);
    }

    // 펭귄 캐릭터 선택 후 캐릭터 창에 펭귄 캐릭터 스프라이트 반영
    public void SelectPenguin()
    {
        SelectBox.SetActive(false);
        NameBox.SetActive(true);
        CharacterBox.SetActive(true);
        characterRenderer.sprite = SpritePenguin;
    }

    // ~ Green 캐릭터 스프라이트 반영
    public void SelectGreen()
    {
        SelectBox.SetActive(false);
        NameBox.SetActive(true);
        CharacterBox.SetActive(true);
        characterRenderer.sprite = SpriteGreen;
    }
}
