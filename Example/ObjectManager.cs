using System;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    [SerializeField] private ObjectsData objectData;
    [SerializeField] private string ObjectID;

    private void Awake() {
        SetObjectID();
    }

    public string GetObjectID { get { return ObjectID; } }
    public string GetObjectName { get { return objectData.GetObjectName; } }
    public string GetObjectDescription { get { return objectData.GetObjectDescription; } }
    public InteractableType GetInteractableType { get { return objectData.GetInteractableType; } }


    public void SetObjectID() {
        ObjectID = Guid.NewGuid().ToString();
    }

}
