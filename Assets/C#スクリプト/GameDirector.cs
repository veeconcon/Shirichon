using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject gameOver;
    GameObject mainCamera;
    GameObject score;
    GameObject yakiimo;
    public int yakiimoNum;
    public int scoreNum;

    // Start is called before the first frame update
    void Start()
    {
        this.gameOver = GameObject.Find("GameOver");
        this.score = GameObject.Find("Score");
        this.yakiimo = GameObject.Find("YakiimoNum");
        this.mainCamera = GameObject.Find("Main Camera");
        this.yakiimoNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreNum = Mathf.FloorToInt((this.mainCamera.transform.position.y - 10) * 5);
        this.score.GetComponent<Text>().text = "Ç∑Ç±Ç†:" + scoreNum.ToString();

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("TitleScene");
        }
    }

    public void ShowGameOver()
    {
        this.gameOver.GetComponent<Text>().text = "Ç∞Å[ÇﬁÇ®Å[ÇŒÅ[\nÇ∑Ç±Ç†:" + scoreNum.ToString();
        this.mainCamera.GetComponent<CameraScroller>().StopCamera();
    }

    public void GetYakiimo()
    {
        yakiimoNum += 1;
        this.yakiimo.GetComponent<Text>().text = "Å~" + yakiimoNum.ToString();
    }

    public void LoseYakiimo()
    {
        yakiimoNum -= 1;
        this.yakiimo.GetComponent<Text>().text = "Å~" + yakiimoNum.ToString();
    }
}
