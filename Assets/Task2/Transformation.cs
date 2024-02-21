using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformation : MonoBehaviour
{
    public Vector3 Pos1;
    public Vector3 Pos2;
    public Color Color1;
    public Color Color2;
    public Vector3 Scale1;
    public Vector3 Scale2;
    [Range(0f, 1f)]
    public float value;

    private MeshRenderer _meshRenderer;
    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        transform.position = Vector3.Lerp(Pos1, Pos2, value);
        _meshRenderer.material.color = Color.Lerp(Color1, Color2, value);
        transform.localScale = Vector3.Lerp(Scale1, Scale2, value);
    }
}
