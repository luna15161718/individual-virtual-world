using UnityEngine;
using UnityEngine.ProBuilder;
using UnityEngine.ProBuilder.MeshOperations;

public class MoveDoor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ProBuilderMesh mesh = GetComponent<ProBuilderMesh>();
        VertexEditing.SplitVertices(mesh, mesh.faces[549].distinctIndexes);
        VertexPositioning.TranslateVertices(mesh, mesh.faces[549].distinctIndexes, mesh.transform.InverseTransformDirection(Vector3.down * 10));
        //mesh.DeleteFace(mesh.faces[549]);
        mesh.ToMesh();
        mesh.Refresh();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
