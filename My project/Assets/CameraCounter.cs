using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCounter : MonoBehaviour
{
    public GameObject player;
    public float playerPosition;
    public float cameraAngleX_offset;
    // Start is called before the first frame update
    void Start()
    {
       playerPosition = player.GetComponent<Transform>().position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
        playerPosition = player.GetComponent<Transform>().position.z;
        cameraAngleX_offset = playerPosition / 500;
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 newRotation = new Vector3(85f-cameraAngleX_offset, 0 , 0);
            transform.eulerAngles = newRotation;
            
        }
        
        
}
}
