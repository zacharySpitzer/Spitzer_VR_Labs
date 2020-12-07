using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle3 : MonoBehaviour
{
    public float i = 0f;
    public GameObject ChangeObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        ChangeObject = other.gameObject;
        
    }

    public void ChangeMe()
    {
        Debug.Log("change me Called");
        if(i>=7)
        {
            i = 0;
        }
        if(i == 0)
        {
            Debug.Log("change to grey");
            ChangeObject.transform.tag = "GreyCube";
            ChangeObject.GetComponent<Renderer>().material.SetColor("_Color", Color.gray);
        }
        if (i == 1)
        {
            ChangeObject.transform.tag = "redCube";
            ChangeObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
        if (i == 2)
        {
            ChangeObject.transform.tag = "AquaCube";
            ChangeObject.GetComponent<Renderer>().material.SetColor("_Color", Color.cyan);
        }
        if (i == 3)
        {
            ChangeObject.transform.tag = "Blue";
            ChangeObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
        }
        if (i == 4)
        {

            ChangeObject.transform.tag = "YellowCube";
            ChangeObject.GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
           
        }
        if (i == 5)
        {
            ChangeObject.transform.tag = "PuprleCube";
            
            ChangeObject.GetComponent<Renderer>().material.SetColor("_Color", Color.magenta);
        }
        if (i == 6)
        {
            ChangeObject.transform.tag = "GreenCube";
            ChangeObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        }



        i++;
    }
}
