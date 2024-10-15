using UnityEngine;
using Cinemachine;

public class SwitchConfineBoundingShape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SwithcBoundingShape();
    }

    private void SwithcBoundingShape()
    {
        PolygonCollider2D polygonConfiner2d = GameObject.FindGameObjectWithTag(Tags.BoundsConfiner).GetComponent<PolygonCollider2D>();
        CinemachineConfiner2D cinemachineConfiner2D = GetComponent<CinemachineConfiner2D>();

        cinemachineConfiner2D.m_BoundingShape2D = polygonConfiner2d;

        cinemachineConfiner2D.InvalidateCache();
    }
}
