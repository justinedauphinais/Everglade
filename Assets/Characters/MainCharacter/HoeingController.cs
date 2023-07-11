using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HoeingController : MonoBehaviour
{
    [SerializeField] private Tilemap terrainMap;
    [SerializeField] private Tile hoedTile;
    [SerializeField] private Tile unhoedTile;

    [SerializeField] private DialogueUIController dialogueUI;

    private bool isHoeing = false;
    private bool isUnhoeing = false;

    // Update is called once per frame
    void Update()
    {
        if (dialogueUI.IsOpen)
        {
            Debug.Log("Can't hoe");
            return;
        }

        Debug.Log("Can hoe");

        if (Input.GetMouseButton(0))
        {
            Vector3Int mousePos = GetMousePosition();
            if (terrainMap.GetTile(mousePos) == hoedTile && !isHoeing)
            {
                terrainMap.SetTile(mousePos, unhoedTile);
                isUnhoeing = true;
            }
            else if (!isUnhoeing)
            {
                terrainMap.SetTile(mousePos, hoedTile);
                isHoeing = true;
            }
        }
        else
        {
            isHoeing = false;
            isUnhoeing = false;
        }
    }

    // Return mouse positions
    private Vector3Int GetMousePosition()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0;
        return terrainMap.WorldToCell(mouseWorldPos);
    }
}
