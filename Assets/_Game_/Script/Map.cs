using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            Vector2 size = sr.bounds.size;
            Debug.Log("Ukuran Map dalam World Units: " + size);
        }
    }
}
