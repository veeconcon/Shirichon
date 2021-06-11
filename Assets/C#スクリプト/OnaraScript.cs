using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnaraScript : MonoBehaviour
{
    float delta = 0;
    float span = 2.0f;
   
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "arrow")
        {
            Destroy(collision.gameObject);
        }
    }

}
