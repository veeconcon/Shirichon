using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YakiimoGenerator : MonoBehaviour
{
    public GameObject yakiimoPrefab;
    GameObject mainCamera;
    float span = 10.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.mainCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(yakiimoPrefab) as GameObject;
            float px = Random.Range(-15.0f, 15.0f);
            go.transform.position = new Vector3(px, this.mainCamera.transform.position.y + 30.0f, 0);

        }
    }
}
