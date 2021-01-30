using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainsPositions : MonoBehaviour
{

    List<Vector3> positions = new List<Vector3>
    {
        new Vector3(-9.11f,4f,-44.2f),
        new Vector3(-73.75f,6.5f,-98.71f),
        new Vector3(-16.39f,-1.99f,4.77f),
        new Vector3(-15.15f,6.5f,-79.43f),
        new Vector3(3.9f,-2f,-2.5f),
        new Vector3(-84.7f,-1.33f,-4.7f),
        new Vector3(-167.5f,-2f,-97f),
        new Vector3(-141.5f,-2f,-214.9f),
        new Vector3(-171.8f,-2f,-263.9f),
        new Vector3(247f,-2f,-245.6f),
        new Vector3(319.28f,10.85f,-184.84f),
        new Vector3(182.3f,7f,-158.6f),
        new Vector3(234.71f,7f,-177f),
        new Vector3(111.1f,-1.8f,-158.1f),
        new Vector3(128.49f,3.01f,-135.68f),
        new Vector3(52.5f,-2.62f,-151.56f),
        new Vector3(26.8f,-3f,-125.51f),
        new Vector3(62.7f,-3.77f,-119.57f),
        new Vector3(72.23f,3.13f,-128.17f),
        new Vector3(92.14f,3.23f,-128.17f),
        new Vector3(229.42f,6.03f,-73.22f),
        new Vector3(252.7f,6.03f,-2.8f),
        new Vector3(278.8f,6.03f,-2.8f),
        new Vector3(13.7f,4.14f,-41.1f)
    };
    GameObject[] brains;


    void Start()
    {
        brains= GameObject.FindGameObjectsWithTag("Brain");
        System.Random rnd = new System.Random();
        foreach (GameObject brain in brains)
        {
            int no=positions.Count;
            int p = rnd.Next(0, no);
            brain.transform.localPosition = positions[p];
            positions.RemoveAt(p);
        }
    } 
}
