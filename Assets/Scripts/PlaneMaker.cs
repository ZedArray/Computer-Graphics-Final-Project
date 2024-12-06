using UnityEngine;

public class PlaneMaker : MonoBehaviour
{
    public Vector3[] newVertices;
    public Vector2[] newUV;
    public int[] newTriangles;
    Vector3[] normals = new Vector3[4];

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        normals[0] = Vector3.up;
        normals[1] = Vector3.up;
        normals[2] = Vector3.up;
        normals[3] = Vector3.up;

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newVertices;
        mesh.uv = newUV;
        mesh.normals = normals;
        mesh.triangles = newTriangles;
    }

}
