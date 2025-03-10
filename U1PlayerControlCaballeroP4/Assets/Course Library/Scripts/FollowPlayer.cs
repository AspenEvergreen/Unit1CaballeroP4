using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            offset = new Vector3(0, 2, 1);
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            offset = new Vector3(0, 5, -7);
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            offset = new Vector3(0, 5, -15);
        }
    }
}
