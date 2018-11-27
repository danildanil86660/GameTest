using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class woodHous : MonoBehaviour, IPointerClickHandler {
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("Game");
        objMenu.flagIndexHous = 0;
        objGame.setResurse("gold", 10);
        objGame.setResurse("beam", 555);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
