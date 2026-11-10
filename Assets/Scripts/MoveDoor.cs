using UnityEngine;
using UnityEngine.ProBuilder;
using UnityEngine.ProBuilder.MeshOperations;

public class MoveDoor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ProBuilderMesh mesh = GetComponent<ProBuilderMesh>();
        foreach (Face face in mesh.faces) {
            mesh.DeleteFace(face);
        }
        mesh.ToMesh();
        mesh.Refresh();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
