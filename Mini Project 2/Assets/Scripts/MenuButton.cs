using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public Sprite backgroundImage;
    public TextMeshProUGUI text;

    public void OnPointerClick(PointerEventData eventData)
    {
        ReturnToNormal();
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        GetComponent<Image>().sprite = backgroundImage;
        text.color = Color.white;
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        ReturnToNormal();
    }

    void ReturnToNormal() {
        GetComponent<Image>().sprite = null;
        switch(text.text) {
            case "Start": text.color = Color.black; break;
            case "Credits": text.color = new Color(17.0f/255.0f, 112.0f/255.0f, 190.0f/255.0f); break;
            case "Quit": text.color = new Color(178.0f/255.0f, 33.0f/255.0f, 33.0f/255.0f); break;
            default:  text.color = Color.black; break;
        }
    }
}
