using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenelopeSorting : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSortingLayer();
    }

    private void UpdateSortingLayer()
    {
        if (transform.position.y > player.position.y)
        {
            spriteRenderer.sortingLayerID = SortingLayer.layers[2].id;
        }
        else
        {
            spriteRenderer.sortingLayerID = SortingLayer.layers[4].id;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
