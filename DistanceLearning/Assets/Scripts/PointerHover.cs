using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;


public class PointerHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{

    private Text titles;

    void Start()
    {
        print("HELLOOO!");
        titles = GetComponent<Text>();
        print(titles);
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        OnHoverEnter();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        OnHoverExit();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick();
    }

    void OnHoverEnter()
    {
        titles.color = Color.cyan;
        print("ENTER");
    }

    void OnHoverExit()
    {
        titles.color = Color.white;
        print("EXIT");
    }

    void OnClick()
    {
        //titles.color = Color.cyan;
        titles.color = Color.yellow;
        print("CLICKED!!!!");
    }

}
