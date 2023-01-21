using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TopTime : MonoBehaviour
{
    public TMP_Text largeText;
    void Start()
    {
        string time = System.DateTime.UtcNow.ToLocalTime().ToString("HH:mm");
        largeText.text = time;
    }
}
