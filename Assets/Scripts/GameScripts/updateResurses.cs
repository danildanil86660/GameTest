using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateResurses : MonoBehaviour {
    private Text[] lableResurse;
    
    // Use this for initialization
    void Start () {
        //Создание ссылок на все отображения ресурсов
        lableResurse = new Text[5] {
            GameObject.Find("goldText").GetComponent<Text>(),
            GameObject.Find("boardsText").GetComponent<Text>(),
            GameObject.Find("beamText").GetComponent<Text>(),
            GameObject.Find("bricksText").GetComponent<Text>(),
            GameObject.Find("glassText").GetComponent<Text>()
        };
    }
	
	// Update is called once per frame
	void Update () {
        //Обновление отображения ресурсов в реальном времени
        for(int i = 0; i < lableResurse.Length; i++)
        {
            lableResurse[i].text = objGame.getResurse(objGame.nameResurses[i]).ToString();
        }
	}
}
