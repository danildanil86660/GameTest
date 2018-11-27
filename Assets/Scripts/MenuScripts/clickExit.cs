using UnityEngine;
using UnityEngine.EventSystems;

public class clickExit : MonoBehaviour, IPointerClickHandler {
    public void OnPointerClick(PointerEventData eventData)
    {
        Application.Quit();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
