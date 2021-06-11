using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenTransition : MonoBehaviour
{

    //’Ç‰Á‚µ‚½
    //ƒ{ƒ^ƒ“‚ğ‰Ÿ‚µ‚½‚Ìˆ—
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("GameScene");
    }
}
