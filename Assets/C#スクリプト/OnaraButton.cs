using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnaraButton : MonoBehaviour
{
    GameObject onaraGenerator;
    GameObject director;
    public GameObject hip;

    // Start is called before the first frame update
    void Start()
    {
        this.onaraGenerator = GameObject.Find("OnaraGenerator");
        this.director = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.hip != null && this.director.GetComponent<GameDirector>().yakiimoNum > 0)
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            GetComponent<Button>().interactable = false;
        }
    }

    public void OnClickButton()
    {
        this.onaraGenerator.GetComponent<OnaraGenerator>().GenerateOnara();
    }
}
