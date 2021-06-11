using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float speed = 50.0f;
    GameObject director;
    GameObject mainCamera;
    GameObject uiGenerator;

    // Start is called before the first frame update
    void Start()
    {
        this.director = GameObject.Find("GameDirector");
        this.mainCamera = GameObject.Find("Main Camera");
        this.uiGenerator = GameObject.Find("UIGenerator");
    }

    // Update is called once per frame
    void Update()
    {
        //–î‚ª‰º‚©‚çã‚Öã¸
        this.transform.position += Vector3.up * this.speed * Time.deltaTime;

        //‰æ–ÊŠO‚Éo‚½‚çÁŽ¸
        if (this.transform.position.y - this.mainCamera.transform.position.y > 30.0f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "hip")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            this.director.GetComponent<GameDirector>().ShowGameOver();
            this.uiGenerator.GetComponent<UIGenerator>().GenerateUI();
        }
    }
}
