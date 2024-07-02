using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBlock : MonoBehaviour
{
    public GameObject[] blocks;
    int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("last", 0);
    }
    public void GenerateN()
    {
        if (PlayerPrefs.GetInt("last") == 1)
        {
            // Активируем текущий блок
            blocks[num].gameObject.SetActive(true);

            // Получаем случайный индекс нового блока
            num = Random.Range(0, blocks.Length);
            Debug.Log("num = " + num);

            // Активируем новый случайный блок
            blocks[num].gameObject.SetActive(true);

            // Активируем всех дочерних объектов нового блока
            Transform[] allChildren = blocks[num].GetComponentsInChildren<Transform>(true);
            foreach (Transform child in allChildren)
            {
                child.gameObject.SetActive(true);
            }

            // Сбрасываем значение в PlayerPrefs
            PlayerPrefs.SetInt("last", 0);
            Debug.Log("Reseted");
        }
    }
    // Update is called once per frame
    void Update()
    {
        GenerateN();

        Debug.Log(PlayerPrefs.GetInt("last") + " = last");
        Debug.Log(blocks.Length + " = block length");
        Debug.Log(num + " random num");
    }
}
