using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SortButton : MonoBehaviour
{
    public DummyBubbleSorting sorter;

    private void Start()
    {
        
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(OnClick);
        }
    }

    private void OnClick()
    {
        
        if (sorter != null)
        {
            sorter.BubbleSort();
        }
    }
}
