using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Check()
    {
        if (PlayerPrefs.GetInt("last") == 1)
        {
            gameObject.SetActive(false);
            Debug.Log("Panel Off");
        }
    }
    // Update is called once per frame
    void Update()
    {
        Check();
    }
}
