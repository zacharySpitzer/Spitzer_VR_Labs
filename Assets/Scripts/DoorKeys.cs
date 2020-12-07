using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKeys : MonoBehaviour
{
    public GameObject theKey;
    public GameObject Door;
    public Door doorthings;
    public GameObject uiWin1;
    public float timer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {

            uiWin1.SetActive(false);
            timer = 5f;
        }
        timer -= Time.deltaTime;

    }
    public void OnTriggerEnter(Collider other)
    {

        Keys keyObj = other.GetComponent<Keys>();
        if(keyObj)
        {
            uiWin1.SetActive(true);
            Debug.Log("correct keycongrats door should move now ");
            doorthings.button1Door();
        }
        else
        {
            Debug.Log("wrong key no key crud");
        }
    }
}
