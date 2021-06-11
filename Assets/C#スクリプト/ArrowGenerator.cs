using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    GameObject director;
    public GameObject arrowPrefab;
    float span;
    float delta = 0;
    int scoreNum;


    // Start is called before the first frame update
    
    IEnumerator Start()
    {
        //�X�^�[�g�����b�Ԃ͖�̐��������Ȃ�
        enabled = false;
        yield return new WaitForSeconds(1);
        enabled = true;

        //��̐����X�p���̏�����
        this.span = 0.6f;

        //�ēI�u�W�F�N�g�̓ǂݍ���
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
            float px = Random.Range(-15.0f, 15.0f);
            go.transform.position = new Vector3(px, 0, 0);

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
