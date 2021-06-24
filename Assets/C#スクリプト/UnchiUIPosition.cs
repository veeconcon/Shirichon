using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnchiUIPosition : MonoBehaviour
{
    GameObject hip;

    // Start is called before the first frame update
    void Start()
    {
        this.hip = GameObject.Find("Hip");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.hip != null)
        {
            Vector3 hipPosition = this.hip.transform.position;
            this.transform.position = new Vector3(hipPosition.x, hipPosition.y + 4.5f, hipPosition.z);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
