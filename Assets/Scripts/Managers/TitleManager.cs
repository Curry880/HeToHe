using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
    [SerializeField]
    private GameObject main;
    [SerializeField]
    private GameObject setting;

    [SerializeField]
    private List<Font> fonts;

    [SerializeField]
    private Text hiraSample;
    [SerializeField]
    private Text kataSample;

    SceneController sceneController = new SceneController();

    private void Start()
    {
        main.SetActive(true);
        setting.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void OnClickedEasy()
    {
        GameManager.currentLevel = Level.Esey;
        sceneController.ToStandBy();
    }

    public void OnClickedNormal()
    {
        GameManager.currentLevel = Level.Normal;
        sceneController.ToStandBy();
    }

    public void OnClickedHard()
    {
        GameManager.currentLevel = Level.Hard;
        sceneController.ToStandBy();
    }

    public void OnClickedGear()
    {
        main.SetActive(false);
        setting.SetActive(true);
    }

    public void OnClickedReturn()
    {
        main.SetActive(true);
        setting.SetActive(false);
    }

    public void OnClickedGothic()
    {
        hiraSample.font = fonts[0];
        kataSample.font = fonts[0];
        GameManager.currentFont = fonts[0];
    }

    public void OnClickedMintyo()
    {
        hiraSample.font = fonts[1];
        kataSample.font = fonts[1];
        GameManager.currentFont = fonts[1];
    }

    public void OnClickedHude()
    {
        hiraSample.font = fonts[2];
        kataSample.font = fonts[2];
        GameManager.currentFont = fonts[2];
    }
}
