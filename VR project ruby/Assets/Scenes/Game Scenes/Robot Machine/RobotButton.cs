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

            headMeshOutput.sharedMesh = headMeshInput.sharedMesh;
            torsoMeshOutput.sharedMesh = torsoMeshInput.sharedMesh;
            legsMeshOutput.sharedMesh = legsMeshInput.sharedMesh;
            hatMeshOutput.sharedMesh = hatMeshInput != null ? hatMeshInput.sharedMesh : null;
            faceMeshOutput.sharedMesh = faceMeshInput != null ? faceMeshInput.sharedMesh : null;

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

            Robottext robotText = GetComponent<Robottext>();
            if (robotText == null)
            {
                Debug.LogError("Cannot schedule robot dialogue because this object has no Robottext component.", this);
            }
            else
            {
                robotText.RobotCreated();
            }
        }
        else
        {
            Debug.Log("Cannot make robot");
        }
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