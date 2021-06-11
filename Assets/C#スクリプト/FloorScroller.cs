using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScroller : MonoBehaviour
{
    GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        this.mainCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.up * this.mainCamera.GetComponent<CameraScroller>().speed * Time.deltaTime;
    }
}
