using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitToSafeArea : MonoBehaviour
{
    public RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = (RectTransform) transform;
        rectTransform.anchorMin = rectTransform.anchorMax = rectTransform.pivot = Vector2.up;

    }
    
    void Update()
    {
        Rect safeArea = Screen.safeArea;
        rectTransform.anchoredPosition = safeArea.position;
        rectTransform.sizeDelta = safeArea.size - safeArea.position;
    }
}
