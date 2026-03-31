using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class TileMapStuff : MonoBehaviour
{
    public Tilemap tilemap;
    public Transform highlight;
    //public CinemachineCollisionImpulseSource impulseSource;


    public Tile flower;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector3Int cellPos = tilemap.WorldToCell(mousePos);
        Vector3 pos = tilemap.GetCellCenterLocal(cellPos);

        //Debug.Log(mousePos + " is at cell " + cellPos);
        highlight.position = pos;

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            tilemap.SetTile(cellPos, flower);
            //impulseSource.GenerateImpulse();

        }
    }
}
