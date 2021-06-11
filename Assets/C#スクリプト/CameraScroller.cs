using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroller : MonoBehaviour
{
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //カメラをスクロール
        this.transform.position += Vector3.up * this.speed * Time.deltaTime;
    }

    public void UnchiTimeCount(float unchiTime)
    {
        Invoke("ResetSpeed", unchiTime);
    }

    public void ResetSpeed()
    {
        this.speed = 10.0f;
    }

    public void StopCamera()
    {
        this.speed = 0.0f;
        CancelInvoke();
    }
}
