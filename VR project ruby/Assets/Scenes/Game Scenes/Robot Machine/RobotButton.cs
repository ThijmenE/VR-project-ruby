using UnityEngine;
using System.Collections.Generic;

public class RobotButton : MonoBehaviour
{
    [SerializeField] private bool randomizePersonalityOnBuild = true;
    [SerializeField] private RobotPersonality personality = RobotPersonality.Happy;

    public RobotPersonality Personality => personality;

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

    public Material headMaterialOutput;
    public Material torsoMaterialOutput;
    public Material legsMaterialOutput;
    public Material hatMaterialOutput;
    public Material faceMaterialOutput;

    [SerializeField] private GameObject robot;

    private List<ObjectStatus> ItemsOpslaan = new List<ObjectStatus>();

    void Start()
    {
        if (robot != null)
        {
            BeginPos(robot);
        }
    }

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

            CopyPart(headMeshInput, headMeshOutput, "head");
            CopyPart(torsoMeshInput, torsoMeshOutput, "torso");
            CopyPart(legsMeshInput, legsMeshOutput, "legs");
            CopyPart(hatMeshInput, hatMeshOutput, "hat");
            CopyPart(faceMeshInput, faceMeshOutput, "face");

            if (robot == null && headMeshOutput.transform.parent != null)
            {
                robot = headMeshOutput.transform.parent.gameObject;
            }

            if (robot == null)
            {
                robot = headMeshOutput.gameObject;
            }

            if (ItemsOpslaan.Count == 0)
            {
                BeginPos(robot);
            }

            if (randomizePersonalityOnBuild)
            {
                personality = (RobotPersonality)Random.Range(0, System.Enum.GetValues(typeof(RobotPersonality)).Length);
            }

            Debug.Log($"Created robot with {personality} personality.");
        }
        else
        {
            Debug.Log("Cannot make robot");
        }
    }

    private static void CopyPart(MeshFilter input, MeshFilter output, string partName)
    {
        if (output == null)
        {
            Debug.LogWarning($"Cannot copy the {partName}: its output MeshFilter is not assigned.");
            return;
        }

        output.sharedMesh = input != null ? input.sharedMesh : null;

        Renderer outputRenderer = output.GetComponent<Renderer>();
        if (outputRenderer == null)
        {
            Debug.LogWarning($"Cannot copy materials for the {partName}: its output has no Renderer.");
            return;
        }

        Renderer inputRenderer = input != null ? input.GetComponent<Renderer>() : null;
        if (input != null && inputRenderer == null)
        {
            Debug.LogWarning($"Cannot copy materials for the {partName}: its input has no Renderer.");
        }

        outputRenderer.sharedMaterials = inputRenderer != null
            ? inputRenderer.sharedMaterials
            : new Material[0];
    }

    void BeginPos(GameObject obj)
    {
        ObjectStatus status = new ObjectStatus
        {
            gameObject = obj,
            startPosition = obj.transform.position,
            startRotation = obj.transform.rotation,
            rigidbody = obj.GetComponent<Rigidbody>()
        };

        ItemsOpslaan.Add(status);
    }

    public void ResetRobot()
    {
        foreach (ObjectStatus status in ItemsOpslaan)
        {
            if (status.gameObject != null)
            {
                status.gameObject.transform.position = status.startPosition;
                status.gameObject.transform.rotation = status.startRotation;

                if (status.rigidbody != null)
                {
                    status.rigidbody.linearVelocity = Vector3.zero;
                    status.rigidbody.angularVelocity = Vector3.zero;
                }
            }
        }
    }

    [System.Serializable]
    private class ObjectStatus
    {
        public GameObject gameObject;
        public Vector3 startPosition;
        public Quaternion startRotation;
        public Rigidbody rigidbody;
    }
}