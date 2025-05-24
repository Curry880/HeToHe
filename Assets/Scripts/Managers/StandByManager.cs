using UnityEngine;
using UnityEngine.UI;

public class StandByManager : MonoBehaviour
{
    [SerializeField] 
    private Text countText;

    private float count;

    SceneController sceneController = new SceneController();

    [SerializeField]
    private SEManager seManager;

    private bool seFlag;

    void Start()
    {
        count = 5;
        seFlag = false;
        countText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (count <= 0)
        {
            sceneController.ToGame();
            return;
        }

        count -= Time.deltaTime;
        if(count < 3.5)
        {
            if(seFlag == false)
            {
                seManager.PlayCountDownSE();
                seFlag = true;
            }
            countText.text = count.ToString("f0");
        }
    }
}
