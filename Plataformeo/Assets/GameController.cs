using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
   Vector2 checkPointPos;
    private void Start()
    {
        checkPointPos = transform.position;
    }

    void respawn()
    {
        transform.position = checkPointPos;
    }
}
