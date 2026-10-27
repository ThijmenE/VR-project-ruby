using UnityEngine;

public class RobotButton : MonoBehaviour
{
    public GameObject head;
    public GameObject torso;
    public GameObject legs;
    public GameObject hat;
    public GameObject face;

    public MeshFilter headMeshOutput;
    public MeshFilter torsoMeshOutput;
    public MeshFilter legsMeshOutput;
    public MeshFilter hatMeshOutput;
    public MeshFilter faceMeshOutput;

    public void RobotCreate()
    {
        head.TryGetComponent(out RobotAssembly headAssembly);
        torso.TryGetComponent(out RobotAssembly torsoAssembly);
        legs.TryGetComponent(out RobotAssembly legsAssembly);
        hat.TryGetComponent(out RobotAssembly hatAssembly);
        face.TryGetComponent(out RobotAssembly faceAssembly);

        if (headAssembly.isActive && torsoAssembly.isActive && legsAssembly.isActive)
        {
            MeshFilter headMeshInput = headAssembly.currentMeshFilter;
            MeshFilter torsoMeshInput = torsoAssembly.currentMeshFilter;
            MeshFilter legsMeshInput = legsAssembly.currentMeshFilter;
            MeshFilter hatMeshInput = hatAssembly.currentMeshFilter;
            MeshFilter faceMeshInput = faceAssembly.currentMeshFilter;

            headMeshOutput.sharedMesh = headMeshInput.sharedMesh;
            torsoMeshOutput.sharedMesh = torsoMeshInput.sharedMesh;
            legsMeshOutput.sharedMesh = legsMeshInput.sharedMesh;
            hatMeshOutput.sharedMesh = hatMeshInput != null ? hatMeshInput.sharedMesh : null;
            faceMeshOutput.sharedMesh = faceMeshInput != null ? faceMeshInput.sharedMesh : null;
            Debug.Log("Create robot");
        }
        else
        {
            Debug.Log("Cannot make robot");
        }
    }
}