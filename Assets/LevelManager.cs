using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public void Esey()
    {
        GameManager.level = GameManager.Level.esey;
    }
    public void Normal()
    {
        GameManager.level = GameManager.Level.normal;
    }
    public void Hard()
    {
        GameManager.level = GameManager.Level.hard;
    }
}
