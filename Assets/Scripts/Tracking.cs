using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking : MonoBehaviour
{
    public float Speed;
    public GameObject GameObject;
    public GameObject border;//граница   
    public float marginY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(GameObject.transform.position.x, GameObject.transform.position.y+marginY, transform.position.z),Speed*Time.deltaTime);
    }
}
