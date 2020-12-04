using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKeys : MonoBehaviour
{
    public GameObject theKey;
    public GameObject Door;
    public Door doorthings;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {

        Keys keyObj = other.GetComponent<Keys>();
        if(keyObj)
        {
            Debug.Log("correct keycongrats door should move now ");
            doorthings.button1Door();
        }
        else
        {
            Debug.Log("wrong key no key crud");
        }
    }
}
