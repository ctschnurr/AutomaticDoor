using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{    
    public int speed = 1;

    private Vector3 goUp = new Vector3(0, 0, 0);
    private Vector3 startPos = new Vector3(0, 0, 0);

    public bool up = false;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        goUp = startPos;
        goUp.y = startPos.y + 5;

    }

    // Update is called once per frame
    void Update()
    {
        if (up == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, goUp, Time.deltaTime * speed);

        }

        if (up == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPos, Time.deltaTime * speed);

        }
    }
}
