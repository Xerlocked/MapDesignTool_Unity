using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Snap : MonoBehaviour
{
    [FormerlySerializedAs("gridSize")] [SerializeField] private Vector3 snapSize = default;
    
    private void OnDrawGizmos()
    {
        SnapToGrid();
    }

    void SnapToGrid()
    {
        Vector3 position = new Vector3(
            Mathf.Round(this.transform.position.x / snapSize.x) * snapSize.x,
            Mathf.Round(this.transform.position.y / snapSize.y) * snapSize.y,
            Mathf.Round(this.transform.position.z / snapSize.z) * snapSize.z
        );

        this.transform.position = position;
    }
}
