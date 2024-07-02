using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ObjOff()
    {
        gameObject.SetActive(false);
        Debug.Log("Gameobject off");
    } 
    // Update is called once per frame
    void Update()
    {
        
    }
}
