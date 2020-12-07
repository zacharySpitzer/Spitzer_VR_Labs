using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2triggers : MonoBehaviour
{
    public GameObject Me;
    
    // Start is called before the first frame update

    public bool solved;
    void Start()
    {
        solved = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {

     
        if (other.gameObject.tag == Me.tag )
        {
            Debug.Log("i was solved" + other.gameObject.tag);
            solved = true;
        }
        else
        {
            Debug.Log("wrong key no key crud");
        }

    }
   
}
