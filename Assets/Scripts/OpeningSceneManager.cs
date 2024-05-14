using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpeningSceneManager : MonoBehaviour
{
    public InputField InputName;
    
    public Button JoinButton;       // "Join" ��ư
    public Button SelectCharButton; // ĳ���� ���� ��ư
    public Button PenguinButton;    // ĳ���� ��� ���� ��ư
    public Button GreenButton;      // ĳ���� 2 ���� ��ư

    public Sprite SpritePenguin;
    public Sprite SpriteGreen;

    public SpriteRenderer characterRenderer;

    public GameObject CharacterBox; // ĳ���� â
    public GameObject SelectBox;    // ĳ���� ���� â
    public GameObject NameBox;      // �̸� �Է� �ڽ�
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

    //  "Join" ���� �� ���� �� �̵�
    public void NextScene()
    {
        if (InputName.text.Length >= 2)
        {
            PlayerPrefs.SetString("Name", InputName.text);
            SceneManager.LoadScene("MainScene");
        }
        else
            Debug.Log("�̸��� ���̴� 2 ~ 10 �����Դϴ�.");
    }

    // ĳ���� â Ŭ�� �� ĳ���� ���� â Ȱ��ȭ
    public void ShowSelectMenu()
    {
        SelectBox.SetActive(true);
        NameBox.SetActive(false);
        CharacterBox.SetActive(false);
    }

    // ��� ĳ���� ���� �� ĳ���� â�� ��� ĳ���� ��������Ʈ �ݿ�
    public void SelectPenguin()
    {
        SelectBox.SetActive(false);
        NameBox.SetActive(true);
        CharacterBox.SetActive(true);
        characterRenderer.sprite = SpritePenguin;
    }

    // ~ Green ĳ���� ��������Ʈ �ݿ�
    public void SelectGreen()
    {
        SelectBox.SetActive(false);
        NameBox.SetActive(true);
        CharacterBox.SetActive(true);
        characterRenderer.sprite = SpriteGreen;
    }
}
