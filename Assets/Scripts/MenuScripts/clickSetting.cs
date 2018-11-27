using UnityEngine;
using UnityEngine.EventSystems;

public class clickSetting : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        objMenu.menuOffice.SetActive(false);
        objMenu.menuSetting.SetActive(true);
        objMenu.statusResurses.SetActive(false);

    }

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
