using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

//[RequireComponent(typeof(TextMesh))]
public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{

    private string titles;
    TextMesh mesh;

    void Start()
    {
        print("HELLOOO!"); //Testing
        titles = GetComponent<TextMesh>().text;
        print(titles);  //working only for 1st title (?) 
            //or is it because all of the titles are enabled at once that it's not printing? ----->>>>> Not likely
        mesh = GetComponent<TextMesh>();
    }


    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        OnHoverEnter();
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        OnHoverExit();
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        OnClick();
    }

    void OnHoverEnter()
    {
        mesh.color = Color.cyan;
        print("ENTERED");
    }

    void OnHoverExit()
    {
        mesh.color = Color.white;
        print("EXIT");
    }

    void OnClick()
    {
        //titles.color = Color.cyan;
        mesh.color = Color.yellow;
        print("CLICKED!!!!");
    }

}
