using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridController : MonoBehaviour
{
    [SerializeField] private Tilemap interactiveMap;
    [SerializeField] private Tile hoverTile;

    [SerializeField] private DialogueUIController dialogueUI;

    private Vector3Int previousMousePos = new Vector3Int();

    // Update is called once per frame
    void Update()
    {
        if (dialogueUI.IsOpen)
        {
            interactiveMap.SetTile(previousMousePos, null); // Remove old hoverTile
            return;
        }

        // Mouse over -> highlight tile
        Vector3Int mousePos = GetMousePosition();
        if (!mousePos.Equals(previousMousePos))
        {
            interactiveMap.SetTile(previousMousePos, null); // Remove old hoverTile
            interactiveMap.SetTile(mousePos, hoverTile);
            previousMousePos = mousePos;
        }
    }

    // Return mouse positions
    private Vector3Int GetMousePosition()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0;
        return interactiveMap.WorldToCell(mouseWorldPos);
    }
}
