using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3Manager : MonoBehaviour
{
    public Puzzle2triggers YellowKeyPedistol, greyKeyPedistol, aquaKeyPedistol;

    public GameObject door;
    private Vector3 Positions, startPos;

    public GameObject uiWin3;
    public float timer = 5f;
    // Start is called before the first frame update
    
    // Update is called once per frame
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

            uiWin3.SetActive(false);
            timer = 5f;
        }
        timer -= Time.deltaTime;
        if (YellowKeyPedistol.solved && greyKeyPedistol.solved && aquaKeyPedistol.solved == true)
        {
            uiWin3.SetActive(true);
            Debug.Log("we made it here");
            Positions.x = -3;
            door.transform.position = Positions;
        }
        else
        {
            door.transform.position = startPos;
        }
    }
}
