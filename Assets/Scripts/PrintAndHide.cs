using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int count;
    private int random;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        count = 3;
        random = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        Debug.Log(gameObject.name + ":" + count);
        if(gameObject.tag == "Red" && count == 100)
        {
            gameObject.SetActive(false);
        }
        else if(gameObject.tag == "Blue" && count == random)
        {
            rend.enabled = false;
        }
    }
}
