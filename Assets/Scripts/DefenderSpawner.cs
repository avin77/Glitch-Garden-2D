using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{

    Defender defender;
    private void OnMouseDown() {
        SpawnDefender(GetSquareClicked());
    }

    private Vector2 GetSquareClicked() {
        Vector2 screenPosition = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        worldPosition = RoundVector2Float(worldPosition);
        return worldPosition;
    }

    private void SpawnDefender(Vector2 roundWorldPos) {
        Defender newDefender = Instantiate(defender, roundWorldPos, Quaternion.identity) as Defender;
    }

    public void setSelectedDefender(Defender defenderToSelect) {
        defender = defenderToSelect;
    }

    private Vector2 RoundVector2Float(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }
}
