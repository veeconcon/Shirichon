using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    GameObject director;
    public GameObject arrowPrefab;
    public GameObject mainCamera;
    float span;
    float delta = 0;
    int scoreNum;


    // Start is called before the first frame update
    
    IEnumerator Start()
    {
        //スタートから一秒間は矢の生成をしない
        enabled = false;
        yield return new WaitForSeconds(1);
        enabled = true;

        //矢の生成スパンの初期化
        this.span = 0.6f;

        //監督オブジェクトの読み込み
        this.director = GameObject.Find("GameDirector");

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;

            //指をランダムの位置に生成
            float px = Random.Range(-11.0f, 11.0f);

            //お尻のy座標を取得
            Vector3 cameraPos = this.mainCamera.transform.position;

            //指の位置指定
            go.transform.position = new Vector3(px, cameraPos.y - 30.0f, 0);

        }

        this.scoreNum = this.director.GetComponent<GameDirector>().scoreNum;

        if (700 <= this.scoreNum & this.scoreNum < 1400)
        {
            this.span = 0.5f;
        }

        if (1400 <= this.scoreNum & this.scoreNum < 2100)
        {
            this.span = 0.4f;
        }

        if (2100 <= this.scoreNum )
        {
            this.span = 0.3f;
        }
    }
}
