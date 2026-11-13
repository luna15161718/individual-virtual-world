using UnityEngine;
using UnityEngine.ProBuilder;
using System.Collections.Generic;

public class ShowWindow : MonoBehaviour
{
    [SerializeField] List<int> faceList = new List<int>();
    [SerializeField] Material windowMaterial;
    List<Face> faces = new List<Face>();
    ProBuilderMesh mesh;
    MeshRenderer renderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mesh = GetComponent<ProBuilderMesh>();
        renderer = GetComponent<MeshRenderer>();
        foreach(int face in faceList) {
            faces.Add(mesh.faces[face]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateWindow()
    {
        List<Material> materials = new List<Material>(renderer.sharedMaterials);
        materials.Add(windowMaterial);
        renderer.sharedMaterials = materials.ToArray();
        mesh.SetMaterial(faces, windowMaterial);
        mesh.ToMesh();
        mesh.Refresh();
    }
}
