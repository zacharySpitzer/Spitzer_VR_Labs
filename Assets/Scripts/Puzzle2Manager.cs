using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2Manager : MonoBehaviour
{

    public Puzzle2triggers KeyHolderblue, KeyHolderRed, KeyHolderPurple, keyHolderGreen;
    public GameObject uiWin;
    public GameObject door;
    private Vector3 Positions,startPos;
    public float timer = 5f;
    // Start is called before the first frame update
    void Start()
    {
       
        Positions = door.transform.position;
        startPos = Positions;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {

            uiWin.SetActive(false);
            timer = 5f;
        }
        timer -= Time.deltaTime;


        if (KeyHolderblue.solved && KeyHolderPurple.solved && KeyHolderRed.solved && keyHolderGreen.solved == true)
        {
            Debug.Log("we made it here");
            Positions.x = -3;
            door.transform.position = Positions;
            uiWin.SetActive(true);
        }
       else
        {
            door.transform.position = startPos;
        }
        
    }
}
