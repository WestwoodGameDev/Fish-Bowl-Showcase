using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour
{

    public Transform cameraPosition;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = cameraPosition.position;

        //player.transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y, 0f);

    }
}
