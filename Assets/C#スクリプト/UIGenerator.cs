using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGenerator : MonoBehaviour
{
    public GameObject TryAgainPrefab;
    public GameObject GoTitlePrefab;
    public GameObject UnchiHundaPrefab;
    GameObject director;
    [SerializeField] GameObject hip;
    [SerializeField] GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        this.director = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateUI()
    {

        GameObject tryAgain = Instantiate(TryAgainPrefab) as GameObject;
        GameObject goTitle = Instantiate(GoTitlePrefab) as GameObject;


        tryAgain.transform.SetParent(canvas.transform, false);
        goTitle.transform.SetParent(canvas.transform, false);

    }

    public void GenerateUnchiUI(float unchiTime)
    {
        GameObject unchiUI = Instantiate(UnchiHundaPrefab) as GameObject;
        StartCoroutine(DelayMethod(unchiTime, unchiUI.gameObject));
    }

    IEnumerator DelayMethod(float delay, GameObject gameObject)
    {
        //delayïbë“Ç¬
        yield return new WaitForSeconds(delay);
        //Ç§ÇÒÇøì•ÇÒÇæí ímÇè¡Ç∑
        Destroy(gameObject);
    }

}
