using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class click : MonoBehaviour, IPointerClickHandler {
    private GameObject[] hous;
    private GameObject sellButt;
    private List<GameObject> housList;
    private Text lable;
    private static int iteation;
    int i;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (iteation < hous.Length)
        {
            housList[iteation].GetComponent<Renderer>().enabled = true;
            lable.text = housList[iteation].name;
            iteation++;
        }
        else
        {
            iteation = 0;
        }
        if (iteation == 0)
        {
            sellButt.SetActive(true);
        }
    }
    private void Awake()
    {
        hous = GameObject.FindGameObjectsWithTag("buildMaterial");
        housList = new List<GameObject>(hous);
        housList = housList.OrderBy(value => value.name).ToList();//сортировать по имени объекта
        iteation = 0;
    }

    // Use this for initialization
    void Start () {
        sellButt = GameObject.Find("sellButtion");
        lable = GameObject.Find("BrickText").GetComponent<Text>();
        sellButt.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
