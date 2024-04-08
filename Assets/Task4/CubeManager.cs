using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public GameObject CubePrefab;
    public Camera CameraLink;
    private Vector3 _cursorPosition;

    void Update()
    {
        _cursorPosition = Input.mousePosition;
        Ray ray = CameraLink.ScreenPointToRay(_cursorPosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(2))
            {
                GameObject cube = Instantiate(CubePrefab);
                cube.transform.position = hit.point;
            }
            if (Input.GetMouseButtonDown(1) && hit.collider.GetComponent<Cube>())
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
