using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooTrapSystem : MonoBehaviour
{
    GameObject mainCamera;
    GameObject uiGenerator;
    float unchiTime = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.mainCamera = GameObject.Find("Main Camera");
        this.uiGenerator = GameObject.Find("UIGenerator");
    }

    // Update is called once per frame
    void Update()
    {

        //画面外に出たら消す
        Vector2 p1 = this.transform.position;
        Vector2 p2 = this.mainCamera.transform.position;
        Vector2 dir = p1 - p2;
        if (dir.y < -30.0f)
        {
            Destroy(this.gameObject);
        }
    }

    //お尻との当たり判定
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "hip")
        {
            this.mainCamera.GetComponent<CameraScroller>().speed = 2.0f;
            this.mainCamera.GetComponent<CameraScroller>().UnchiTimeCount(this.unchiTime);
            Destroy(this.gameObject);

            //unchiTimeの間ビックリマーク表示
            this.uiGenerator.GetComponent<UIGenerator>().GenerateUnchiUI(this.unchiTime);
        }
    }

}
