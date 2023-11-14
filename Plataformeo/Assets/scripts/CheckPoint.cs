using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    [SerializeField] Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            collision.transform.position = spawnPoint.transform.position;

            print(otro.name + " toco " + name);

            Destroy(gameObject, 0.5f);
        }
    }

}
