using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countText;
    float count = 3;

    [SerializeField] SceneChanger sceneChanger;

    void Start()
    {
        count = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (count <= 0)
        {
            sceneChanger.ToGame();
        }

        countText.text = count.ToString("f0");
        count -= Time.deltaTime;
        

        
    }
}
