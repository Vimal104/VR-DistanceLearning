using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowNotes : MonoBehaviour
{
    public TMPro.TextMeshPro addNotes;

    void Start()
    {
        addNotes = GetComponent<TMPro.TextMeshPro>();
        addNotes.SetText(GlobalScript.Instance.notes);
    }
}
