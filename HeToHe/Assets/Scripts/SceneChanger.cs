using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
    public void ToStandBy()
    {
        SceneManager.LoadScene("StandByScene");
    }
    public void ToGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void ToResult()
    {
        SceneManager.LoadScene("ResultScene");
    }
}
