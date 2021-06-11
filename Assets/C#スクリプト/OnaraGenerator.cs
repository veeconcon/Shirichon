using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnaraGenerator : MonoBehaviour
{
    public GameObject OnaraPrefab;
    GameObject director;
    [SerializeField] GameObject hip;

    // Start is called before the first frame update
    void Start()
    {
        this.director = GameObject.Find("GameDirector");
    }

    public void GenerateOnara()
    {
        //焼き芋のストックがある状態でおしりをタップするとおなら発動
        if (this.director.GetComponent<GameDirector>().yakiimoNum > 0)
        {
            this.director.GetComponent<GameDirector>().LoseYakiimo();
            GameObject onara = Instantiate(OnaraPrefab) as GameObject;
            onara.transform.position = new Vector3(this.hip.transform.position.x, this.hip.transform.position.y - 5.0f, 0);
        }
    }
}
