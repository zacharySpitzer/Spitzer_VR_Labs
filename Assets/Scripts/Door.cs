using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
    public Vector3 positionme;
    public Vector3 startpos;
    public float timer = 10f;
    // Start is called before the first frame update
    void Start()
    {
        startpos = door.transform.position;
        positionme = door.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<=0)
        {
           
            door.transform.position = startpos;
            timer = 10f;
        }
        timer -= Time.deltaTime;
    }
    public void button1Door()
    {
        timer = 10f;
       // door.SetActive(false);
       
        positionme.x = -3;
        door.transform.position = positionme;
    }
}
