using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HipController : MonoBehaviour
{
    GameObject mainCamera;
    GameObject onaraGenerator;
    public float speedLateral = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.mainCamera = GameObject.Find("Main Camera");
        this.onaraGenerator = GameObject.Find("OnaraGenerator");
    }

    // Update is called once per frame
    void Update()
    {
        //カメラと同じスピードで強制スクロール
        this.transform.position += Vector3.up * this.mainCamera.GetComponent<CameraScroller>().speed * Time.deltaTime;

        //左移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.transform.position.x > -15.0f)
            {
                this.transform.position += Vector3.left * speedLateral * Time.deltaTime;

            }
        }

        //右移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.transform.position.x < 15.0f)
            {
                this.transform.position += Vector3.right * speedLateral * Time.deltaTime;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.onaraGenerator.GetComponent<OnaraGenerator>().GenerateOnara();
        }
    }


}
