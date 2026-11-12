using UnityEngine;
using UnityEngine.ProBuilder;
using UnityEngine.ProBuilder.MeshOperations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MoveDoor : MonoBehaviour
{
    [SerializeField] List<int> faceList = new List<int>();
    List<Face> faces = new List<Face>();
    ProBuilderMesh mesh;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mesh = GetComponent<ProBuilderMesh>();
        foreach(int face in faceList) {
            faces.Add(mesh.faces[face]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        foreach(Face face in faces) {
            StartCoroutine(MoveDown(face));
        }
        mesh.ToMesh();
        mesh.Refresh();
    }

    IEnumerator MoveDown(Face face) {
        int distance = 100;
        int moved = 0;
        while(moved < distance) {
            VertexEditing.SplitVertices(mesh, face.distinctIndexes);
            mesh.TranslateVerticesInWorldSpace(face.distinctIndexes.ToArray(), Vector3.down * 0.1f);
            moved++;
            yield return null;
        }
        mesh.ToMesh();
        mesh.Refresh();
    }
}
