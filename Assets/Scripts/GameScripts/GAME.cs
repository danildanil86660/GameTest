using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GAME : MonoBehaviour {
    public GameObject[] listOfHouses;

    //Добавляет нужный дом на сцену
    private void InstHous(int flagHous)
    {
        Instantiate(listOfHouses[flagHous], listOfHouses[flagHous].transform.position, listOfHouses[flagHous].transform.rotation);
    }

    private void Awake()
    {
        InstHous(objMenu.flagIndexHous);
    }

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}