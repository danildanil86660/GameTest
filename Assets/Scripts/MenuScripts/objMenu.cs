using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objMenu : MonoBehaviour {
    public static GameObject menuSetting;
    public static GameObject menuGallry;
    public static GameObject menuShop;
    public static GameObject menuOffice;
    public static GameObject statusResurses;
    public static int flagIndexHous = -1;

	// Use this for initialization
	void Start () {
        menuOffice = GameObject.Find("myMenu");
        menuSetting = GameObject.Find("menuSetting");
        menuGallry = GameObject.Find("menuGallery");
        statusResurses = GameObject.Find("resources");
        menuSetting.SetActive(false);
        menuGallry.SetActive(false);
        objGame.startResurse();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
