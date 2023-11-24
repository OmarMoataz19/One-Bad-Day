using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChoicesUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    Sprite original;
    public Sprite backgroundImage;
    public TextMeshProUGUI text;
    public TMP_FontAsset ultraLight;
    public TMP_FontAsset medium;

    void Start()
    {
        original = GetComponent<Image>().sprite;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ReturnToNormal();
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        GetComponent<Image>().sprite = backgroundImage;
        text.color = Color.black;
        text.font = medium;
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        ReturnToNormal();
    }

    void ReturnToNormal() {
        GetComponent<Image>().sprite = original;
        text.color = Color.white;
        text.font = ultraLight;
    }
}
