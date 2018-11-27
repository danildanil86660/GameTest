using UnityEngine;
using UnityEngine.EventSystems;

public class clickGallery : MonoBehaviour, IPointerClickHandler {
    public void OnPointerClick(PointerEventData eventData)
    {
        objMenu.menuGallry.SetActive(true);
        objMenu.menuOffice.SetActive(false);
        objMenu.statusResurses.SetActive(false);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
