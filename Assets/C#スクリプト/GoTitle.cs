using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTitle : MonoBehaviour
{

    //追加した
    //ボタンを押した時の処理
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}