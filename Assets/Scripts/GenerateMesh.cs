using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMesh : MonoBehaviour
{
  List<Vector3> vertices = new List<Vector3>();
  List<Vector3> normals = new List<Vector3>();
  List<Vector3> uvs = new List<Vector3>();
  List<List<int>> submeshIndices = new List<List<int>>();

  public List<Vector3> Vertices {get {return vertices;} set {vertices = value;}}
  public List<Vector3> Normals {get {return normals;} set {normals = value;}}
  public List<Vector3> UVs {get {return uvs;} set {uvs = value;}}
  public List<List<int>> SubmeshIndices {get {return submeshIndices;} set {submeshIndices = value;}}
}
