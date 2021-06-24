using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour
{
    public GameObject hip;
    float speedLateral;
    bool push = false;


    // Start is called before the first frame update
    void Start()
    {
        speedLateral = this.hip.GetComponent<HipController>().speedLateral;
    }

    // Update is called once per frame
    void Update()
    {
        if (push)
        {
            MoveLeft();
        }
    }

    public void PushDown()
    {
        push = true;
    }

    public void PushUp()
    {
        push = false;
    }

    //ƒ{ƒ^ƒ“‚ð‰Ÿ‚µ‚½Žž‚Ìˆ—
    public void MoveLeft()
    {
        if (this.hip != null)
        {
            if (this.hip.transform.position.x > -11.0f)
            {
                this.hip.transform.position += Vector3.left * speedLateral * Time.deltaTime;
            }
        }
    }
}
