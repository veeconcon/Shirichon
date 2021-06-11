using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YakiimoCounter : MonoBehaviour
{
    GameObject director;
    GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        this.director = GameObject.Find("GameDirector");
        this.mainCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //âÊñ äOÇ…èoÇΩÇÁè¡Ç∑
        Vector2 p1 = this.transform.position;
        Vector2 p2 = this.mainCamera.transform.position;
        Vector2 dir = p1 - p2;
        if (dir.y < -30.0f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "hip")
        {
            this.director.GetComponent<GameDirector>().GetYakiimo();
            Destroy(this.gameObject);
        }
    }
}
