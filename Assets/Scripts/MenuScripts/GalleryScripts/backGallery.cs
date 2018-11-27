using UnityEngine;
using UnityEngine.EventSystems;

public class backGallery : MonoBehaviour, IPointerClickHandler {
    public void OnPointerClick(PointerEventData eventData)
    {
        objMenu.menuGallry.SetActive(false);
        objMenu.menuOffice.SetActive(true);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
