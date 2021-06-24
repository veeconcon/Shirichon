using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnchiGenerator : MonoBehaviour
{
    public GameObject UnchiPrefab;
    GameObject mainCamera;
    float span = 5.124f;
    float delta = 2.381f;

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
            GameObject go = Instantiate(UnchiPrefab) as GameObject;
            float px = Random.Range(-11.0f, 11.0f);
            go.transform.position = new Vector3(px, this.mainCamera.transform.position.y + 30.0f, 0);

        }
    }
}
