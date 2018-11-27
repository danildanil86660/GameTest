using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class buttonSell : MonoBehaviour, IPointerClickHandler {

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("OfficeMenu");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
