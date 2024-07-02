using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickLast : MonoBehaviour
{
    public GameObject PanelD;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ClickLastTap()
    {
        PlayerPrefs.SetInt("last", 1);
        PanelD.SetActive(false);
        gameObject.SetActive(false);
        Debug.Log("Last on!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
