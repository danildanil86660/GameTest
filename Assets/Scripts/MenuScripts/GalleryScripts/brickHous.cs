using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class brickHous : MonoBehaviour, IPointerClickHandler {
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("Game");
        objMenu.flagIndexHous = 1;
        objGame.setResurse("gold", 100);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
