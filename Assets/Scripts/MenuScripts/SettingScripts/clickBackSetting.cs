using UnityEngine;
using UnityEngine.EventSystems;

public class clickBackSetting : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        objMenu.menuSetting.SetActive(false);
        objMenu.menuOffice.SetActive(true);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
