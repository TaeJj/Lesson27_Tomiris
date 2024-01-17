using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyBubbleSorting : MonoBehaviour
{
    public GameObject[] objectsArray;
    public float distanceBetweenObjects = 1f;
    private int[] originalOrder;

    void Start()
    {
        SaveOriginalOrder();

    }

    public void BubbleSort()
    {
        int n = objectsArray.Length;
        bool swapped;

        do
        {
            swapped = false;

            for (int i = 1; i < n; i++)
            {
                GameObject temp;

                if (objectsArray[i - 1].transform.localScale.x > objectsArray[i].transform.localScale.x)
                {
                    temp = objectsArray[i - 1];
                    objectsArray[i - 1] = objectsArray[i];
                    objectsArray[i] = temp;

                    swapped = true;
                }
            }

            n--;
        }
        while (swapped);

        VisualizeSortedObjects();
    }

    void VisualizeSortedObjects()
    {
        for (int i = 0; i < objectsArray.Length; i++)
        {
           
            objectsArray[i].transform.position = new Vector3(i * distanceBetweenObjects, objectsArray[i].transform.position.y, 0);
        }
    }

    void SaveOriginalOrder()
    {
        originalOrder = new int[objectsArray.Length];
        for (int i = 0; i < objectsArray.Length; i++)
        {
            originalOrder[i] = i;
        }
    }

}


